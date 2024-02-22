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
    public partial class KullanıcıAnasayfaForm : Form
    {
        public string kullanıcıadı { get; set; }
        public KullanıcıAnasayfaForm()
        {
            InitializeComponent();
            CenterToScreen();

        }

        private void button5_Click(object sender, EventArgs e)
        {   //çıkış butonu
            DialogResult check = MessageBox.Show("Çıkış yapılıyor,emin misiniz?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (check == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void KullanıcıAnasayfaForm_Load(object sender, EventArgs e)
        {
            label2.Text = kullanıcıadı; //kullanıcıadı alınır


        }

        private void button1_Click(object sender, EventArgs e)
        {
            MenüForm menüform = new MenüForm();
            menüform.kullanıcıadı = label2.Text;//kullanıcıadı rezervasyon forma gönderilir
            menüform.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Siparislerim siparislerim = new Siparislerim();
            siparislerim.kullanıcıadı = label2.Text.Trim(); //kullanıcıadı siparislerim forma gönderilir
            siparislerim.Show();    

            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Rezervasyonform rezerveform = new Rezervasyonform();
            rezerveform.kullanıcıadı = label2.Text.Trim();//kullanıcıadı rezervasyon forma gönderilir
            rezerveform.Show();
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
