namespace _210757025_YagmurYasarbas
{
    partial class Stok
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.malzemeadıDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stokmiktarıDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ürünidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.malzemelertblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cAFEDataSet1 = new _210757025_YagmurYasarbas.CAFEDataSet1();
            this.kaydet = new System.Windows.Forms.Button();
            this.sil = new System.Windows.Forms.Button();
            this.temizle = new System.Windows.Forms.Button();
            this.listele = new System.Windows.Forms.Button();
            this.malzemeler_tblTableAdapter = new _210757025_YagmurYasarbas.CAFEDataSet1TableAdapters.Malzemeler_tblTableAdapter();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.güncelle = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.malzemelertblBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cAFEDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(68, 103);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(192, 22);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(71, 22);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(192, 22);
            this.textBox2.TabIndex = 1;
            this.textBox2.Visible = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.malzemeadıDataGridViewTextBoxColumn,
            this.stokmiktarıDataGridViewTextBoxColumn,
            this.ürünidDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.malzemelertblBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 254);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(605, 541);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // malzemeadıDataGridViewTextBoxColumn
            // 
            this.malzemeadıDataGridViewTextBoxColumn.DataPropertyName = "malzemeadı";
            this.malzemeadıDataGridViewTextBoxColumn.HeaderText = "malzemeadı";
            this.malzemeadıDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.malzemeadıDataGridViewTextBoxColumn.Name = "malzemeadıDataGridViewTextBoxColumn";
            this.malzemeadıDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // stokmiktarıDataGridViewTextBoxColumn
            // 
            this.stokmiktarıDataGridViewTextBoxColumn.DataPropertyName = "stokmiktarı";
            this.stokmiktarıDataGridViewTextBoxColumn.HeaderText = "stokmiktarı";
            this.stokmiktarıDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.stokmiktarıDataGridViewTextBoxColumn.Name = "stokmiktarıDataGridViewTextBoxColumn";
            this.stokmiktarıDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ürünidDataGridViewTextBoxColumn
            // 
            this.ürünidDataGridViewTextBoxColumn.DataPropertyName = "ürünid";
            this.ürünidDataGridViewTextBoxColumn.HeaderText = "ürünid";
            this.ürünidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ürünidDataGridViewTextBoxColumn.Name = "ürünidDataGridViewTextBoxColumn";
            this.ürünidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // malzemelertblBindingSource
            // 
            this.malzemelertblBindingSource.DataMember = "Malzemeler_tbl";
            this.malzemelertblBindingSource.DataSource = this.cAFEDataSet1;
            // 
            // cAFEDataSet1
            // 
            this.cAFEDataSet1.DataSetName = "CAFEDataSet1";
            this.cAFEDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kaydet
            // 
            this.kaydet.Location = new System.Drawing.Point(475, 122);
            this.kaydet.Name = "kaydet";
            this.kaydet.Size = new System.Drawing.Size(118, 47);
            this.kaydet.TabIndex = 3;
            this.kaydet.Text = "Kaydet";
            this.kaydet.UseVisualStyleBackColor = true;
            this.kaydet.Click += new System.EventHandler(this.button1_Click);
            // 
            // sil
            // 
            this.sil.Location = new System.Drawing.Point(322, 122);
            this.sil.Name = "sil";
            this.sil.Size = new System.Drawing.Size(118, 47);
            this.sil.TabIndex = 4;
            this.sil.Text = "Sil";
            this.sil.UseVisualStyleBackColor = true;
            this.sil.Click += new System.EventHandler(this.sil_Click);
            // 
            // temizle
            // 
            this.temizle.Location = new System.Drawing.Point(391, 187);
            this.temizle.Name = "temizle";
            this.temizle.Size = new System.Drawing.Size(118, 47);
            this.temizle.TabIndex = 5;
            this.temizle.Text = "Temizle";
            this.temizle.UseVisualStyleBackColor = true;
            this.temizle.Click += new System.EventHandler(this.temizle_Click);
            // 
            // listele
            // 
            this.listele.Location = new System.Drawing.Point(475, 39);
            this.listele.Name = "listele";
            this.listele.Size = new System.Drawing.Size(118, 47);
            this.listele.TabIndex = 6;
            this.listele.Text = "Listele";
            this.listele.UseVisualStyleBackColor = true;
            this.listele.Click += new System.EventHandler(this.listele_Click);
            // 
            // malzemeler_tblTableAdapter
            // 
            this.malzemeler_tblTableAdapter.ClearBeforeFill = true;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(68, 174);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(192, 22);
            this.textBox3.TabIndex = 7;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // güncelle
            // 
            this.güncelle.Location = new System.Drawing.Point(322, 39);
            this.güncelle.Name = "güncelle";
            this.güncelle.Size = new System.Drawing.Size(118, 47);
            this.güncelle.TabIndex = 8;
            this.güncelle.Text = "Güncelle";
            this.güncelle.UseVisualStyleBackColor = true;
            this.güncelle.Click += new System.EventHandler(this.güncelle_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(750, 22);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(214, 41);
            this.button1.TabIndex = 9;
            this.button1.Text = "Geri Dön";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.MistyRose;
            this.listBox1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 18;
            this.listBox1.Location = new System.Drawing.Point(623, 233);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(582, 562);
            this.listBox1.TabIndex = 10;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(130, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 18);
            this.label1.TabIndex = 11;
            this.label1.Text = "Ürün Adı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(116, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 18);
            this.label2.TabIndex = 12;
            this.label2.Text = "Stok Miktarı:";
            // 
            // Stok
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(1208, 807);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.güncelle);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.listele);
            this.Controls.Add(this.temizle);
            this.Controls.Add(this.sil);
            this.Controls.Add(this.kaydet);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Stok";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stok";
            this.Load += new System.EventHandler(this.Stok_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.malzemelertblBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cAFEDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button kaydet;
        private System.Windows.Forms.Button sil;
        private System.Windows.Forms.Button temizle;
        private System.Windows.Forms.Button listele;
        private CAFEDataSet1 cAFEDataSet1;
        private System.Windows.Forms.BindingSource malzemelertblBindingSource;
        private CAFEDataSet1TableAdapters.Malzemeler_tblTableAdapter malzemeler_tblTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn malzemeadıDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stokmiktarıDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ürünidDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button güncelle;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}