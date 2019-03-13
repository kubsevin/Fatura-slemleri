namespace FaturaProje
{
    partial class FormYeniFatura
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtpOdemeTarihi = new System.Windows.Forms.DateTimePicker();
            this.txtIrsaliyeNo = new System.Windows.Forms.TextBox();
            this.cbMusteri = new System.Windows.Forms.ComboBox();
            this.cbMusteriİlce = new System.Windows.Forms.ComboBox();
            this.cbMusteriSehir = new System.Windows.Forms.ComboBox();
            this.lblFaturaID = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.nudUrunMiktar = new System.Windows.Forms.NumericUpDown();
            this.txtUrunFiyati = new System.Windows.Forms.TextBox();
            this.txtUrunKDV = new System.Windows.Forms.TextBox();
            this.txtUrunBirimi = new System.Windows.Forms.TextBox();
            this.cbUrunAdi = new System.Windows.Forms.ComboBox();
            this.btnUrunSil = new System.Windows.Forms.Button();
            this.btnUrunGuncelle = new System.Windows.Forms.Button();
            this.btnUrunEkle = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnFaturaKaydet = new System.Windows.Forms.Button();
            this.btnListeTemizle = new System.Windows.Forms.Button();
            this.dgvYeniFatura = new System.Windows.Forms.DataGridView();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lblFaturaToplam = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudUrunMiktar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvYeniFatura)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtpOdemeTarihi);
            this.groupBox1.Controls.Add(this.txtIrsaliyeNo);
            this.groupBox1.Controls.Add(this.cbMusteri);
            this.groupBox1.Controls.Add(this.cbMusteriİlce);
            this.groupBox1.Controls.Add(this.cbMusteriSehir);
            this.groupBox1.Controls.Add(this.lblFaturaID);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(382, 189);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Müşteri ve İrsaliye";
            // 
            // dtpOdemeTarihi
            // 
            this.dtpOdemeTarihi.Location = new System.Drawing.Point(151, 155);
            this.dtpOdemeTarihi.Name = "dtpOdemeTarihi";
            this.dtpOdemeTarihi.Size = new System.Drawing.Size(193, 20);
            this.dtpOdemeTarihi.TabIndex = 4;
            // 
            // txtIrsaliyeNo
            // 
            this.txtIrsaliyeNo.Location = new System.Drawing.Point(151, 120);
            this.txtIrsaliyeNo.Name = "txtIrsaliyeNo";
            this.txtIrsaliyeNo.Size = new System.Drawing.Size(193, 20);
            this.txtIrsaliyeNo.TabIndex = 3;
            // 
            // cbMusteri
            // 
            this.cbMusteri.FormattingEnabled = true;
            this.cbMusteri.Location = new System.Drawing.Point(151, 93);
            this.cbMusteri.Name = "cbMusteri";
            this.cbMusteri.Size = new System.Drawing.Size(193, 21);
            this.cbMusteri.TabIndex = 2;
            // 
            // cbMusteriİlce
            // 
            this.cbMusteriİlce.FormattingEnabled = true;
            this.cbMusteriİlce.Location = new System.Drawing.Point(151, 66);
            this.cbMusteriİlce.Name = "cbMusteriİlce";
            this.cbMusteriİlce.Size = new System.Drawing.Size(193, 21);
            this.cbMusteriİlce.TabIndex = 2;
            this.cbMusteriİlce.SelectedIndexChanged += new System.EventHandler(this.cbMusteriİlce_SelectedIndexChanged);
            // 
            // cbMusteriSehir
            // 
            this.cbMusteriSehir.FormattingEnabled = true;
            this.cbMusteriSehir.Location = new System.Drawing.Point(151, 40);
            this.cbMusteriSehir.Name = "cbMusteriSehir";
            this.cbMusteriSehir.Size = new System.Drawing.Size(193, 21);
            this.cbMusteriSehir.TabIndex = 2;
            this.cbMusteriSehir.SelectedIndexChanged += new System.EventHandler(this.cbMusteriSehir_SelectedIndexChanged);
            // 
            // lblFaturaID
            // 
            this.lblFaturaID.AutoSize = true;
            this.lblFaturaID.Location = new System.Drawing.Point(167, 20);
            this.lblFaturaID.Name = "lblFaturaID";
            this.lblFaturaID.Size = new System.Drawing.Size(13, 13);
            this.lblFaturaID.TabIndex = 1;
            this.lblFaturaID.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 153);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Ödeme Tarihi:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Müşteri İlçesi:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "İrsaliye No:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Müşteri:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Müşteri Şehri:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fatura No:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.nudUrunMiktar);
            this.groupBox2.Controls.Add(this.txtUrunFiyati);
            this.groupBox2.Controls.Add(this.txtUrunKDV);
            this.groupBox2.Controls.Add(this.txtUrunBirimi);
            this.groupBox2.Controls.Add(this.cbUrunAdi);
            this.groupBox2.Controls.Add(this.btnUrunSil);
            this.groupBox2.Controls.Add(this.btnUrunGuncelle);
            this.groupBox2.Controls.Add(this.btnUrunEkle);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Location = new System.Drawing.Point(430, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(362, 189);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ürün İşlemleri";
            // 
            // nudUrunMiktar
            // 
            this.nudUrunMiktar.Location = new System.Drawing.Point(148, 126);
            this.nudUrunMiktar.Name = "nudUrunMiktar";
            this.nudUrunMiktar.Size = new System.Drawing.Size(193, 20);
            this.nudUrunMiktar.TabIndex = 4;
            // 
            // txtUrunFiyati
            // 
            this.txtUrunFiyati.Location = new System.Drawing.Point(148, 47);
            this.txtUrunFiyati.Name = "txtUrunFiyati";
            this.txtUrunFiyati.Size = new System.Drawing.Size(193, 20);
            this.txtUrunFiyati.TabIndex = 3;
            // 
            // txtUrunKDV
            // 
            this.txtUrunKDV.Location = new System.Drawing.Point(148, 99);
            this.txtUrunKDV.Name = "txtUrunKDV";
            this.txtUrunKDV.Size = new System.Drawing.Size(193, 20);
            this.txtUrunKDV.TabIndex = 3;
            // 
            // txtUrunBirimi
            // 
            this.txtUrunBirimi.Location = new System.Drawing.Point(148, 73);
            this.txtUrunBirimi.Name = "txtUrunBirimi";
            this.txtUrunBirimi.Size = new System.Drawing.Size(193, 20);
            this.txtUrunBirimi.TabIndex = 3;
            // 
            // cbUrunAdi
            // 
            this.cbUrunAdi.FormattingEnabled = true;
            this.cbUrunAdi.Location = new System.Drawing.Point(148, 19);
            this.cbUrunAdi.Name = "cbUrunAdi";
            this.cbUrunAdi.Size = new System.Drawing.Size(193, 21);
            this.cbUrunAdi.TabIndex = 2;
            this.cbUrunAdi.SelectedIndexChanged += new System.EventHandler(this.cbUrunAdi_SelectedIndexChanged);
            // 
            // btnUrunSil
            // 
            this.btnUrunSil.Location = new System.Drawing.Point(242, 152);
            this.btnUrunSil.Name = "btnUrunSil";
            this.btnUrunSil.Size = new System.Drawing.Size(99, 23);
            this.btnUrunSil.TabIndex = 1;
            this.btnUrunSil.Text = "Ürün Sil";
            this.btnUrunSil.UseVisualStyleBackColor = true;
            this.btnUrunSil.Click += new System.EventHandler(this.btnUrunSil_Click);
            // 
            // btnUrunGuncelle
            // 
            this.btnUrunGuncelle.Location = new System.Drawing.Point(137, 152);
            this.btnUrunGuncelle.Name = "btnUrunGuncelle";
            this.btnUrunGuncelle.Size = new System.Drawing.Size(99, 23);
            this.btnUrunGuncelle.TabIndex = 1;
            this.btnUrunGuncelle.Text = "Ürün Güncelle";
            this.btnUrunGuncelle.UseVisualStyleBackColor = true;
            this.btnUrunGuncelle.Click += new System.EventHandler(this.btnUrunGuncelle_Click);
            // 
            // btnUrunEkle
            // 
            this.btnUrunEkle.Location = new System.Drawing.Point(27, 152);
            this.btnUrunEkle.Name = "btnUrunEkle";
            this.btnUrunEkle.Size = new System.Drawing.Size(99, 23);
            this.btnUrunEkle.TabIndex = 1;
            this.btnUrunEkle.Text = "Ürün Ekle";
            this.btnUrunEkle.UseVisualStyleBackColor = true;
            this.btnUrunEkle.Click += new System.EventHandler(this.btnUrunEkle_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(27, 126);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Ürün Miktarı:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(27, 73);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(60, 13);
            this.label11.TabIndex = 0;
            this.label11.Text = "Ürün Birimi:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(27, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Ürün Adı:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(27, 47);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Ürün Fiyatı:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(27, 98);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Ürün KDV:";
            // 
            // btnFaturaKaydet
            // 
            this.btnFaturaKaydet.Location = new System.Drawing.Point(798, 34);
            this.btnFaturaKaydet.Name = "btnFaturaKaydet";
            this.btnFaturaKaydet.Size = new System.Drawing.Size(111, 47);
            this.btnFaturaKaydet.TabIndex = 1;
            this.btnFaturaKaydet.Text = "Fatura Kaydet";
            this.btnFaturaKaydet.UseVisualStyleBackColor = true;
            this.btnFaturaKaydet.Click += new System.EventHandler(this.btnFaturaKaydet_Click);
            // 
            // btnListeTemizle
            // 
            this.btnListeTemizle.Location = new System.Drawing.Point(798, 127);
            this.btnListeTemizle.Name = "btnListeTemizle";
            this.btnListeTemizle.Size = new System.Drawing.Size(111, 47);
            this.btnListeTemizle.TabIndex = 1;
            this.btnListeTemizle.Text = "Liste Temizle";
            this.btnListeTemizle.UseVisualStyleBackColor = true;
            this.btnListeTemizle.Click += new System.EventHandler(this.btnListeTemizle_Click);
            // 
            // dgvYeniFatura
            // 
            this.dgvYeniFatura.BackgroundColor = System.Drawing.Color.RosyBrown;
            this.dgvYeniFatura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvYeniFatura.Location = new System.Drawing.Point(12, 207);
            this.dgvYeniFatura.Name = "dgvYeniFatura";
            this.dgvYeniFatura.Size = new System.Drawing.Size(897, 259);
            this.dgvYeniFatura.TabIndex = 2;
            this.dgvYeniFatura.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvYeniFatura_CellClick);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(631, 476);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(83, 13);
            this.label12.TabIndex = 0;
            this.label12.Text = "Fatura Toplamı=";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(720, 476);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(0, 13);
            this.label13.TabIndex = 0;
            // 
            // lblFaturaToplam
            // 
            this.lblFaturaToplam.AutoSize = true;
            this.lblFaturaToplam.Location = new System.Drawing.Point(737, 476);
            this.lblFaturaToplam.Name = "lblFaturaToplam";
            this.lblFaturaToplam.Size = new System.Drawing.Size(13, 13);
            this.lblFaturaToplam.TabIndex = 3;
            this.lblFaturaToplam.Text = "0";
            // 
            // FormYeniFatura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(921, 498);
            this.Controls.Add(this.lblFaturaToplam);
            this.Controls.Add(this.dgvYeniFatura);
            this.Controls.Add(this.btnListeTemizle);
            this.Controls.Add(this.btnFaturaKaydet);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Name = "FormYeniFatura";
            this.Text = "FormYeniFatura";
            this.Load += new System.EventHandler(this.FormYeniFatura_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudUrunMiktar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvYeniFatura)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnFaturaKaydet;
        private System.Windows.Forms.Button btnListeTemizle;
        private System.Windows.Forms.DataGridView dgvYeniFatura;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnUrunSil;
        private System.Windows.Forms.Button btnUrunGuncelle;
        private System.Windows.Forms.Button btnUrunEkle;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dtpOdemeTarihi;
        private System.Windows.Forms.TextBox txtIrsaliyeNo;
        private System.Windows.Forms.ComboBox cbMusteri;
        private System.Windows.Forms.ComboBox cbMusteriİlce;
        private System.Windows.Forms.ComboBox cbMusteriSehir;
        private System.Windows.Forms.Label lblFaturaID;
        private System.Windows.Forms.NumericUpDown nudUrunMiktar;
        private System.Windows.Forms.TextBox txtUrunFiyati;
        private System.Windows.Forms.TextBox txtUrunKDV;
        private System.Windows.Forms.TextBox txtUrunBirimi;
        private System.Windows.Forms.ComboBox cbUrunAdi;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblFaturaToplam;
    }
}