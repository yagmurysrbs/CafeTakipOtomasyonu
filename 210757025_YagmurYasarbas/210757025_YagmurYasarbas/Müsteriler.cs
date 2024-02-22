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
    public partial class Müsteriler : Form
    {
        SqlConnection connection = new SqlConnection(@"Data Source=YAGMUR;Initial Catalog=CAFE;Integrated Security=True");
        public Müsteriler()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        { // kullanıcılar tablosunu dataya yansıtır
            connection.Open();
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Kullanıcılar_tbl", connection);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
            connection.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        { // admin forma geri döner
            AdminForm form = new AdminForm();
            form.Show();
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {  
            string keyword = textBox1.Text.Trim();
            //textboxtan kelimeyii alır ve kelimeAratma function çağırır.
            SqlDataAdapter adapter = new SqlDataAdapter($"SELECT * FROM dbo.kelimeAratma('{keyword}')", connection);
            //verileri datagridviewe yansıtır
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
        }
    }
           
        
}
