using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _210757025_YagmurYasarbas
{
    public partial class KasiyerForm : Form
    {

        private readonly string connectionString = "Data Source=YAGMUR;Initial Catalog=CAFE;Integrated Security=True";
        private readonly Timer bildirimTimer = new Timer();
        public string kullanıcıadı { get; set; }
      

        public KasiyerForm()
        {
            InitializeComponent();
            // Timer'ı ayarlar
            bildirimTimer.Interval = 5000; // 5 saniye de bir kontrol
            bildirimTimer.Tick += BildirimTimer_Tick;
        }
        private void BildirimTimer_Tick(object sender, EventArgs e)
        {
            // Bildirimleri kontrol et
            BildirimiKontrolEt();
        }

        private void KasiyerForm_Load(object sender, EventArgs e)
        {
            // Form yüklendiğinde timer'ı başlatır
            bildirimTimer.Start();
            //listboxa verileri yükler
            UpdateListBox();
        }


        private void BildirimiKontrolEt()
        {// Bu metod, veritabanındaki en son bildirimi kontrol eder ve bir MessageBox'te görüntüler.
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string sorgu = "SELECT TOP 1 * FROM Notification ORDER BY Id DESC";  //tablodaki en son uyarıyı alır
                SqlCommand komut = new SqlCommand(sorgu, connection);

                connection.Open();
                SqlDataReader okuyucu = komut.ExecuteReader();

                if (okuyucu.HasRows)
                {
                    okuyucu.Read();
                    string mesaj = okuyucu["Message"].ToString();

                    // Bildirimi göster
                    DialogResult result = MessageBox.Show(mesaj, "Bildirim", MessageBoxButtons.OKCancel);

                    // Kullanıcı "Tamam" düğmesine tıklarsa, bildirimi sil
                    if (result == DialogResult.OK)
                    {
                        okuyucu.Close();

                        // Bildirimi sil
                        BildirimiSil();
                    }
                }

                okuyucu.Close();
            }
        }

        // Bu metod, veritabanındaki en son bildirimi siler.
        private void BildirimiSil()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string silmeSorgusu = "DELETE FROM Notification WHERE Id = (SELECT TOP 1 Id FROM Notification ORDER BY Id DESC)";
                SqlCommand silmeKomutu = new SqlCommand(silmeSorgusu, connection);

                connection.Open();
                silmeKomutu.ExecuteNonQuery();
            }
        }



        private void KasiyerForm_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            // Form kapatıldığında timer'ı durdur
            bildirimTimer.Stop();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Bu butonda  'Beklemede' durumundaki siparişleri getirip DataGridView'de görüntüler.
         
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                
                string sqlQuery = "SELECT kullanıcıadı, ÜrünAdı,Fiyat,SiparisTarihi,MasaNumarası,Siparisdurumu FROM Siparisler WHERE Siparisdurumu = 'Beklemede'";

                using (SqlCommand command = new SqlCommand(sqlQuery, connection))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    dataGridView1.DataSource = dataTable;
                }
            }


        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void UpdateListBox()
        {
            //listboxın içeriği güncellenir
            string functionName = "dbo.GetTodayReservations"; //sql function çağırılır
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand($"SELECT * FROM {functionName}()", connection))
                {
                    connection.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();

                    adapter.Fill(dataTable);

                    // ListBox temizler
                    listBox1.Items.Clear();

                    // Verileri ListBox'a ekler
                    foreach (DataRow row in dataTable.Rows)
                    {
                        string item = $"{row["MasaNumarası"]} - {row["RezerveGün"]} - {row["kullanıcıadı"]} - {row["RezerveSaat"]} - {row["RezerveID"]}";
                        listBox1.Items.Add(item);
                    }
                }
            }



        }

        private void button2_Click(object sender, EventArgs e)
        {   //Bir siparişin durumunu güncellenir ve başka bir tabloya onay bilgilerini ekler
            SqlConnection baglanti = new SqlConnection("Data Source=YAGMUR;Initial Catalog=CAFE;Integrated Security=True");
            baglanti.Open();
            SqlCommand komutguncelle = new SqlCommand("UPDATE Siparisler SET SiparisDurumu=@g1 where kullanıcıadı=@g2 ", baglanti);
            komutguncelle.Parameters.AddWithValue("@g1", comboBox1.SelectedItem);
            komutguncelle.Parameters.AddWithValue("@g2", textBox1.Text);
       
            komutguncelle.ExecuteNonQuery();
            MessageBox.Show("Siparis Onaylandı..");
           
            // Kasiyeronayları tablosuna ekle
            SqlCommand komutEkle = new SqlCommand("INSERT INTO Kasiyeronayları_tbl (kasiyer, fiyat) VALUES (@kasiyer, @fiyat)", baglanti);
            komutEkle.Parameters.AddWithValue("@kasiyer", kullanıcıadı); // Kasiyer adını buradan alıyoruz
            komutEkle.Parameters.AddWithValue("@fiyat", Convert.ToDecimal(textBox2.Text)); // Fiyatı buradan alıyoruz

            komutEkle.ExecuteNonQuery();

            baglanti.Close();


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            comboBox1.SelectedItem = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            textBox1.Text= dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //form kapatılır
            Application.Exit();
        }
    }
}

       
