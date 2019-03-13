using FaturaProje;
using FaturaProje.Formlar;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ilEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sehirler iller = new Sehirler();
            iller.Show();
        }

        private void ilçeEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ilceler ilceler = new Ilceler();
            ilceler.Show();
        }

        private void birimEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormBirim birimler = new FormBirim();
            birimler.Show();
        }


        private void ürünEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormUrun urunler = new FormUrun();
            urunler.Show();
        }

        private void musteriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormMusteri musteriler = new FormMusteri();
            musteriler.Show();
        }

        private void yeniFaturaOluşturToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormYeniFatura yeniFatura = new FormYeniFatura();
            yeniFatura.Show();
        }
    }
}
