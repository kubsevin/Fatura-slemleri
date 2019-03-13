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
    public partial class FormBirim : Form
    {
        public FormBirim()
        {
            InitializeComponent();
        }
        FaturaContext db = new FaturaContext();
        int secilenid;

        private void FormBirim_Load(object sender, EventArgs e)
        {
            Listele();
        }
        private void Listele()
        {
            var list = db.Birimler.Select(x => new
            {
                BirimKodu = x.BirimId,
                BirimAdi = x.BirimAdi
            });

            var n = list.ToList();
            dgvBirimler.DataSource = n;
            txtBirim.Clear();
            txtBirim.Focus();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                Birim birim = new Birim();
                birim.BirimAdi = txtBirim.Text;
                db.Birimler.Add(birim);
                db.SaveChanges();
                Listele();
            }
            catch (Exception)
            {
                MessageBox.Show("Lütfen tüm değerleri giriniz.");
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                Birim birim = db.Birimler.Find(secilenid);
                db.Birimler.Remove(birim);
                db.SaveChanges();
                Listele();

            }
            catch (Exception)
            {

                MessageBox.Show("Lütfen bir birim seçiniz.");
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                Birim birim = db.Birimler.Find(secilenid);
                birim.BirimAdi = txtBirim.Text;
                db.SaveChanges();
                Listele();

            }

            catch (Exception)
            {

                MessageBox.Show("Lütfen bir birim seçiniz.");
            }
        }

        private void dgvBirimler_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            secilenid = Convert.ToInt32(dgvBirimler.CurrentRow.Cells[0].Value);
            Birim birim = db.Birimler.Find(secilenid);
            txtBirim.Text = birim.BirimAdi;
        }
    }
    
}
