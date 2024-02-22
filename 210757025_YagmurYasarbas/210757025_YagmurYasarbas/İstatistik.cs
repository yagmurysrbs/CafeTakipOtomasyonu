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

namespace _210757025_YagmurYasarbas
{
    
    public partial class İstatistik : Form
    {
        SqlConnection baglanti = new SqlConnection(@"Data Source=YAGMUR;Initial Catalog=CAFE;Integrated Security=True");
        public İstatistik()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {// Ürünün toplam satışını getir butonu
            if (Urünadı.SelectedItem != null)
            {
                   string urunAdi = Urünadı.SelectedItem.ToString();

                
                    baglanti.Open();
                    //ürün adı kullanıcıdan alınarak ÜrününToplamCiro SP çağırılır
                    using (SqlCommand komut = new SqlCommand("ÜrününToplamCiro", baglanti))
                    {
                        komut.CommandType = CommandType.StoredProcedure;
                        komut.Parameters.AddWithValue("@ürünadı", urunAdi);

                        using (SqlDataAdapter adapter = new SqlDataAdapter(komut))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);

                            if (dataTable.Rows.Count > 0)
                            {
                                dataGridView1.DataSource = dataTable;
                            // sonuclar datagridviewe yansıtılır.
                            }
                            else
                            {//veri yoksa hata mesajı verilir
                                MessageBox.Show("Belirtilen ürün için veri bulunamadı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                    baglanti.Close();
                
            }
            else
            {   //comboboxtan ürün seçimi yapılmaz ise
                MessageBox.Show("Lütfen bir ürün seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //İki Tarih Arası Toplam Satış Getir

            // DateTimePicker'lardan değerleri alır
            DateTime baslangicTarih = dateTimePicker1.Value;
            DateTime bitisTarih = dateTimePicker2.Value;

            // ToplamFiyatHesapla Stored Procedure'ı çağırır
            using (SqlCommand cmd = new SqlCommand("ToplamFiyatHesapla", baglanti))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                
                cmd.Parameters.AddWithValue("@BaslangicTarih", baslangicTarih);
                cmd.Parameters.AddWithValue("@BitisTarih", bitisTarih);

              
                baglanti.Open();

                // Stored Procedure'ı çalıştırır
                using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                {
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    // Sonucu DataGridView'de gösterir
                    dataGridView1.DataSource = dataTable;
                }
                baglanti.Close() ;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
           // En Fazla Siparis Verilen Ürünü Getir butonu
            using (SqlCommand cmd = new SqlCommand("EnFazlaSiparisVerilen", baglanti))
            {
                cmd.CommandType = CommandType.StoredProcedure;

              
                baglanti.Open();

                // EnFazlaSiparisVerilen Stored Procedure'ı çalıştırır
                using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                {
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    // Sonucu DataGridView'de gösterir
                    dataGridView1.DataSource = dataTable;
                }
                baglanti.Close() ;  
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {   //Rezervasyon İstatistiklerini Getir Butonu
            using (SqlCommand cmd = new SqlCommand("EnFazlaSecilenAnaliz", baglanti))
            {

                cmd.CommandType = CommandType.StoredProcedure;


                baglanti.Open();
                // EnFazlaSecilenAnaliz Stored Procedure'ı çalıştırır
                using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                {
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    // Sonucu DataGridView'de gösterir
                    dataGridView1.DataSource = dataTable;
                }
                baglanti.Close();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {  //Geri dön butonu admin anasayfaya yönlendirir.
            AdminForm form = new AdminForm();
            form.Show();
            this.Hide();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void İstatistik_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {   //Kasiyer Onaylarını Getir Butonu
            using (SqlConnection connection = new SqlConnection("Data Source=YAGMUR;Initial Catalog=CAFE;Integrated Security=True"))
            {
                connection.Open();

                // KasiyerToplamOnay function  çağırır
                string query = "SELECT * FROM dbo.KasiyerToplamOnay()";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    // DataGridView'e verileri yükler
                    dataGridView1.DataSource = dataTable;
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)

        {   //Cafe Rapor Getir
            baglanti.Open();

           //view çağırılır
            string query = "SELECT * FROM CafeRaporView";
            // SqlDataAdapter ile sorgu çalıştırılır ve sonuçları DataTable'a doldurulur.
            SqlDataAdapter adapter = new SqlDataAdapter(query, baglanti);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
        }
    }
    
}
    


