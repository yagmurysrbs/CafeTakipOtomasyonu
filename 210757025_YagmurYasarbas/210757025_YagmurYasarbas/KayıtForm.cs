using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Runtime.Remoting.Contexts;

namespace _210757025_YagmurYasarbas
{

   
    public partial class KayıtForm : Form
    {
        SqlConnection baglanti = new SqlConnection(@"Data Source=YAGMUR;Initial Catalog=CAFE;Integrated Security=True");
        public KayıtForm()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void KayıtForm_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void cıkıs_kayıt_Click(object sender, EventArgs e)
        { // form kapatır
            Application.Exit();
        }

        private void girisedön_Click(object sender, EventArgs e)
        {
            // Giris forma döner
            GirisForm girisform = new GirisForm();
            girisform.Show();
            this.Hide();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            sifre_kayıt.PasswordChar = checkBox1.Checked ? '\0' : '*';
            sifretekrar_kayıt.PasswordChar = checkBox1.Checked ? '\0':'*';


        }


        public bool emptyFields()
        {
            if (kullanıcıadı_kayıt.Text == "" || sifre_kayıt.Text == ""|| sifretekrar_kayıt.Text == "")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void kayıtol_Click(object sender, EventArgs e)
        {
            if (emptyFields())
            {
                MessageBox.Show("Tüm alanların doldurulması zorunludur.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                baglanti.Open();
                string selectUsername = "SELECT * FROM Kullanıcılar_tbl WHERE kullanıcıadı = @kullanıcıadı";
                //KULLANMAK İSTEDİĞİNİZ KULLANICI ADINI ZATEN ALINMIŞ OLDUĞUNU KONTROL EDER
                using (SqlCommand checkUsername = new SqlCommand(selectUsername, baglanti))
                {
                    checkUsername.Parameters.AddWithValue("@kullanıcıadı", kullanıcıadı_kayıt.Text.Trim());
                    SqlDataAdapter adapter = new SqlDataAdapter(checkUsername);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    if (table.Rows.Count >= 1)
                    {   // aynı kullanıcıadında veri tabanında kullanıcı varsa eklmez
                        string usern = kullanıcıadı_kayıt.Text.Substring(0, 1).ToUpper() + kullanıcıadı_kayıt.Text.Substring(1);
                        MessageBox.Show(usern + " Kullanıcı zaten ekli.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (sifre_kayıt.Text != sifretekrar_kayıt.Text)
                    {   //şifre kontrol
                        MessageBox.Show("Şifreler aynı değil.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (sifre_kayıt.Text.Length < 8)
                    {   //şifre en az 8 karakter olmalı
                        MessageBox.Show("Geçersiz şifre, en az 8 karakter gerekli.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {   //veri tabanına kullanıcı ekler
                        string insertData = "INSERT INTO Kullanıcılar_tbl (kullanıcıadı,sifre, profil_foto, role, statu, veri_kaydı) " +
                           " VALUES (@k1, @k2, @k3, @k4, @k5, @k6)";
                        DateTime today = DateTime.Today;
                        using (SqlCommand cmd = new SqlCommand(insertData, baglanti))
                        {
                            cmd.Parameters.AddWithValue("@k1", kullanıcıadı_kayıt.Text.Trim());
                            cmd.Parameters.AddWithValue("@k2", sifre_kayıt.Text.Trim());
                            cmd.Parameters.AddWithValue("@k3", "");
                            cmd.Parameters.AddWithValue("@k4", "Kasiyer");
                            cmd.Parameters.AddWithValue("@k5", "Onay");
                            cmd.Parameters.AddWithValue("@k6", today);
                            cmd.ExecuteNonQuery();

                            MessageBox.Show("Kayıt Başarılı !", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            GirisForm loginForm = new GirisForm();
                            loginForm.Show();
                            this.Hide();
                        }

                    }
                }

                baglanti.Close();

            }
            
        }
        
    } 
}
