namespace FaturaProje.Formlar
{
    partial class FormMusteri
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
            this.dgvMusteriler = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.txtMusteriUnvani = new System.Windows.Forms.TextBox();
            this.comboMusteriSehir = new System.Windows.Forms.ComboBox();
            this.comboMusteriIlce = new System.Windows.Forms.ComboBox();
            this.txtMusteriAdresi = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMusteriler)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMusteriler
            // 
            this.dgvMusteriler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMusteriler.Location = new System.Drawing.Point(12, 149);
            this.dgvMusteriler.Name = "dgvMusteriler";
            this.dgvMusteriler.Size = new System.Drawing.Size(651, 150);
            this.dgvMusteriler.TabIndex = 0;
            this.dgvMusteriler.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Müşteri Ünvanı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Müşteri Şehri";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(308, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Müşteri Adresi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Müşteri İlçesi";
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(311, 100);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(75, 23);
            this.btnEkle.TabIndex = 3;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(426, 100);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(75, 23);
            this.btnGuncelle.TabIndex = 3;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(538, 100);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(75, 23);
            this.btnSil.TabIndex = 3;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // txtMusteriUnvani
            // 
            this.txtMusteriUnvani.Location = new System.Drawing.Point(136, 24);
            this.txtMusteriUnvani.Name = "txtMusteriUnvani";
            this.txtMusteriUnvani.Size = new System.Drawing.Size(145, 20);
            this.txtMusteriUnvani.TabIndex = 4;
            // 
            // comboMusteriSehir
            // 
            this.comboMusteriSehir.FormattingEnabled = true;
            this.comboMusteriSehir.Location = new System.Drawing.Point(136, 62);
            this.comboMusteriSehir.Name = "comboMusteriSehir";
            this.comboMusteriSehir.Size = new System.Drawing.Size(145, 21);
            this.comboMusteriSehir.TabIndex = 5;
            this.comboMusteriSehir.SelectedIndexChanged += new System.EventHandler(this.comboMusteriSehir_SelectedIndexChanged);
            // 
            // comboMusteriIlce
            // 
            this.comboMusteriIlce.FormattingEnabled = true;
            this.comboMusteriIlce.Location = new System.Drawing.Point(136, 97);
            this.comboMusteriIlce.Name = "comboMusteriIlce";
            this.comboMusteriIlce.Size = new System.Drawing.Size(145, 21);
            this.comboMusteriIlce.TabIndex = 5;
            // 
            // txtMusteriAdresi
            // 
            this.txtMusteriAdresi.Location = new System.Drawing.Point(416, 18);
            this.txtMusteriAdresi.Multiline = true;
            this.txtMusteriAdresi.Name = "txtMusteriAdresi";
            this.txtMusteriAdresi.Size = new System.Drawing.Size(231, 65);
            this.txtMusteriAdresi.TabIndex = 6;
            // 
            // FormMusteri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 322);
            this.Controls.Add(this.txtMusteriAdresi);
            this.Controls.Add(this.comboMusteriIlce);
            this.Controls.Add(this.comboMusteriSehir);
            this.Controls.Add(this.txtMusteriUnvani);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvMusteriler);
            this.Name = "FormMusteri";
            this.Text = "FormMusteri";
            this.Load += new System.EventHandler(this.FormMusteri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMusteriler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMusteriler;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.TextBox txtMusteriUnvani;
        private System.Windows.Forms.ComboBox comboMusteriSehir;
        private System.Windows.Forms.ComboBox comboMusteriIlce;
        private System.Windows.Forms.TextBox txtMusteriAdresi;
    }
}