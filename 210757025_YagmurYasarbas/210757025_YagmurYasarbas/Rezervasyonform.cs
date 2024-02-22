using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace _210757025_YagmurYasarbas
{

    public partial class Rezervasyonform : Form
    {
        private SqlConnection connection = new SqlConnection("Data Source=YAGMUR;Initial Catalog=CAFE;Integrated Security=True");
        private System.Windows.Forms.Button[] masalar;
        public string kullanıcıadı;

        public Rezervasyonform()
        {
            InitializeComponent();
            InitializeMasalar();
        }


        private void InitializeMasalar()
        {
            masalar = new System.Windows.Forms.Button[10];

            for (int i = 0; i < 10; i++)
            {
                masalar[i] = new System.Windows.Forms.Button();
                masalar[i].Text = $"Masa {i + 1}";
                masalar[i].Tag = i + 1; // Masa numarasını etiket olarak saklar
                masalar[i].Click += MasaButton_Click; // Masa düğmesi tıklama olayını atar
                masalar[i].Size = new System.Drawing.Size(130, 130);
                flowLayoutPanel1.Controls.Add(masalar[i]); // Masa düğmesini panelde gösterir
            }
        }

        private void MasaButton_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Button masaButton = (System.Windows.Forms.Button)sender;

            // Rezervasyon tarihini ve saati alır
            DateTime rezervasyonTarihi = dateTimePicker1.Value;
            string rezervasyonSaati = comboBox1.SelectedItem?.ToString(); // ?? operatörü ile null kontrolü ve varsayılan değer atanması


            // Masa numarasını alır
            int masaNumarasi = (int)masaButton.Tag;
            // Geçerlilik kontrolü yapar
            if (string.IsNullOrEmpty(rezervasyonSaati) || rezervasyonTarihi < DateTime.Now)
            {
                MessageBox.Show("Geçerli bir tarih ve saat seçin.");
                return;
            }
            if (MasadaRezervasyonVarMi(masaNumarasi, rezervasyonTarihi, rezervasyonSaati))
            {
                MessageBox.Show("Bu masa için seçilen tarih ve saatte rezervasyon zaten bulunmaktadır.", "Rezervasyon Hatası");
                return;
            }

            this.kullanıcıadı = kullanıcıadı;

            // Rezervasyonu SQL veritabanına ekler
            EkleRezervasyon(masaNumarasi, rezervasyonTarihi, rezervasyonSaati, kullanıcıadı); // Müşteri adını burada kullanır
        }

        private void EkleRezervasyon(int masaNumarasi, DateTime rezervasyonTarihi, string rezervasyonSaati, string musteriAdi)
        {

            SqlConnection connection = new SqlConnection("Data Source=YAGMUR;Initial Catalog=CAFE;Integrated Security=True");

           
            string query = "INSERT INTO Rezervasyon_tbl (MasaNumarası,RezerveGün, RezerveSaat,kullanıcıadı) " +
                             "VALUES (@TableNumber, @ReservationDate, @ReservationTime, @CustomerName)";

            connection.Open();

            using (SqlCommand command = new SqlCommand(query, connection))
            {
               //veri tabanına ekler
                command.Parameters.AddWithValue("@TableNumber", masaNumarasi);
                command.Parameters.AddWithValue("@ReservationDate", rezervasyonTarihi);
                command.Parameters.AddWithValue("@ReservationTime", rezervasyonSaati);
                command.Parameters.AddWithValue("@CustomerName", musteriAdi);

                // Sorguyu yürütür
                command.ExecuteNonQuery();

                MessageBox.Show("Rezervasyon başarıyla eklendi.");
            }

        }

        private bool MasadaRezervasyonVarMi(int masaNumarasi, DateTime rezerveGün, string rezerveSaat)
        { // Belirtilen masada rezervasyon olup olmadığını kontrol eden metod

            bool rezervasyonVarMi = false;

          using (SqlConnection connection = new SqlConnection("Data Source=YAGMUR;Initial Catalog=CAFE;Integrated Security=True"))
          { 
           connection.Open();

            using (SqlCommand command = new SqlCommand("Rezervasyonbulma", connection))
            {
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@MasaNumarasi", masaNumarasi);
            command.Parameters.AddWithValue("@RezerveGün", rezerveGün);
            command.Parameters.AddWithValue("@RezerveSaat", rezerveSaat);
            // Output parametre ekleyerek rezervasyon durumunu alır
            SqlParameter rezervasyonDurumuParam = new SqlParameter("@RezervasyonVarMi", SqlDbType.Int);
            rezervasyonDurumuParam.Direction = ParameterDirection.Output;
            command.Parameters.Add(rezervasyonDurumuParam);

            command.ExecuteNonQuery();
             // Stored Procedure'ı çalıştır


            rezervasyonVarMi = (int)command.Parameters["@RezervasyonVarMi"].Value == 1;
             // Output parametresinden rezervasyon durumunu al

                }
            }

          return rezervasyonVarMi;
        }


        private void DateTimePicker_ValueChanged(object sender, EventArgs e)
        { 
            RezervasyonDurumunuGuncelle();
        }
        // DateTimePicker veya ComboBox değerleri değiştikçe RezervasyonDurumunuGuncelle metodunu çağırır
        private void ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            RezervasyonDurumunuGuncelle();
        }

        private void RezervasyonDurumunuGuncelle()
        {
            // Tüm masaları döngüye alın ve rezervasyon durumunu günceller
            for (int i = 0; i < 10; i++)
            {
                if (comboBox1.SelectedItem != null) //seçim var ise
                {
                    if (MasadaRezervasyonVarMi(i + 1, dateTimePicker1.Value, comboBox1.SelectedItem?.ToString()))
                    {
                        masalar[i].BackColor = Color.Red; // Rezerve varsa kırmızı
                    }
                    else
                    {
                        masalar[i].BackColor = Color.Yellow; // Rezerve yoksa sarı
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Kullanıcı anasayfaya geri döner
            KullanıcıAnasayfaForm kullanıcıAnasayfa = new KullanıcıAnasayfaForm();
            kullanıcıAnasayfa.kullanıcıadı = kullanıcıadı;
            kullanıcıAnasayfa.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Rezervasyonform_Load(object sender, EventArgs e)
        {

        }
    }
}
