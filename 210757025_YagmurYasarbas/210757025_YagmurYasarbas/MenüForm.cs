using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;


namespace _210757025_YagmurYasarbas
{
    public partial class MenüForm : Form
    {    
        //sql bağlantısı 
        SqlConnection baglanti = new SqlConnection(@"Data Source=YAGMUR;Initial Catalog=CAFE;Integrated Security=True");
        public string kullanıcıadı { get; set; }
        public MenüForm()

        {
            InitializeComponent();



        }


        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void tabPage9_Click(object sender, EventArgs e)
        {

        }

        private void MenüForm_Load(object sender, EventArgs e)
        {



        }
        private DataTable mevcutVeri = new DataTable(); // Sınıf seviyesinde bir DataTable tanımı

        
        public DataTable ÜrünBilgisiGetir(string urunAdi)
        {
            // Belirli bir ürün adına ait bilgileri getirir
            string sorgu = "SELECT ÜrünAdı, Fiyat FROM Menü_tbl WHERE ÜrünAdı=@urunAdi";
            SqlCommand sqlCommand = new SqlCommand(sorgu, baglanti);
            sqlCommand.Parameters.Add("@urunAdi", SqlDbType.NVarChar).Value = urunAdi;
            SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }

        // Ürün bilgilerini gösteren metod
        public void ÜrünBilgileriniGöster(DataTable yeniDt)
        {
            // Mevcut veri boşsa, yeni DataTable'ın yapısını kopyala
            if (mevcutVeri.Rows.Count == 0 && mevcutVeri.Columns.Count == 0)
            {
                mevcutVeri = yeniDt.Clone();
            }

            // Yeni veriyi mevcut DataTable'a ekle
            mevcutVeri.Merge(yeniDt);

            // Birleştirilmiş veriyi DataGridView'e göster
            dataGridView1.DataSource = mevcutVeri;

            // DataGridView'deki fiyatların toplamını hesapla
            decimal toplamFiyat = 0;
            foreach (DataRow row in mevcutVeri.Rows)
            {
                toplamFiyat += Convert.ToDecimal(row["Fiyat"]);
            }

            // Toplam fiyatı TextBox'a göster
            label34.Text = $"Toplam Fiyat: {toplamFiyat:C}";
        }


        private void Buton_Click(object sender, EventArgs e)
        {   // Her buton tıklamada çalışan metod
            Button tiklananButon = sender as Button;
            string butonMetni = tiklananButon.Text;
            DataTable dt = ÜrünBilgisiGetir(butonMetni);
            ÜrünBilgileriniGöster(dt);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button34_Click(object sender, EventArgs e)
        { //anasayfaya geri döner
            KullanıcıAnasayfaForm kullanıcıAnasayfa = new KullanıcıAnasayfaForm();
            kullanıcıAnasayfa.kullanıcıadı = kullanıcıadı;
            kullanıcıAnasayfa.Show();
            this.Hide();
        }
        private void siparisver_Click(object sender, EventArgs e)
        {    // "Sipariş Ver" butonuna tıklandığında çalışan metod


            baglanti.Open();

            // DataGridView'deki verileri döngü ile oku ve SQL Server'a ekler
            if (dataGridView1.Rows.Count>0 && comboBox1.SelectedItem != null)
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (!row.IsNewRow) //satır boş değil ise
                    {
                        string urunAdi = row.Cells[0].Value.ToString();
                        decimal fiyat = Convert.ToDecimal(row.Cells[1].Value);
                        int masanumarasi = Convert.ToInt32(comboBox1.SelectedItem);
                        DateTime siparisTarihi = DateTime.Now;
                        string Siparisdurumu = "Beklemede";

                     
                        using (SqlCommand cmd = new SqlCommand("INSERT INTO Siparisler (ÜrünAdı, Fiyat, kullanıcıadı, SiparisTarihi,MasaNumarası,Siparisdurumu) VALUES (@ÜrünAdı, @Fiyat, @kullanıcıadı, @SiparisTarihi,@MasaNumarası,@Siparisdurumu)", baglanti))
                        {
                            // Parametreleri ekler
                            cmd.Parameters.AddWithValue("@ÜrünAdı", urunAdi);
                            cmd.Parameters.AddWithValue("@Fiyat", fiyat);
                            cmd.Parameters.AddWithValue("@kullanıcıadı", kullanıcıadı);
                            cmd.Parameters.AddWithValue("@SiparisTarihi", siparisTarihi);
                            cmd.Parameters.AddWithValue("@MasaNumarası", masanumarasi);
                            cmd.Parameters.AddWithValue("@Siparisdurumu", Siparisdurumu);

                            // Komutu çalıştırır
                            cmd.ExecuteNonQuery();


                        }

                    }

                }
                baglanti.Close();   

                MessageBox.Show("Sipariş oluşturulmuştur,Siparişlerim menüsünden bakabilirsiniz..");
                dataGridView1.DataSource = null;
                dataGridView1.Rows.Clear();
                mevcutVeri.Rows.Clear();    


            }
            else
            {
                MessageBox.Show("Masa Numarası ve ürün girdiğinizden emin olun!!!!");
            }
               
            
        }

        private void button35_Click(object sender, EventArgs e)
        {    //temizle butonu
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear(); 
            mevcutVeri.Rows.Clear();    
        }
    }
}





