using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
namespace KargoTakip
{
    public partial class YeniKullanici : Form//Burası yeni kullanıcı kaydı yaptığımız yer burada kullanıcının adı,soyadı,telefon numarası ve bir şifre belirlemesini istiyoruz
    {
        SqlConnection baglanti = new SqlConnection(@"Data Source= Ali\SQLEXPRESS;Initial Catalog=KargoTakipSistemi;Integrated Security = True");
        public YeniKullanici()
        {
            InitializeComponent();
        }

        private void btnKayitOl_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("INSERT INTO Kullanici(Ad,Soyad,TelefonNumarasi,Sifre) VALUES (@p1,@p2,@p3,@p4)", baglanti);// SQL komut nesnesi oluşturulur. 'INSERT INTO' komutu ile 'Kullanici' tablosundaki belirtilen sütunlara 
                                                                                                                                              // dışarıdan gelecek (@p1, @p2...) değerlerin ekleneceği bildirilir
                komut.Parameters.AddWithValue("@p1",txtAd.Text);// 'AddWithValue' metodu, formdaki TextBox verilerini SQL parametrelerine bağlar
                                                                // Bu yöntem, doğrudan string birleştirmeye göre "SQL Injection" saldırılarını önlediği için çok daha güvenlirdir
                komut.Parameters.AddWithValue("@p2", txtSoyad.Text);
                komut.Parameters.AddWithValue("@p3", txtTelefonNumarasi.Text);
                komut.Parameters.AddWithValue("@p4", txtSifre.Text);
                komut.ExecuteNonQuery();// ExecuteNonQuery: Geriye bir tablo döndürmeyen (Ekleme, Silme, Güncelleme) komutları çalıştırmak için 
                                        // Bu satır çalıştığı anda veriler SQL tablosuna fiziksel olarak kaydedilir
                MessageBox.Show("Kayıdınız başarıyla oluşturuldu.");//Kaydın başarıyla oluştuğunu bize bildiriyor
            }catch (Exception ex)
            {
                MessageBox.Show("Hata:"+ex.Message);
            }
            finally
            {
                baglanti.Close();
            }
        }

        private void btnGeri_Click(object sender, EventArgs e)//Burada geldiğimiz forma geri dönmek için kullandık
        {
            Giris giris = new Giris();
            giris.Show();
            this.Hide();
        }
    }
}
