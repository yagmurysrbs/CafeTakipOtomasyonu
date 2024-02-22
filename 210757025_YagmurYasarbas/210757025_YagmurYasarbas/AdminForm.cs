using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _210757025_YagmurYasarbas
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

       

        private void adminKullanıcıEkleForm1_Load(object sender, EventArgs e)
        {

        }

        private void panel2_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void cıkıs_Click(object sender, EventArgs e)
        {

        }

        private void cikisbuton_Click_1(object sender, EventArgs e)
        {
            DialogResult check = MessageBox.Show("Çıkmak istediğinize emin misiniz?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (check == DialogResult.Yes)
            {
                GirisForm loginForm = new GirisForm();
                loginForm.Show();
                this.Hide();
            }
        }

        private void GöstergePaneli_Click(object sender, EventArgs e)
        {
            İstatistik istatistik=new İstatistik();
            istatistik.Show();
            this.Hide();
        }

        private void KasiyerEkle_Click(object sender, EventArgs e)
        {
            KasiyerEkle kasiyerekle= new KasiyerEkle(); 
            kasiyerekle.Show();
            this.Hide();
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Müsteriler müsteriler=new Müsteriler();
            müsteriler.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Stok stok=new Stok();
            stok.Show();
            this.Hide();
        }
    }
}
