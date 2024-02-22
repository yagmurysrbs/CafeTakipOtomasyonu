using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace _210757025_YagmurYasarbas
{

    public partial class Siparislerim : Form
    {
        SqlConnection baglanti = new SqlConnection(@"Data Source=YAGMUR;Initial Catalog=CAFE;Integrated Security=True");
        public string kullanıcıadı;
       
        public Siparislerim()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        { //kullanıcı ana sayfaya geri döner
            KullanıcıAnasayfaForm kullanıcıAnasayfa = new KullanıcıAnasayfaForm();
            kullanıcıAnasayfa.kullanıcıadı = kullanıcıadı;
            kullanıcıAnasayfa.Show();
            this.Hide();
        }
        
        private void button2_Click(object sender, EventArgs e)
        {    // Siparişleri görüntüle butonuna tıklandığında çağrılan metod

            baglanti.Open();
            // Siparişleri sorgulayan sorgu
            string query = @"SELECT kullanıcıadı, MasaNumarası,SiparisTarihi,
                  STUFF(( SELECT ', ' + ÜrünAdı FROM siparisler s2
                                            WHERE s1.kullanıcıadı = s2.kullanıcıadı
                                            AND s1.MasaNumarası = s2.MasaNumarası
                                            AND s1.SiparisTarihi = s2.SiparisTarihi
                                            AND s1.kullanıcıadı = @kullanıcıadı
                 FOR XML PATH(''), TYPE).value('.', 'NVARCHAR(MAX)'), 1, 2, '') AS birlesik_siparis_adi,
                                   SUM(Fiyat) AS toplam_miktar,
                  STUFF(( SELECT ', ' + Siparisdurumu FROM siparisler s2
                                         WHERE s1.kullanıcıadı = s2.kullanıcıadı
                                         AND s1.MasaNumarası = s2.MasaNumarası
                                         AND s1.SiparisTarihi = s2.SiparisTarihi
                                         AND s1.kullanıcıadı = @kullanıcıadı
                                         FOR XML PATH(''), TYPE).value('.', 'NVARCHAR(MAX)'), 1, 2, '') AS birlesik_durum
                                         FROM siparisler s1
                                         WHERE s1.kullanıcıadı = @kullanıcıadı
                                         GROUP BY kullanıcıadı, MasaNumarası, SiparisTarihi;
                

            ";

            // Bu sorgu bir kullanıcının belirli bir masada ve belirli bir tarihte yaptığı tüm siparişleri tek bir satırda görüntüler
            using (SqlCommand command = new SqlCommand(query, baglanti))
            {
                command.Parameters.AddWithValue("@kullanıcıadı", kullanıcıadı);
                //veri çekme
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                // DataGridView'ı temizle ve yeni veriyle güncelle
                dataGridView1.DataSource = null;
                dataGridView1.Rows.Clear();
                dataGridView1.Columns.Clear();
                dataGridView1.DataSource = dataTable;
                dataGridView1.Refresh();    

            }

            baglanti.Close();


        }
    }
}



