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
    public partial class SehirlerArasiİslemler : Form//Burada şehirler arası kargo oluşturma ve kargo iptal etmek için oluşturduk
    {
        SqlConnection baglanti = new SqlConnection(@"Data Source = Ali\SQLEXPRESS; Initial Catalog = KargoTakipSistemi ; Integrated Security = True");
        DateTime hesaplananTeslimZamani;
        decimal hesaplananFiyat;
      
        public SehirlerArasiİslemler()
        {
            InitializeComponent();
        }
        private void SehirlerArasiİslemler_Load(object sender, EventArgs e)
        {
            cmbAracTipi.Items.AddRange(new string[] { "Kamyonet", "Tren", "Uçak", "Tır" });// Araç tipi ve hız seçeneklerini ComboBox listelerine eklemek için 
            cmbGonderiHizi.Items.AddRange(new string[] { "Standart", "Express" });
            cmbAracTipi.SelectedIndex = 0;// Uygulama açıldığında listenin ilk elemanlarını varsayılan olarak seçemek için
            cmbGonderiHizi.SelectedIndex = 0;
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            decimal agirlik = nudAgirlik.Value;
            string arac = cmbAracTipi.Text;
            // Kamyonet için 100 kg, Tır için 250 kg, Tren için 500 kg üst sınırı kontrol eediyoruz ve hatalı bir seçimde bize bildiriyor
            if (arac == "Kamyonet" && agirlik > 100)
            {
                MessageBox.Show("HATA: Kamyonet ile 100 kg üzeri yük taşınamaz! Lütfen Tren,Uçak veya Tır seçiniz.", "Araç Uyarısı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (arac == "Tır" && agirlik > 250)
            {
                MessageBox.Show("HATA: Tır ile 250 kg üzeri yük taşınamaz! Lütfen Uçak veya Tren seçiniz.", "Araç Uyarısı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (arac == "Tren" && agirlik > 500)
            {
                MessageBox.Show("HATA: Tren ile 500 kg üzeri yük taşınamaz! Lütfen  Uçak seçiniz.", "Araç Uyarısı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            //Teslimat zamanını hesaplamak için
            hesaplananTeslimZamani = DateTime.Now;// Hesaplamayı şu anki zamandan başlatır.

            if (agirlik <= 100)
            {
                hesaplananTeslimZamani = hesaplananTeslimZamani.AddDays(7);
            }
            else if (agirlik <= 250)
            {
                hesaplananTeslimZamani = hesaplananTeslimZamani.AddMonths(1);
            }
            else if (agirlik <= 500)
            {
                hesaplananTeslimZamani = hesaplananTeslimZamani.AddMonths(6);
            }
            else
            {
                hesaplananTeslimZamani = hesaplananTeslimZamani.AddYears(1);
            }
            //Ücret hesaplama işlemleri için
            hesaplananFiyat = agirlik * 100;//ağırlık başına 100 birim ile çarpar
            if (cmbGonderiHizi.Text == "Express")
            {
                hesaplananFiyat *= 1.5m;//Express seçeneği seçilirse %50 fazla miktarda ücret alınır
                //Şimdiki zaman ike hesaplanan zaman arasındaki farkı bul ve 0.75 ile çarp
                TimeSpan fark = hesaplananTeslimZamani - DateTime.Now;
                hesaplananTeslimZamani = DateTime.Now + TimeSpan.FromTicks((long)(fark.Ticks * 0.75));
            }
            if (chkKirilabilir.Checked)
            {
                hesaplananFiyat += 7500;//Kırılabilir eşyalar da 7500 birimlik ekleme yaptık
            }
            lblFiyat.Text = $"Toplam Tutar:{hesaplananFiyat.ToString("C2")}";
            lblTeslimTarihi.Text = $"Tahmini Teslimat:{hesaplananTeslimZamani.ToString("dd.MM.yyyy HH:mm")} ";
        }
        private void btnKargoOlustur_Click(object sender, EventArgs e)
        {
            if (hesaplananFiyat == 0)// Hesapla butonuna basılmadan kayıt yapılmasını engellemek için
            {
                MessageBox.Show("Lütfen önce bilgileri doldurunuz 'Hesapla' butonuna basınız.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            string guzergah = $"{txtGönderici.Text}->{txtAlici.Text}";
            string kargoNumarasi = new Random().Next(1, 99999).ToString();
            try
            {
                baglanti.Open();//Veri tabanı bağlantısını açıyoruz
                // SQL Parametreli INSERT Sorgusu: Verileri güvenli bir şekilde tabloya eklemek için
                SqlCommand komut = new SqlCommand("INSERT INTO SehirlerArasiKargoBilgi (KargoNumarasi, KargoTipi, Guzergah, Arac, VarisZamani, Ucret, Durum,Agirlik) VALUES (@p1, @p2, @p3, @p4, @p5, @p6, 'Aktif',@p7)", baglanti);
                komut.Parameters.AddWithValue("@p1", kargoNumarasi);
                komut.Parameters.AddWithValue("@p2", cmbGonderiHizi.Text);
                komut.Parameters.AddWithValue("@p3", guzergah);
                komut.Parameters.AddWithValue("@p4", cmbAracTipi.Text);
                komut.Parameters.AddWithValue("@p5", hesaplananTeslimZamani);
                komut.Parameters.AddWithValue("@p6", hesaplananFiyat);
                komut.Parameters.AddWithValue("@p7", nudAgirlik.Value);
                komut.ExecuteNonQuery();//Veritabanı üzerindeki değişiklikleri kaydetmek için
                MessageBox.Show($"Kargo başarıyla oluşturuldu!\nKargo Numaranız: {kargoNumarasi}", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);//Kullanıcıya kargonun başarıyla oluşturulduğunu söyler ve kullanıcıya kargo nummarasını bildirir
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally//Finally bloğu her durumda bağlantıyı kapatır
            {
                baglanti.Close();//Bağlantıyı kapatıyoruz
            }
        }

        private void btnIptal_Click(object sender, EventArgs e)//Kargo iptal işlemleri için oluşturduk
        {
            if (string.IsNullOrWhiteSpace(txtIptalKargoNumarasi.Text))//Kargo numarası boş olduğu durumlarda işlem yapmak istendiğinde engellemek ve hata bildirmek için
            {
                MessageBox.Show("Kargonuzun iptal edilmesi için lütfen kargo numarasını giriniz.", "Eksik Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                baglanti.Open();//veri tabanı bağlantısını açıyrouz
                SqlCommand komut = new SqlCommand("UPDATE SehirlerArasiKargoBilgi SET Durum = 'İptal Edildi' WHERE KargoNumarasi = @p1", baglanti);// UPDATE sorgusu ile kargonun durumunu 'Aktif'ten 'İptal Edildi'ye çevirmek için
                komut.Parameters.AddWithValue("@p1", txtIptalKargoNumarasi.Text);
                int etkilenenSatir = komut.ExecuteNonQuery();
                if (etkilenenSatir > 0)// Eğer veritabanında bu numara varsa etkilenenSatir 0'dan büyük olması için
                {
                    MessageBox.Show("Kargo başarıyla iptal edildi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Bu numaraya ait aktif bir kargo bulunamadı.", "Bulunamadı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                baglanti.Close();
            }
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            SehirlerArasiBilgi geri = new SehirlerArasiBilgi();
            geri.Show();
            this.Hide();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void chkKirilabilir_CheckedChanged(object sender, EventArgs e)
        {

            hesaplananFiyat = 0;
            lblFiyat.Text = "Toplam Tutar: 0 TL";
        }

        private void nudAgirlik_ValueChanged(object sender, EventArgs e)
        {

            hesaplananFiyat = 0;
            lblFiyat.Text = "Toplam Tutar: 0 TL";
        }

        private void cmbGonderiHizi_SelectedIndexChanged(object sender, EventArgs e)
        {

            hesaplananFiyat = 0;
            lblFiyat.Text = "Toplam Tutar: 0 TL";
        }
    }
}
