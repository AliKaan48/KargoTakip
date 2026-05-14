using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;//Sql kütüphanesini ekledik
namespace KargoTakip
{
    public partial class Giris : Form//Burada uygulamaya giriş yapmak için kullanıcı şifresi ve telefon numarası ile giriş yaptıımız yer
    {
        SqlConnection baglanti = new SqlConnection(@"Data Source= Ali\SQLEXPRESS;Initial Catalog = KargoTakipSistemi;Integrated Security = True;"); //Sql ile bağlantıyı sağlıyoruz sql adresi,veri tabanı adı,bağlantı güvenilirliği
        public Giris()
        {
            InitializeComponent();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("SELECT COUNT(*) FROM Kullanici Where Sifre = @p1 AND TelefonNumarasi = @p2", baglanti);//Kullanıcı tablosundan şifre ve telefon numarasına göre kullanıcıyı seçiyor
                komut.Parameters.AddWithValue("@p1", txtSifre.Text);// SQL sorgusundaki @p1 parametresine, kullanıcının TextBox'a yazdığı şifreyi güvenli bir şekilde atamak için
                                                                    // Bu yöntem SQL Injection saldırılarını engellemek için kullanılır ve bu şekilde güvenliği arttırdık
                komut.Parameters.AddWithValue("@p2",txtTelefonNumarasi.Text);
                int sonuc = (int)komut.ExecuteScalar();// ExecuteScalar: Sorguyu çalıştırır ve veritabanından dönen ilk satırın ilk sütununu (örneğin COUNT değeri) getirmek için kullandım ve burada dönen bu ifadeyi int değerine çevirir
                if (sonuc > 0)// Eğer dönen sonuç 0'dan büyükse yani bu şifre ve telefonla eşleşen bir kayıt varsa giriş işlemini başlatıyor ve uygulamayı giriş yapmış oluyoruz
                {
                    MessageBox.Show("Giriş Başarılı!");
                    KullaniciOturumu.TelefonNumarasi = txtTelefonNumarasi.Text;// Kullanıcı bilgilerini "KullaniciOturumu" isimli static bir sınıfta saklamak ve başka bir yerde kullanmak için
                    KullaniciOturumu.Sifre = txtSifre.Text;
                    KargoBilgi giris = new KargoBilgi();//Başka bir forma girmek için o form ismiyle nesne oluşturduk
                    giris.Show();//Oluşturulan formu ekranda gösterir
                    this.Hide();//Mevcut olan giriş formunu gizler
                }
                else
                {
                    MessageBox.Show("Hatalı şifre veya telefon numarası tekrar deneyiniz.");//Şifre hatası olması durumunda bize mesaj iletmesi için
                }
            }catch(Exception ex)
            {
                MessageBox.Show("Hata:"+ex.Message);//İstenmeyen bir hata durumunda bize uyarıyı ve hatanın sebebini vermesi için
            }
            finally
            {
                baglanti.Close();
            }
        }

        private void btnKayitOl_Click(object sender, EventArgs e)
        {
            YeniKullanici giris = new YeniKullanici();//Yeni kullanıcı eklemek için bu forma giriş yapıyoruz
            giris.Show();
            this.Hide();
        }
    }
}
