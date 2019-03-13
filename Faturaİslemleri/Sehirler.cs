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
    public partial class Sehirler : Form
    {
        public Sehirler()
        {
            InitializeComponent();

        }
        FaturaContext db = new FaturaContext();
        int secilenID;

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            secilenID = Convert.ToInt32(dgvSehirler.CurrentRow.Cells[0].Value);
            Il il = db.Iller.Find(secilenID);
            txtSehirAdi.Text = il.Aciklama;
        }

        private void Sehirler_Load(object sender, EventArgs e)
        {
            Listele();
        }
        private void Listele()
        {
            var list = db.Iller.Select(x => new
            {
                sehirKodu = x.IlId,
                sehirAdi = x.Aciklama
            });

            var n = list.ToList();
            dgvSehirler.DataSource = n;
            txtSehirAdi.Clear();
            txtSehirAdi.Focus();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                Il il = new Il();
                il.Aciklama = txtSehirAdi.Text;
                db.Iller.Add(il);
                db.SaveChanges();
                Listele();
            }
            catch (Exception)
            {
                MessageBox.Show("Lütfen tüm değerleri giriniz.");
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                Il il = db.Iller.Find(secilenID);
                il.Aciklama = txtSehirAdi.Text;
                db.SaveChanges();
                Listele();

            }

            catch (Exception)
            {

                MessageBox.Show("Lütfen bir il seçiniz.");
            }
        }
    

        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                Il il = db.Iller.Find(secilenID);
                db.Iller.Remove(il);
                db.SaveChanges();
                Listele();

            }
            catch (Exception)
            {

                MessageBox.Show("Lütfen bir il seçiniz.");
            }
        }

     
    }
}
