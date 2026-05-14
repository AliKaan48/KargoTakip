namespace KargoTakip
{
    partial class SehirlerArasiİslemler
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
            this.btnCikis = new System.Windows.Forms.Button();
            this.btnGeri = new System.Windows.Forms.Button();
            this.chkKirilabilir = new System.Windows.Forms.CheckBox();
            this.cmbGonderiHizi = new System.Windows.Forms.ComboBox();
            this.cmbAracTipi = new System.Windows.Forms.ComboBox();
            this.nudAgirlik = new System.Windows.Forms.NumericUpDown();
            this.btnKargoOlustur = new System.Windows.Forms.Button();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.lblTeslimTarihi = new System.Windows.Forms.Label();
            this.lblFiyat = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnIptal = new System.Windows.Forms.Button();
            this.txtIptalKargoNumarasi = new System.Windows.Forms.TextBox();
            this.txtGönderici = new System.Windows.Forms.TextBox();
            this.txtAlici = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudAgirlik)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCikis
            // 
            this.btnCikis.Location = new System.Drawing.Point(619, 21);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(51, 23);
            this.btnCikis.TabIndex = 33;
            this.btnCikis.Text = "Çıkış";
            this.btnCikis.UseVisualStyleBackColor = true;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // btnGeri
            // 
            this.btnGeri.Location = new System.Drawing.Point(562, 21);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(51, 23);
            this.btnGeri.TabIndex = 32;
            this.btnGeri.Text = "Geri";
            this.btnGeri.UseVisualStyleBackColor = true;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // chkKirilabilir
            // 
            this.chkKirilabilir.AutoSize = true;
            this.chkKirilabilir.Location = new System.Drawing.Point(396, 163);
            this.chkKirilabilir.Name = "chkKirilabilir";
            this.chkKirilabilir.Size = new System.Drawing.Size(79, 20);
            this.chkKirilabilir.TabIndex = 31;
            this.chkKirilabilir.Text = "Kırılabilir";
            this.chkKirilabilir.UseVisualStyleBackColor = true;
            this.chkKirilabilir.CheckedChanged += new System.EventHandler(this.chkKirilabilir_CheckedChanged);
            // 
            // cmbGonderiHizi
            // 
            this.cmbGonderiHizi.FormattingEnabled = true;
            this.cmbGonderiHizi.Location = new System.Drawing.Point(22, 159);
            this.cmbGonderiHizi.Name = "cmbGonderiHizi";
            this.cmbGonderiHizi.Size = new System.Drawing.Size(162, 24);
            this.cmbGonderiHizi.TabIndex = 30;
            this.cmbGonderiHizi.SelectedIndexChanged += new System.EventHandler(this.cmbGonderiHizi_SelectedIndexChanged);
            // 
            // cmbAracTipi
            // 
            this.cmbAracTipi.FormattingEnabled = true;
            this.cmbAracTipi.Location = new System.Drawing.Point(212, 159);
            this.cmbAracTipi.Name = "cmbAracTipi";
            this.cmbAracTipi.Size = new System.Drawing.Size(162, 24);
            this.cmbAracTipi.TabIndex = 29;
            // 
            // nudAgirlik
            // 
            this.nudAgirlik.Location = new System.Drawing.Point(22, 212);
            this.nudAgirlik.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nudAgirlik.Name = "nudAgirlik";
            this.nudAgirlik.Size = new System.Drawing.Size(120, 22);
            this.nudAgirlik.TabIndex = 28;
            this.nudAgirlik.ValueChanged += new System.EventHandler(this.nudAgirlik_ValueChanged);
            // 
            // btnKargoOlustur
            // 
            this.btnKargoOlustur.Location = new System.Drawing.Point(35, 336);
            this.btnKargoOlustur.Name = "btnKargoOlustur";
            this.btnKargoOlustur.Size = new System.Drawing.Size(125, 45);
            this.btnKargoOlustur.TabIndex = 27;
            this.btnKargoOlustur.Text = "Kargo Oluştur";
            this.btnKargoOlustur.UseVisualStyleBackColor = true;
            this.btnKargoOlustur.Click += new System.EventHandler(this.btnKargoOlustur_Click);
            // 
            // btnHesapla
            // 
            this.btnHesapla.Location = new System.Drawing.Point(22, 265);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(84, 33);
            this.btnHesapla.TabIndex = 26;
            this.btnHesapla.Text = "Hesapla";
            this.btnHesapla.UseVisualStyleBackColor = true;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // lblTeslimTarihi
            // 
            this.lblTeslimTarihi.AutoSize = true;
            this.lblTeslimTarihi.Location = new System.Drawing.Point(129, 255);
            this.lblTeslimTarihi.Name = "lblTeslimTarihi";
            this.lblTeslimTarihi.Size = new System.Drawing.Size(0, 16);
            this.lblTeslimTarihi.TabIndex = 25;
            // 
            // lblFiyat
            // 
            this.lblFiyat.AutoSize = true;
            this.lblFiyat.Location = new System.Drawing.Point(129, 295);
            this.lblFiyat.Name = "lblFiyat";
            this.lblFiyat.Size = new System.Drawing.Size(0, 16);
            this.lblFiyat.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 16);
            this.label3.TabIndex = 23;
            this.label3.Text = "Gönderici Adresi:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 16);
            this.label2.TabIndex = 22;
            this.label2.Text = "Alıcı Adresi:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(432, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 16);
            this.label1.TabIndex = 21;
            this.label1.Text = "Kargo Numarası:";
            // 
            // btnIptal
            // 
            this.btnIptal.Location = new System.Drawing.Point(545, 138);
            this.btnIptal.Name = "btnIptal";
            this.btnIptal.Size = new System.Drawing.Size(125, 45);
            this.btnIptal.TabIndex = 20;
            this.btnIptal.Text = "İptal";
            this.btnIptal.UseVisualStyleBackColor = true;
            this.btnIptal.Click += new System.EventHandler(this.btnIptal_Click);
            // 
            // txtIptalKargoNumarasi
            // 
            this.txtIptalKargoNumarasi.Location = new System.Drawing.Point(545, 73);
            this.txtIptalKargoNumarasi.Name = "txtIptalKargoNumarasi";
            this.txtIptalKargoNumarasi.Size = new System.Drawing.Size(125, 22);
            this.txtIptalKargoNumarasi.TabIndex = 19;
            // 
            // txtGönderici
            // 
            this.txtGönderici.Location = new System.Drawing.Point(135, 106);
            this.txtGönderici.Name = "txtGönderici";
            this.txtGönderici.Size = new System.Drawing.Size(219, 22);
            this.txtGönderici.TabIndex = 18;
            // 
            // txtAlici
            // 
            this.txtAlici.Location = new System.Drawing.Point(135, 51);
            this.txtAlici.Name = "txtAlici";
            this.txtAlici.Size = new System.Drawing.Size(219, 22);
            this.txtAlici.TabIndex = 17;
            // 
            // SehirlerArasiİslemler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(841, 484);
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
            this.Name = "SehirlerArasiİslemler";
            this.Text = "SehirlerArasi";
            this.Load += new System.EventHandler(this.SehirlerArasiİslemler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudAgirlik)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.Button btnGeri;
        private System.Windows.Forms.CheckBox chkKirilabilir;
        private System.Windows.Forms.ComboBox cmbGonderiHizi;
        private System.Windows.Forms.ComboBox cmbAracTipi;
        private System.Windows.Forms.NumericUpDown nudAgirlik;
        private System.Windows.Forms.Button btnKargoOlustur;
        private System.Windows.Forms.Button btnHesapla;
        private System.Windows.Forms.Label lblTeslimTarihi;
        private System.Windows.Forms.Label lblFiyat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnIptal;
        private System.Windows.Forms.TextBox txtIptalKargoNumarasi;
        private System.Windows.Forms.TextBox txtGönderici;
        private System.Windows.Forms.TextBox txtAlici;
    }
}