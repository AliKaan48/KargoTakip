using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace KargoTakip
{
    public partial class Sikayet : Form//Burada şikayet işlemleri yapmak için ve burada kişinin KullaniciOturumu nda aldığımız telefonNumarasi ve Sifre bilgilerini kullanıyoruz
    {
        SqlConnection baglanti = new SqlConnection(@"Data Source = Ali\SQLEXPRESS ; Initial Catalog = KargoTakipSistemi ; Integrated Security = True");   
        public Sikayet()
        {
            InitializeComponent();
        }

        private void btnGonder_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(rtbSikayet.Text))//Şikayet alanının boş olup olmadığını kontrol etmek için
            {
                MessageBox.Show("Lütfen şikayetinizi yazınız.","Uyarı",MessageBoxButtons.OK,MessageBoxIcon.Warning);//Şikayet alanı boşsa ve işlem yapılamk isteniyorsa bize mesaj göndermesi için
                return;
            }
            try//Hata olduğunuda hatayı yakalayıp catch e göndermesi için
            {
                baglanti.Open();//Veri tabanının bağlantısını açıyrouz
                SqlCommand komut = new SqlCommand("INSERT INTO Sikayetler(Sikayet,Tarih,TelefonNumarasi,Sifre) VALUES (@p1,@p2,@p3,@p4)", baglanti);
                komut.Parameters.AddWithValue("@p1",rtbSikayet.Text);
                komut.Parameters.AddWithValue("@p2",DateTime.Now);//Anlık tarih ve saat almak için
                komut.Parameters.AddWithValue("@p3",KullaniciOturumu.TelefonNumarasi);// KullaniciOturumu sınıfından gelen, o an giriş yapmış olan kullanıcının bilgilerini eklemek için
                komut.Parameters.AddWithValue("@p4",KullaniciOturumu.Sifre);
                komut.ExecuteNonQuery();//Veritabanı üzerindeki değişiklikleri kaydetmek için
                MessageBox.Show("Şikayetiniz kaydedilmiştir,en yakın zamanda geri dönüş sağlanacktır.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                rtbSikayet.Clear();
            }catch(Exception ex)//Hata olduğunda belirtmesi için
            {
                MessageBox.Show("Bir hata oluştu:"+ex.Message);
            }
            finally
            {
                baglanti.Close();//Bağlantıyı kapatıyoruz
            }
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            KargoBilgi geri = new KargoBilgi();
            geri.Show();
            this.Hide();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

