namespace KargoTakip
{
    partial class KargoBilgi
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
            this.btnSehirlerArasi = new System.Windows.Forms.Button();
            this.btnSehirici = new System.Windows.Forms.Button();
            this.btnSikayet = new System.Windows.Forms.Button();
            this.btnGeri = new System.Windows.Forms.Button();
            this.btnCikis = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSehirlerArasi
            // 
            this.btnSehirlerArasi.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnSehirlerArasi.Location = new System.Drawing.Point(28, 35);
            this.btnSehirlerArasi.Name = "btnSehirlerArasi";
            this.btnSehirlerArasi.Size = new System.Drawing.Size(112, 44);
            this.btnSehirlerArasi.TabIndex = 0;
            this.btnSehirlerArasi.Text = "Şehirler Arası İşlemler";
            this.btnSehirlerArasi.UseVisualStyleBackColor = true;
            this.btnSehirlerArasi.Click += new System.EventHandler(this.btnSehirlerArasiClick);
            // 
            // btnSehirici
            // 
            this.btnSehirici.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnSehirici.Location = new System.Drawing.Point(28, 158);
            this.btnSehirici.Name = "btnSehirici";
            this.btnSehirici.Size = new System.Drawing.Size(112, 44);
            this.btnSehirici.TabIndex = 1;
            this.btnSehirici.Text = "Şehiriçi İşlemler";
            this.btnSehirici.UseVisualStyleBackColor = true;
            this.btnSehirici.Click += new System.EventHandler(this.btnSehirici_Click);
            // 
            // btnSikayet
            // 
            this.btnSikayet.Location = new System.Drawing.Point(28, 268);
            this.btnSikayet.Name = "btnSikayet";
            this.btnSikayet.Size = new System.Drawing.Size(112, 44);
            this.btnSikayet.TabIndex = 2;
            this.btnSikayet.Text = "Şikayet";
            this.btnSikayet.UseVisualStyleBackColor = true;
            this.btnSikayet.Click += new System.EventHandler(this.btnSikayet_Click);
            // 
            // btnGeri
            // 
            this.btnGeri.Location = new System.Drawing.Point(336, 12);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(56, 23);
            this.btnGeri.TabIndex = 3;
            this.btnGeri.Text = "Geri";
            this.btnGeri.UseVisualStyleBackColor = true;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // btnCikis
            // 
            this.btnCikis.Location = new System.Drawing.Point(398, 12);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(56, 23);
            this.btnCikis.TabIndex = 4;
            this.btnCikis.Text = "Çıkış";
            this.btnCikis.UseVisualStyleBackColor = true;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // KargoBilgi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(504, 329);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.btnGeri);
            this.Controls.Add(this.btnSikayet);
            this.Controls.Add(this.btnSehirici);
            this.Controls.Add(this.btnSehirlerArasi);
            this.Name = "KargoBilgi";
            this.Text = "KargoBilgi";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSehirlerArasi;
        private System.Windows.Forms.Button btnSehirici;
        private System.Windows.Forms.Button btnSikayet;
        private System.Windows.Forms.Button btnGeri;
        private System.Windows.Forms.Button btnCikis;
    }
}