using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KargoTakip
{
    public partial class KargoBilgi : Form//Burada uygulamanın ana sayfası buradan istediğimiz işleme gitmek için kullandık
    {
        public KargoBilgi()
        {
            InitializeComponent();
        }

        private void btnSehirlerArasiClick(object sender, EventArgs e)//Şehirler arası işlemler için bu forma gidiyoruz
        {
            SehirlerArasiBilgi giris = new SehirlerArasiBilgi();
            giris.Show();
            this.Hide();
        }

        private void btnSehirici_Click(object sender, EventArgs e)//Şehiriçi işlemler için bu forma gidiyoruz
        {
            SehiriciBilgi giris = new SehiriciBilgi();
            giris.Show();
            this.Hide();
        }

        private void btnSikayet_Click(object sender, EventArgs e)//Şikayet işlemleri için bu forma gidiyoruz
        {
            Sikayet giris = new Sikayet();
            giris.Show();
            this.Hide();
        }

        private void btnGeri_Click(object sender, EventArgs e)//Şifre ve telefon numarası ile giriş yaptığımız giriş formuna gönderiyor
        {
            Giris geri = new Giris();
            geri.Show();
            this.Hide();
        }

        private void btnCikis_Click(object sender, EventArgs e)//Uygulamayı kapatmak için bir buton yaptık
        {
            Application.Exit();
        }
    }
}
