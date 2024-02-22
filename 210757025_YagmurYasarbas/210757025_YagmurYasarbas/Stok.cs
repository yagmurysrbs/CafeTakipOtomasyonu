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
    public partial class Stok : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source=YAGMUR;Initial Catalog=CAFE;Integrated Security=True");

        public Stok()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {   //kaydetme butonu
            baglanti.Open();
            //ürün ve stok ekler veritabanına
            SqlCommand komutkaydet = new SqlCommand("insert into Malzemeler_tbl  (malzemeadı,stokmiktarı) values (@k1, @k2 )", baglanti);
            komutkaydet.Parameters.AddWithValue("@k2", textBox1.Text);
            komutkaydet.Parameters.AddWithValue("@k1", textBox3.Text);
            MessageBox.Show("Başarılı ....");
            komutkaydet.ExecuteNonQuery();
            baglanti.Close();

        }

        private void Stok_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'cAFEDataSet1.Malzemeler_tbl' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            //this.malzemeler_tblTableAdapter.Fill(this.cAFEDataSet1.Malzemeler_tbl);
            ListeyeUyarilariYansit();
        }
        private void ListeyeUyarilariYansit()
        {
            listBox1.Items.Clear(); // ListBox'ı temizler

            // SQL Server bağlantı dizesi
            string connectionString = "Data Source=YAGMUR;Initial Catalog=CAFE;Integrated Security=True";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Uyarilar tablosundan verileri çeker
                string query = "SELECT UrunID, UyariMesaji FROM Uyarilar";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            // Uyarı bilgilerini ListBox'a ekler
                            string uyariMesaji = $"Urun ID: {reader["UrunID"]}, Uyari Mesaji: {reader["UyariMesaji"]}";
                            listBox1.Items.Add(uyariMesaji);
                        }
                    }
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void listele_Click(object sender, EventArgs e)
        {    //listeleme butonu
            this.malzemeler_tblTableAdapter.Fill(this.cAFEDataSet1.Malzemeler_tbl);
        }

        private void temizle_Click(object sender, EventArgs e)
        {   //temizleme butonu
            textBox1.Text = "";
            textBox2.Text = " ";
            textBox3.Text = " ";    
        }

        private void sil_Click(object sender, EventArgs e)
        {   //seçili kaydı silme
            baglanti.Open();
            SqlCommand komutsil = new SqlCommand("Delete from Malzemeler_tbl where ürünid=@s1", baglanti);
            komutsil.Parameters.AddWithValue("@s1", textBox2.Text);
            komutsil.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kayıt Silindi....");
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[1].RowIndex;
            textBox1.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            textBox2.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            textBox3.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();

        }

        private void güncelle_Click(object sender, EventArgs e)
        {   //seçili kaydı günceller 
            baglanti.Open();
            SqlCommand komutguncelle = new SqlCommand("UPDATE Malzemeler_tbl SET malzemeadı=@g1 ,stokmiktarı=@g2 where ürünid=@g3 ", baglanti);
            komutguncelle.Parameters.AddWithValue("@g2", textBox1.Text);
            komutguncelle.Parameters.AddWithValue("@g3", float.Parse(textBox2.Text));
            komutguncelle.Parameters.AddWithValue("@g1", textBox3.Text);
          
            komutguncelle.ExecuteNonQuery();
            MessageBox.Show("Kayıt guncellendi..");
            ListeyeUyarilariYansit();

            baglanti.Close();

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //admin forma geri döner
            AdminForm adminForm = new AdminForm();
            adminForm.ShowDialog();
            this.Hide();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}




