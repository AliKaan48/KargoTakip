namespace KargoTakip
{
    partial class Sehiriciİslemler
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
            this.txtAlici = new System.Windows.Forms.TextBox();
            this.txtGönderici = new System.Windows.Forms.TextBox();
            this.txtIptalKargoNumarasi = new System.Windows.Forms.TextBox();
            this.btnIptal = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblFiyat = new System.Windows.Forms.Label();
            this.lblTeslimTarihi = new System.Windows.Forms.Label();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.btnKargoOlustur = new System.Windows.Forms.Button();
            this.nudAgirlik = new System.Windows.Forms.NumericUpDown();
            this.cmbAracTipi = new System.Windows.Forms.ComboBox();
            this.cmbGonderiHizi = new System.Windows.Forms.ComboBox();
            this.chkKirilabilir = new System.Windows.Forms.CheckBox();
            this.btnGeri = new System.Windows.Forms.Button();
            this.btnCikis = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudAgirlik)).BeginInit();
            this.SuspendLayout();
            // 
            // txtAlici
            // 
            this.txtAlici.Location = new System.Drawing.Point(135, 51);
            this.txtAlici.Name = "txtAlici";
            this.txtAlici.Size = new System.Drawing.Size(219, 22);
            this.txtAlici.TabIndex = 0;
            // 
            // txtGönderici
            // 
            this.txtGönderici.Location = new System.Drawing.Point(135, 106);
            this.txtGönderici.Name = "txtGönderici";
            this.txtGönderici.Size = new System.Drawing.Size(219, 22);
            this.txtGönderici.TabIndex = 1;
            // 
            // txtIptalKargoNumarasi
            // 
            this.txtIptalKargoNumarasi.Location = new System.Drawing.Point(545, 73);
            this.txtIptalKargoNumarasi.Name = "txtIptalKargoNumarasi";
            this.txtIptalKargoNumarasi.Size = new System.Drawing.Size(125, 22);
            this.txtIptalKargoNumarasi.TabIndex = 2;
            // 
            // btnIptal
            // 
            this.btnIptal.Location = new System.Drawing.Point(545, 138);
            this.btnIptal.Name = "btnIptal";
            this.btnIptal.Size = new System.Drawing.Size(125, 45);
            this.btnIptal.TabIndex = 3;
            this.btnIptal.Text = "İptal";
            this.btnIptal.UseVisualStyleBackColor = true;
            this.btnIptal.Click += new System.EventHandler(this.btnIptal_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(432, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Kargo Numarası:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Alıcı Adresi:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Gönderici Adresi:";
            // 
            // lblFiyat
            // 
            this.lblFiyat.AutoSize = true;
            this.lblFiyat.Location = new System.Drawing.Point(129, 295);
            this.lblFiyat.Name = "lblFiyat";
            this.lblFiyat.Size = new System.Drawing.Size(0, 16);
            this.lblFiyat.TabIndex = 7;
            // 
            // lblTeslimTarihi
            // 
            this.lblTeslimTarihi.AutoSize = true;
            this.lblTeslimTarihi.Location = new System.Drawing.Point(129, 255);
            this.lblTeslimTarihi.Name = "lblTeslimTarihi";
            this.lblTeslimTarihi.Size = new System.Drawing.Size(0, 16);
            this.lblTeslimTarihi.TabIndex = 8;
            // 
            // btnHesapla
            // 
            this.btnHesapla.Location = new System.Drawing.Point(22, 265);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(84, 33);
            this.btnHesapla.TabIndex = 9;
            this.btnHesapla.Text = "Hesapla";
            this.btnHesapla.UseVisualStyleBackColor = true;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // btnKargoOlustur
            // 
            this.btnKargoOlustur.Location = new System.Drawing.Point(35, 336);
            this.btnKargoOlustur.Name = "btnKargoOlustur";
            this.btnKargoOlustur.Size = new System.Drawing.Size(125, 45);
            this.btnKargoOlustur.TabIndex = 10;
            this.btnKargoOlustur.Text = "Kargo Oluştur";
            this.btnKargoOlustur.UseVisualStyleBackColor = true;
            this.btnKargoOlustur.Click += new System.EventHandler(this.btnKargoOlustur_Click);
            // 
            // nudAgirlik
            // 
            this.nudAgirlik.Location = new System.Drawing.Point(22, 212);
            this.nudAgirlik.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudAgirlik.Name = "nudAgirlik";
            this.nudAgirlik.Size = new System.Drawing.Size(120, 22);
            this.nudAgirlik.TabIndex = 11;
            this.nudAgirlik.ValueChanged += new System.EventHandler(this.nudAgirlik_ValueChanged);
            // 
            // cmbAracTipi
            // 
            this.cmbAracTipi.FormattingEnabled = true;
            this.cmbAracTipi.Location = new System.Drawing.Point(212, 159);
            this.cmbAracTipi.Name = "cmbAracTipi";
            this.cmbAracTipi.Size = new System.Drawing.Size(162, 24);
            this.cmbAracTipi.TabIndex = 12;
           // this.cmbAracTipi.SelectedIndexChanged += new System.EventHandler(this.cmbAracTipi_SelectedIndexChanged);
            // 
            // cmbGonderiHizi
            // 
            this.cmbGonderiHizi.FormattingEnabled = true;
            this.cmbGonderiHizi.Location = new System.Drawing.Point(22, 159);
            this.cmbGonderiHizi.Name = "cmbGonderiHizi";
            this.cmbGonderiHizi.Size = new System.Drawing.Size(162, 24);
            this.cmbGonderiHizi.TabIndex = 13;
            this.cmbGonderiHizi.SelectedIndexChanged += new System.EventHandler(this.cmbGonderiHizi_SelectedIndexChanged);
            // 
            // chkKirilabilir
            // 
            this.chkKirilabilir.AutoSize = true;
            this.chkKirilabilir.Location = new System.Drawing.Point(396, 163);
            this.chkKirilabilir.Name = "chkKirilabilir";
            this.chkKirilabilir.Size = new System.Drawing.Size(79, 20);
            this.chkKirilabilir.TabIndex = 14;
            this.chkKirilabilir.Text = "Kırılabilir";
            this.chkKirilabilir.UseVisualStyleBackColor = true;
            this.chkKirilabilir.CheckedChanged += new System.EventHandler(this.chkKirilabilir_CheckedChanged);
            // 
            // btnGeri
            // 
            this.btnGeri.Location = new System.Drawing.Point(562, 21);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(51, 23);
            this.btnGeri.TabIndex = 15;
            this.btnGeri.Text = "Geri";
            this.btnGeri.UseVisualStyleBackColor = true;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // btnCikis
            // 
            this.btnCikis.Location = new System.Drawing.Point(619, 21);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(51, 23);
            this.btnCikis.TabIndex = 16;
            this.btnCikis.Text = "Çıkış";
            this.btnCikis.UseVisualStyleBackColor = true;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // Sehiriciİslemler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(786, 452);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.btnGeri);
            this.Controls.Add(this.chkKirilabilir);
            this.Controls.Add(this.cmbGonderiHizi);
            this.Controls.Add(this.cmbAracTipi);
            this.Controls.Add(this.nudAgirlik);
            this.Controls.Add(this.btnKargoOlustur);
            this.Controls.Add(this.btnHesapla);
            this.Controls.Add(this.lblTeslimTarihi);
            this.Controls.Add(this.lblFiyat);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnIptal);
            this.Controls.Add(this.txtIptalKargoNumarasi);
            this.Controls.Add(this.txtGönderici);
            this.Controls.Add(this.txtAlici);
            this.Name = "Sehiriciİslemler";
            this.Text = "Sehiriciİslemler";
            this.Load += new System.EventHandler(this.Sehiriciİslemler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudAgirlik)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAlici;
        private System.Windows.Forms.TextBox txtGönderici;
        private System.Windows.Forms.TextBox txtIptalKargoNumarasi;
        private System.Windows.Forms.Button btnIptal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblFiyat;
        private System.Windows.Forms.Label lblTeslimTarihi;
        private System.Windows.Forms.Button btnHesapla;
        private System.Windows.Forms.Button btnKargoOlustur;
        private System.Windows.Forms.NumericUpDown nudAgirlik;
        private System.Windows.Forms.ComboBox cmbAracTipi;
        private System.Windows.Forms.ComboBox cmbGonderiHizi;
        private System.Windows.Forms.CheckBox chkKirilabilir;
        private System.Windows.Forms.Button btnGeri;
        private System.Windows.Forms.Button btnCikis;
    }
}