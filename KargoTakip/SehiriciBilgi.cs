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
using System.Diagnostics.Eventing.Reader;
namespace KargoTakip
{
    public partial class SehiriciBilgi : Form//Burada şehiriçi kargo işlemleri için bilgi almak için oluşturduk
    {
        SqlConnection baglanti = new SqlConnection(@"Data Source = Ali\SQLEXPRESS; Initial Catalog = KargoTakipSistemi ; Integrated Security = True");
        public SehiriciBilgi()
        {
            InitializeComponent();
        }

        private void btnKargoBilgi_Click(object sender, EventArgs e)
        {
            // SqlDataAdapter, veritabanı ile DataTable arasında bir köprü kurmamızı sağlar
            // Sorgu içerisinde 'CASE WHEN' yapısı kullandık ve  kargonun durumuna göre (İptal mi, Teslim mi?)anlık metinsel sonuçlar üretebilmek için kullandık
            SqlDataAdapter da = new SqlDataAdapter("SELECT KargoNumarasi, KargoTipi, Guzergah, Arac,VarisZamani,Ucret,Agirlik, CASE  WHEN Durum = 'İptal Edildi' THEN 'İptal Edildi'  WHEN DATEDIFF(hour, GETDATE(), VarisZamani) <= 0 THEN 'Kargo Teslim Edildi' ELSE CAST(DATEDIFF(hour, GETDATE(), VarisZamani) AS VARCHAR) + ' Saat Kaldı' END AS KalanSaat FROM SehiriciKargoBilgi WHERE KargoNumarasi=@p1",baglanti);
            da.SelectCommand.Parameters.AddWithValue("@p1",txtKargoNumarasi.Text);
            DataTable dt = new DataTable();
            da.Fill(dt);// Verileri SQL den çekip bu tabloya doldurmak için
            dataGridView1.DataSource = dt;// Verileri form üzerindeki DataGridView kontrolüne bağlayarak ekranda görünmesini sağlar böylece kullanıcı girile kargo numarasına göre kargosu hakkında bilgi sahibi olabilecek
            UyeleriRenklendir();//Burada oluşan duruma göre kargo satırını renklendiriyoruz
        }
        private void UyeleriRenklendir()
        {
            foreach (DataGridViewRow satir in dataGridView1.Rows)// DataGridView üzerindeki her bir satırı tek tek kontrol etmek için döngü başlatırız
            {
                if (satir.IsNewRow) continue;// Eğer satır, kullanıcının veri girişi yapması için ayrılan en alttaki boş satır ise işlem yapmaması için burayı ekledik

                var hucreDegeri = satir.Cells["KalanSaat"].Value;// "KalanSaat" sütunundaki hücre değerini alır
                if (hucreDegeri == null || hucreDegeri == DBNull.Value) continue;// Hücre boşsa veya veritabanından 'null' geldiyse sonraki satıra geçer

                string deger = hucreDegeri.ToString();

                
                if (deger == "İptal Edildi")//Eğer kargo iptal edildiyse satırı gri yapar
                {
                    satir.DefaultCellStyle.BackColor = Color.Gray;
                    satir.DefaultCellStyle.ForeColor = Color.White;//Yazıyı beyaz yapar
                }
            
                else if (deger == "Kargo Teslim Edildi")//Kargo teslim edildiyse kırmızı yapar
                {
                    satir.DefaultCellStyle.BackColor = Color.Red;
                    satir.DefaultCellStyle.ForeColor = Color.White;//Yazıyı beyaz yapar
                }

                else//Kargonun ulaşması için gereken zaman hesabını yapıyor
                {
                    try
                    {
                     
                        int kalanSaat = Convert.ToInt32(deger.Split(' ')[0]);// "11 Saat Kaldı" şeklindeki metni boşluktan ayırıp baştaki sayısal değeri alır.

                        if (kalanSaat <= 12)//kargo teslimine 12 saat veya daha az bir süre varsa 
                        {
                            satir.DefaultCellStyle.BackColor = Color.Yellow;//Satırı yeşil
                            satir.DefaultCellStyle.ForeColor = Color.Black;//Yazıyı siyah yapar
                        }
                        else//12 saaten daha fazla zaman varsa 
                        {
                            satir.DefaultCellStyle.BackColor = Color.LightGreen;//Satırı açıkyeşil
                            satir.DefaultCellStyle.ForeColor = Color.Black;//Yazıyı siyah yapar
                        }
                    }
                    catch(Exception ex) 
                    {
                        MessageBox.Show("Hata:"+ex.Message);
                    }
                }
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

        private void btnDigerİslemler_Click(object sender, EventArgs e)//Diğer işlemler formuna giriş yapmak için
        {
            Sehiriciİslemler giris = new Sehiriciİslemler();
            giris.Show();
            this.Hide();
        }
    }
}
