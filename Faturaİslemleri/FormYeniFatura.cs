using Faturaİslemleri;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace FaturaProje
{
    public partial class FormYeniFatura : Form
    {
        FaturaContext db = new FaturaContext();
        int secilenID;
        List<UrunSecilen> urunlistesi = new List<UrunSecilen>();
        public FormYeniFatura()
        {
            InitializeComponent();
        }

        private void FormYeniFatura_Load(object sender, EventArgs e)
        {
            MusteriSehirDoldur();
            UrunDoldur();
        }
        private void MusteriSehirDoldur()
        {
            var list = db.Iller.ToList();
            cbMusteriSehir.DisplayMember = "Aciklama";
            cbMusteriSehir.ValueMember = "IlId";
            cbMusteriSehir.DataSource = list;
        }
        private void IlceDoldur()
        {
            var list = db.Ilceler.Where(x => x.IlId == (int)cbMusteriSehir.SelectedValue).ToList();
            cbMusteriİlce.DisplayMember = "Aciklama";
            cbMusteriİlce.ValueMember = "IlceId";
            cbMusteriİlce.DataSource = list;
        }
        private void MusteriDoldur()
        {
            var mlist = db.Musteriler.Select(x => new
            {
                x.IlceID,
                x.MusteriID,
                x.MusteriUnvani
            }).Where(x => x.IlceID == (int)cbMusteriİlce.SelectedValue).OrderBy(x => x.MusteriUnvani).ToList();
            if (mlist.Count != 0)
            {
                cbMusteri.DisplayMember = "MusteriUnvani";
                cbMusteri.ValueMember = "MusteriID";
                cbMusteri.DataSource = mlist;
            }
            else
            {
                cbMusteri.DataSource = null;
            }
        }
        private void UrunDoldur()
        {
            var ulist = db.Urunler.Select(x => new
            {
                x.UrunID,
                x.UrunAdi
            }).OrderBy(x => x.UrunAdi).ToList();
            cbUrunAdi.DisplayMember = "UrunAdi";
            cbUrunAdi.ValueMember = "UrunID";
            cbUrunAdi.DataSource = ulist;
        }
        private void Listele()
        {
            dgvYeniFatura.DataSource = urunlistesi.Select(x => new
            {
                x.UrunID,
                x.UrunAdi,
                x.UrunFiyat,
                x.Miktar,
                x.KDV,
                x.ToplamTutar,
                GenelToplam = x.ToplamTutar + x.ToplamTutar * x.KDV
            }).ToList();
            dgvYeniFatura.Columns[0].Visible = false;
            Temizle();
            FaturaToplam();
        }
        private void Temizle()
        {
            nudUrunMiktar.Value = 0;
        }

        private void FaturaToplam()
        {
            decimal toplam = 0;

            for (int i = 0; i < dgvYeniFatura.Rows.Count; i++)
            {

                toplam += Convert.ToDecimal(dgvYeniFatura[6, i].Value);
            }
            lblFaturaToplam.Text = Convert.ToString(String.Format("{0:0.00}", toplam + "TL"));
            toplam = Math.Round(toplam, 2);

        }
        private void cbMusteriSehir_SelectedIndexChanged(object sender, EventArgs e)
        {
            IlceDoldur();
        }
        private void cbMusteriİlce_SelectedIndexChanged(object sender, EventArgs e)
        {
            MusteriDoldur();
        }

        private void btnUrunEkle_Click(object sender, EventArgs e)
        {

            urunlistesi.Add(new UrunSecilen
            {
                UrunID = (int)cbUrunAdi.SelectedValue,
                UrunAdi = cbUrunAdi.Text,
                UrunFiyat = Convert.ToDecimal(txtUrunFiyati.Text),
                KDV = Convert.ToDecimal(txtUrunKDV.Text),
                Miktar = (decimal)nudUrunMiktar.Value,
                ToplamTutar = Convert.ToDecimal(txtUrunFiyati.Text) * (decimal)nudUrunMiktar.Value
            });
            Listele();

        }

        private void btnUrunGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                var urun = urunlistesi.Where(x => x.UrunID == secilenID).FirstOrDefault();
                if (secilenID == (int)cbUrunAdi.SelectedValue)
                {
                    urun.Miktar = (decimal)nudUrunMiktar.Value;
                    urun.ToplamTutar = Convert.ToDecimal(txtUrunFiyati.Text) * (decimal)nudUrunMiktar.Value;
                }
                else
                {
                    urun.UrunID = (int)cbUrunAdi.SelectedValue;
                    urun.UrunAdi = cbUrunAdi.Text;
                    urun.UrunFiyat = Convert.ToDecimal(txtUrunFiyati.Text);
                    urun.Miktar = (decimal)nudUrunMiktar.Value;
                    urun.ToplamTutar = Convert.ToDecimal(txtUrunFiyati.Text) * (decimal)nudUrunMiktar.Value;
                }
                Listele();
            }
            catch (Exception)
            {
                MessageBox.Show("Lütfen listeden ürün seçiniz..");
            }
        }

        private void btnUrunSil_Click(object sender, EventArgs e)
        {
            try
            {
                var urun = urunlistesi.Where(x => x.UrunID == secilenID).FirstOrDefault();
                urunlistesi.Remove(urun);
                Listele();
            }
            catch (Exception)
            {
                MessageBox.Show("Lütfen listeden ürün seçiniz..");
            }

        }

        private void btnFaturaKaydet_Click(object sender, EventArgs e)
        {
            DbContextTransaction tran = db.Database.BeginTransaction();
            try
            {
                FaturaKaydet();
                FaturaDetayKaydet();
                tran.Commit();
            }
            catch (Exception)
            {
                tran.Rollback();
                MessageBox.Show("Beklenmeyen bir hata oluştu.");
            }

        }

        private void FaturaKaydet()
        {

            FaturaMaster fm = new FaturaMaster();
            fm.IrsaliyeNo = Convert.ToInt32(txtIrsaliyeNo.Text);
            fm.OdemeTarihi = dtpOdemeTarihi.Value;
            fm.MusteriID = (int)cbMusteri.SelectedValue;
            db.FaturaMasters.Add(fm);
            db.SaveChanges();
            lblFaturaID.Text = fm.FaturaID.ToString();
        }
        private void FaturaDetayKaydet()
        {
            foreach (UrunSecilen item in urunlistesi)
            {
                FaturaDetay fd = new FaturaDetay();
                fd.FaturaID = Convert.ToInt32(lblFaturaID.Text);
                fd.UrunID = item.UrunID;
                fd.Miktar = item.Miktar;
                fd.KDV = item.KDV;
                fd.ToplamFiyat = item.Miktar * item.UrunFiyat;
                fd.KDVliFiyat = fd.ToplamFiyat + fd.ToplamFiyat * fd.KDV;
                fd.FaturaToplam = Convert.ToDecimal(lblFaturaToplam.Text.Substring(0, lblFaturaToplam.Text.Length - 2));
                db.FaturaDetays.Add(fd);
            }
            db.SaveChanges();
            MessageBox.Show("Ürünler başarılı bir şekilde faturaya eklendi.\nFatura kayıt edildi");

        }

        private void btnListeTemizle_Click(object sender, EventArgs e)
        {
            dgvYeniFatura.Columns.Clear();
            urunlistesi.Clear();
        }

        private void cbUrunAdi_SelectedIndexChanged(object sender, EventArgs e)
        {
            decimal fiyat = db.Urunler.Find((int)cbUrunAdi.SelectedValue).BirimFiyat;
            txtUrunFiyati.Text = fiyat.ToString();
            string birim = db.Urunler.Find((int)cbUrunAdi.SelectedValue).Birim.BirimAdi;
            txtUrunBirimi.Text = birim;
            txtUrunKDV.Text = "0,18";
        }

        private void dgvYeniFatura_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            secilenID = (int)dgvYeniFatura.CurrentRow.Cells[0].Value;
            var urun = urunlistesi.Where(x => x.UrunID == secilenID).FirstOrDefault();
            cbUrunAdi.SelectedValue = secilenID;
            nudUrunMiktar.Value = urun.Miktar;
        }
    }
}