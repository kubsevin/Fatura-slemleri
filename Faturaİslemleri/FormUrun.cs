using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Faturaİslemleri
{
    public partial class FormUrun : Form
    {
        public FormUrun()
        {
            InitializeComponent();
        }
        FaturaContext db = new FaturaContext();
        int secilenid;
        List<UrunSecilen> urunlistesi = new List<UrunSecilen>();
        private void FormUrun_Load(object sender, EventArgs e)
        {
            BirimListele();
            Listele();
        }

        private void BirimListele()
        {
            var list = db.Birimler.Select(x => new
            {
                x.BirimId,
                x.BirimAdi
            }).OrderBy(x => x.BirimAdi).ToList();
            comboBirim.DisplayMember = "BirimAdi";
            comboBirim.ValueMember = "BirimId";
            comboBirim.DataSource = list;
        }
        private void btnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                Urun urun = new Urun();
                urun.UrunAdi = txtUrunAdi.Text;
                urun.UrunKodu = txtUrunKodu.Text;
                urun.BirimFiyat = Convert.ToDecimal(txtBirimFiyat.Text);
                urun.BirimID = Convert.ToInt32(comboBirim.SelectedValue);
                db.Urunler.Add(urun);
                db.SaveChanges();
                Listele();
            }
            catch
            {
                MessageBox.Show("Lütfen tüm alanları doldurunuz.");
            }

        }
        private void Listele()
        {
            try
            {
                var list = db.Urunler.Select(x => new
                {
                    x.BirimID,
                    x.UrunID,
                    UrunAdi = x.UrunAdi,
                    BirimAdi = x.Birim.BirimAdi,
                    UrunFiyat = x.BirimFiyat,
                    UrunKodu = x.UrunKodu
                }).Where(x => x.BirimID == (int)comboBirim.SelectedValue).OrderBy(x => x.UrunAdi).ToList();
                dataGridView1.DataSource = list;
                dataGridView1.Columns["BirimID"].Visible = false;
                dataGridView1.Columns["UrunID"].Visible = false;
                Temizle();
            }
            catch (Exception)
            {

                MessageBox.Show("Hata oluştu");
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                Urun urun = db.Urunler.Find(secilenid);
                urun.UrunAdi = txtUrunAdi.Text;
                urun.BirimFiyat = Convert.ToDecimal(txtBirimFiyat.Text);
                urun.UrunKodu = txtUrunKodu.Text;
                urun.BirimID = Convert.ToInt32(comboBirim.SelectedValue);
                db.SaveChanges();
                Listele();
            }
            catch (Exception)
            {
                MessageBox.Show("Hata Oluştu");
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                Urun urun = db.Urunler.Find(secilenid);
                db.Urunler.Remove(urun);
                db.SaveChanges();
                Listele();
            }
            catch (Exception)
            {

                MessageBox.Show("Hata Oluştu");
            }
        }

        private void Temizle()
        {
            txtBirimFiyat.Clear();
            txtUrunAdi.Clear();
            txtUrunKodu.Clear();
            comboBirim.Focus();
        }
        private void txtTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                secilenid = Convert.ToInt32(dataGridView1.CurrentRow.Cells[1].Value);
                Urun urun = db.Urunler.Find(secilenid);
                txtUrunAdi.Text = urun.UrunAdi;
                txtUrunKodu.Text = urun.UrunKodu;
                txtBirimFiyat.Text = urun.BirimFiyat.ToString();
                comboBirim.SelectedItem = secilenid;
            }
            catch (Exception)
            {

                return;
            }
        }

        private void comboBirim_SelectedIndexChanged(object sender, EventArgs e)
        {
            Listele();
        }
    }
}
