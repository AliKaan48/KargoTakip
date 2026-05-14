namespace KargoTakip
{
    partial class SehirlerArasiBilgi
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnKargoBilgi = new System.Windows.Forms.Button();
            this.txtKargoNumarasi = new System.Windows.Forms.TextBox();
            this.btnDigerİslemler = new System.Windows.Forms.Button();
            this.btnGeri = new System.Windows.Forms.Button();
            this.btnCikis = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kargo Numarası:";
            // 
            // btnKargoBilgi
            // 
            this.btnKargoBilgi.Location = new System.Drawing.Point(143, 107);
            this.btnKargoBilgi.Name = "btnKargoBilgi";
            this.btnKargoBilgi.Size = new System.Drawing.Size(134, 50);
            this.btnKargoBilgi.TabIndex = 1;
            this.btnKargoBilgi.Text = "Kargo Bilgisi";
            this.btnKargoBilgi.UseVisualStyleBackColor = true;
            this.btnKargoBilgi.Click += new System.EventHandler(this.btnKargoBilgi_Click);
            // 
            // txtKargoNumarasi
            // 
            this.txtKargoNumarasi.Location = new System.Drawing.Point(143, 58);
            this.txtKargoNumarasi.Name = "txtKargoNumarasi";
            this.txtKargoNumarasi.Size = new System.Drawing.Size(134, 22);
            this.txtKargoNumarasi.TabIndex = 2;
            // 
            // btnDigerİslemler
            // 
            this.btnDigerİslemler.Location = new System.Drawing.Point(143, 192);
            this.btnDigerİslemler.Name = "btnDigerİslemler";
            this.btnDigerİslemler.Size = new System.Drawing.Size(134, 50);
            this.btnDigerİslemler.TabIndex = 3;
            this.btnDigerİslemler.Text = "Diğer İşlemler";
            this.btnDigerİslemler.UseVisualStyleBackColor = true;
            this.btnDigerİslemler.Click += new System.EventHandler(this.btnDigerİslemler_Click);
            // 
            // btnGeri
            // 
            this.btnGeri.Location = new System.Drawing.Point(1051, 41);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(54, 23);
            this.btnGeri.TabIndex = 4;
            this.btnGeri.Text = "Geri";
            this.btnGeri.UseVisualStyleBackColor = true;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // btnCikis
            // 
            this.btnCikis.Location = new System.Drawing.Point(1111, 41);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(54, 23);
            this.btnCikis.TabIndex = 5;
            this.btnCikis.Text = "Çıkış";
            this.btnCikis.UseVisualStyleBackColor = true;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(283, 70);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(882, 172);
            this.dataGridView1.TabIndex = 6;
            // 
            // SehirlerArasiBilgi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.YellowGreen;
            this.ClientSize = new System.Drawing.Size(1213, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.btnGeri);
            this.Controls.Add(this.btnDigerİslemler);
            this.Controls.Add(this.txtKargoNumarasi);
            this.Controls.Add(this.btnKargoBilgi);
            this.Controls.Add(this.label1);
            this.Name = "SehirlerArasiBilgi";
            this.Text = "SehirlerArasi";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnKargoBilgi;
        private System.Windows.Forms.TextBox txtKargoNumarasi;
        private System.Windows.Forms.Button btnDigerİslemler;
        private System.Windows.Forms.Button btnGeri;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}