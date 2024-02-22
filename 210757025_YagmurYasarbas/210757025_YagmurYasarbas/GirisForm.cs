using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;

namespace _210757025_YagmurYasarbas
{
    public partial class GirisForm : Form
    {
        SqlConnection baglanti = new SqlConnection(@"Data Source=YAGMUR;Initial Catalog=CAFE;Integrated Security=True");
        public GirisForm()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void cıkıs_giris_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void kayıtadön_Click(object sender, EventArgs e)
        {
            KayıtForm girisform = new KayıtForm();
            girisform.Show();
            this.Hide();

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            sifre_giris.PasswordChar =checkBox1.Checked ? '\0' : '*';
            
        }
        public bool emptyFields()
        {
            if (kullanıcıadı_giris.Text == "" || sifre_giris.Text == "" ) //kullanıcıadı ve sifre bos mu??
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void giris_Click(object sender, EventArgs e)
        {
            if (emptyFields())
            {
                MessageBox.Show("Tüm alanların doldurulması zorunludur.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                baglanti.Open();
                string selectAccount = "SELECT * FROM Kullanıcılar_tbl WHERE kullanıcıadı=@kullanıcıadı AND sifre=@sifre ";
                using (SqlCommand cmd = new SqlCommand(selectAccount, baglanti))

                {
                  cmd.Parameters.AddWithValue("@kullanıcıadı",kullanıcıadı_giris.Text.Trim());
                  cmd.Parameters.AddWithValue("@sifre",sifre_giris.Text.Trim());
           
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable table =new DataTable();
                    adapter.Fill(table);
                    //kullanıcı tablosundan eşleşen bir kayıt varsa 
                    if (table.Rows.Count >= 1)
                    {
                        MessageBox.Show("Giriş Başarılııı!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        
                        
                        string role = table.Rows[0][3].ToString();
                        switch (role)

                        {  //role adminse admin sayfasına yönlendirir
                            case "admin":
                                AdminForm adminForm = new AdminForm();
                                adminForm.Show();
                                this.Hide();
                                break;
                            //role kullanıcıysa kullanıcı sayfasına yönlendirir
                            case "kullanıcı":
                                KullanıcıAnasayfaForm kullaniciForm = new KullanıcıAnasayfaForm();
                                kullaniciForm.kullanıcıadı=kullanıcıadı_giris.Text.Trim();//kullanıcı adını kullanıcıforma gönderir
                                kullaniciForm.Show();
                                this.Hide();
                                break;
                            //role kaiyerse kasiyer sayfasına yönlendirir
                            case "kasiyer":
                                KasiyerForm kasiyerForm = new KasiyerForm();//kullanıcı adını kasiyerforma gönderir
                                kasiyerForm.kullanıcıadı = kullanıcıadı_giris.Text.Trim();
                                kasiyerForm.Show();
                                this.Hide();
                                break;
                            default:
                                MessageBox.Show("Bilinmeyen rol.", "Hata Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                break;
                        }

                    } 
                    else
                    {
                        //kullanıcı bulunamazsa hata verir 
                        MessageBox.Show("Kullanıcı Adı veya şifre Yanlış ","Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }

                   baglanti.Close();

                }


            }

        }

        private void kullanıcıadı_giris_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
