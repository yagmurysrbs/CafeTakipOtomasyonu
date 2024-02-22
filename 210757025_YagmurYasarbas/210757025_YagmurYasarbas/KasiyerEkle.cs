using System;
using System.Data.SqlClient;
using System.Globalization;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace _210757025_YagmurYasarbas
{
    public partial class KasiyerEkle : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source=YAGMUR;Initial Catalog=CAFE;Integrated Security=True");

        public KasiyerEkle()
        {
            InitializeComponent();
        }

        private void KasiyerEkle_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'cAFEDataSet.Kullanıcılar_tbl' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir veya kaldırabilirsiniz.
            this.kullanıcılar_tblTableAdapter.Fill(this.cAFEDataSet.Kullanıcılar_tbl);
        }

        void Temizle()
        {
            kullanıcıadı.Text = "";
            sifre.Text = "";
            dateTimePicker1.Value = DateTime.Now;
            rol.SelectedItem = null;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // seçili kaydı siler
            baglanti.Open();
            SqlCommand komutsil = new SqlCommand("Delete from Kullanıcılar_tbl where kullanıcıadı=@s1", baglanti);
            komutsil.Parameters.AddWithValue("@s1", kullanıcıadı.Text);
            komutsil.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kayıt Silindi....");
        }

        private void btn_listele_Click(object sender, EventArgs e)
        {
            this.kullanıcılar_tblTableAdapter.Fill(this.cAFEDataSet.Kullanıcılar_tbl);
        }

        private void temizle_btn_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void kaydet_btn_Click(object sender, EventArgs e)
        {
            //yeni kayıt ekler
            baglanti.Open();

            SqlCommand komutkaydet = new SqlCommand("insert into Kullanıcılar_tbl  (kullanıcıadı, sifre, role, veri_kaydı) values (@k1, @k2, @k3, @k4)", baglanti);
            komutkaydet.Parameters.AddWithValue("@k1", kullanıcıadı.Text);
            komutkaydet.Parameters.AddWithValue("@k2", sifre.Text);
            komutkaydet.Parameters.AddWithValue("@k3", rol.SelectedItem);
            komutkaydet.Parameters.AddWithValue("@k4", dateTimePicker1.Value);

            MessageBox.Show("Başarılı ....");
            komutkaydet.ExecuteNonQuery();
            baglanti.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            // datada hücreleri yansıtır
            int secilen = dataGridView1.SelectedCells[1].RowIndex;
            kullanıcıadı.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            sifre.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            dateTimePicker1.Value = Convert.ToDateTime(dataGridView1.Rows[secilen].Cells[4].Value);
            rol.SelectedItem = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            id.Text= dataGridView1.Rows[secilen].Cells[0].Value.ToString();


        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void gnclle_btn_Click(object sender, EventArgs e)
        {

                //kayıtlı kayıtta değişiklikleri günceller
                baglanti.Open();
                SqlCommand komutguncelle = new SqlCommand("UPDATE Kullanıcılar_tbl SET kullanıcıadı=@g1 ,sifre=@g2, role=@g3 ,veri_kaydı=@g4 where id=@g5 ", baglanti);
                komutguncelle.Parameters.AddWithValue("@g1", kullanıcıadı.Text);
                komutguncelle.Parameters.AddWithValue("@g2", sifre.Text);
                komutguncelle.Parameters.AddWithValue("@g3", rol.Text);
                komutguncelle.Parameters.AddWithValue("@g4", dateTimePicker1.Value);
                komutguncelle.Parameters.AddWithValue("@g5", id.Text);
                komutguncelle.ExecuteNonQuery();
                MessageBox.Show("Kayıt guncellendi..");
           
                baglanti.Close();
            

           
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //adminforma geri döner
            AdminForm adminForm = new AdminForm();
            adminForm.ShowDialog();
            this.Hide();
        }
    }
}