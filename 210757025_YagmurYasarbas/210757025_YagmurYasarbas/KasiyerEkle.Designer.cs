namespace _210757025_YagmurYasarbas
{
    partial class KasiyerEkle
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kullanıcıadıDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sifreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.verikaydıDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kullanıcılartblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cAFEDataSet = new _210757025_YagmurYasarbas.CAFEDataSet();
            this.kullanıcıadı = new System.Windows.Forms.TextBox();
            this.sifre = new System.Windows.Forms.TextBox();
            this.sil_btn = new System.Windows.Forms.Button();
            this.kaydet_btn = new System.Windows.Forms.Button();
            this.temizle_btn = new System.Windows.Forms.Button();
            this.btn_listele = new System.Windows.Forms.Button();
            this.kullanıcılar_tblTableAdapter = new _210757025_YagmurYasarbas.CAFEDataSetTableAdapters.Kullanıcılar_tblTableAdapter();
            this.gnclle_btn = new System.Windows.Forms.Button();
            this.rol = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kullanıcılartblBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cAFEDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.kullanıcıadıDataGridViewTextBoxColumn,
            this.sifreDataGridViewTextBoxColumn,
            this.roleDataGridViewTextBoxColumn,
            this.verikaydıDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.kullanıcılartblBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(504, 14);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(681, 764);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 125;
            // 
            // kullanıcıadıDataGridViewTextBoxColumn
            // 
            this.kullanıcıadıDataGridViewTextBoxColumn.DataPropertyName = "kullanıcıadı";
            this.kullanıcıadıDataGridViewTextBoxColumn.HeaderText = "kullanıcıadı";
            this.kullanıcıadıDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kullanıcıadıDataGridViewTextBoxColumn.Name = "kullanıcıadıDataGridViewTextBoxColumn";
            this.kullanıcıadıDataGridViewTextBoxColumn.ReadOnly = true;
            this.kullanıcıadıDataGridViewTextBoxColumn.Width = 125;
            // 
            // sifreDataGridViewTextBoxColumn
            // 
            this.sifreDataGridViewTextBoxColumn.DataPropertyName = "sifre";
            this.sifreDataGridViewTextBoxColumn.HeaderText = "sifre";
            this.sifreDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sifreDataGridViewTextBoxColumn.Name = "sifreDataGridViewTextBoxColumn";
            this.sifreDataGridViewTextBoxColumn.ReadOnly = true;
            this.sifreDataGridViewTextBoxColumn.Width = 125;
            // 
            // roleDataGridViewTextBoxColumn
            // 
            this.roleDataGridViewTextBoxColumn.DataPropertyName = "role";
            this.roleDataGridViewTextBoxColumn.HeaderText = "role";
            this.roleDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.roleDataGridViewTextBoxColumn.Name = "roleDataGridViewTextBoxColumn";
            this.roleDataGridViewTextBoxColumn.ReadOnly = true;
            this.roleDataGridViewTextBoxColumn.Width = 125;
            // 
            // verikaydıDataGridViewTextBoxColumn
            // 
            this.verikaydıDataGridViewTextBoxColumn.DataPropertyName = "veri_kaydı";
            this.verikaydıDataGridViewTextBoxColumn.HeaderText = "veri_kaydı";
            this.verikaydıDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.verikaydıDataGridViewTextBoxColumn.Name = "verikaydıDataGridViewTextBoxColumn";
            this.verikaydıDataGridViewTextBoxColumn.ReadOnly = true;
            this.verikaydıDataGridViewTextBoxColumn.Width = 125;
            // 
            // kullanıcılartblBindingSource
            // 
            this.kullanıcılartblBindingSource.DataMember = "Kullanıcılar_tbl";
            this.kullanıcılartblBindingSource.DataSource = this.cAFEDataSet;
            // 
            // cAFEDataSet
            // 
            this.cAFEDataSet.DataSetName = "CAFEDataSet";
            this.cAFEDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kullanıcıadı
            // 
            this.kullanıcıadı.Location = new System.Drawing.Point(163, 91);
            this.kullanıcıadı.Name = "kullanıcıadı";
            this.kullanıcıadı.Size = new System.Drawing.Size(239, 25);
            this.kullanıcıadı.TabIndex = 1;
            // 
            // sifre
            // 
            this.sifre.Location = new System.Drawing.Point(163, 138);
            this.sifre.Name = "sifre";
            this.sifre.Size = new System.Drawing.Size(239, 25);
            this.sifre.TabIndex = 2;
            // 
            // sil_btn
            // 
            this.sil_btn.Location = new System.Drawing.Point(110, 420);
            this.sil_btn.Name = "sil_btn";
            this.sil_btn.Size = new System.Drawing.Size(223, 51);
            this.sil_btn.TabIndex = 5;
            this.sil_btn.Text = "Sil";
            this.sil_btn.UseVisualStyleBackColor = true;
            this.sil_btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // kaydet_btn
            // 
            this.kaydet_btn.Location = new System.Drawing.Point(110, 341);
            this.kaydet_btn.Name = "kaydet_btn";
            this.kaydet_btn.Size = new System.Drawing.Size(223, 51);
            this.kaydet_btn.TabIndex = 6;
            this.kaydet_btn.Text = "Kaydet";
            this.kaydet_btn.UseVisualStyleBackColor = true;
            this.kaydet_btn.Click += new System.EventHandler(this.kaydet_btn_Click);
            // 
            // temizle_btn
            // 
            this.temizle_btn.Location = new System.Drawing.Point(110, 664);
            this.temizle_btn.Name = "temizle_btn";
            this.temizle_btn.Size = new System.Drawing.Size(223, 51);
            this.temizle_btn.TabIndex = 7;
            this.temizle_btn.Text = "Temizle";
            this.temizle_btn.UseVisualStyleBackColor = true;
            this.temizle_btn.Click += new System.EventHandler(this.temizle_btn_Click);
            // 
            // btn_listele
            // 
            this.btn_listele.Location = new System.Drawing.Point(110, 586);
            this.btn_listele.Name = "btn_listele";
            this.btn_listele.Size = new System.Drawing.Size(223, 51);
            this.btn_listele.TabIndex = 8;
            this.btn_listele.Text = "Listele";
            this.btn_listele.UseVisualStyleBackColor = true;
            this.btn_listele.Click += new System.EventHandler(this.btn_listele_Click);
            // 
            // kullanıcılar_tblTableAdapter
            // 
            this.kullanıcılar_tblTableAdapter.ClearBeforeFill = true;
            // 
            // gnclle_btn
            // 
            this.gnclle_btn.Location = new System.Drawing.Point(110, 510);
            this.gnclle_btn.Name = "gnclle_btn";
            this.gnclle_btn.Size = new System.Drawing.Size(223, 51);
            this.gnclle_btn.TabIndex = 9;
            this.gnclle_btn.Text = "Güncelle";
            this.gnclle_btn.UseVisualStyleBackColor = true;
            this.gnclle_btn.Click += new System.EventHandler(this.gnclle_btn_Click);
            // 
            // rol
            // 
            this.rol.FormattingEnabled = true;
            this.rol.Items.AddRange(new object[] {
            "kasiyer",
            "admin",
            "kullanıcı"});
            this.rol.Location = new System.Drawing.Point(163, 237);
            this.rol.Name = "rol";
            this.rol.Size = new System.Drawing.Size(239, 26);
            this.rol.TabIndex = 10;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(163, 186);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(239, 25);
            this.dateTimePicker1.TabIndex = 11;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 18);
            this.label1.TabIndex = 12;
            this.label1.Text = "Kullanıcı Adı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 18);
            this.label2.TabIndex = 13;
            this.label2.Text = "Sifre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 18);
            this.label3.TabIndex = 14;
            this.label3.Text = "Kayıt Tarihi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 245);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 18);
            this.label4.TabIndex = 15;
            this.label4.Text = "Role";
            // 
            // id
            // 
            this.id.Location = new System.Drawing.Point(163, 50);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(239, 25);
            this.id.TabIndex = 16;
            this.id.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(11, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 30);
            this.button1.TabIndex = 17;
            this.button1.Text = "GERİ DÖN";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // KasiyerEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(1208, 807);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.id);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.rol);
            this.Controls.Add(this.gnclle_btn);
            this.Controls.Add(this.btn_listele);
            this.Controls.Add(this.temizle_btn);
            this.Controls.Add(this.kaydet_btn);
            this.Controls.Add(this.sil_btn);
            this.Controls.Add(this.sifre);
            this.Controls.Add(this.kullanıcıadı);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "KasiyerEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KasiyerEkle";
            this.Load += new System.EventHandler(this.KasiyerEkle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kullanıcılartblBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cAFEDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox kullanıcıadı;
        private System.Windows.Forms.TextBox sifre;
        private System.Windows.Forms.Button sil_btn;
        private System.Windows.Forms.Button kaydet_btn;
        private System.Windows.Forms.Button temizle_btn;
        private System.Windows.Forms.Button btn_listele;
        private CAFEDataSet cAFEDataSet;
        private System.Windows.Forms.BindingSource kullanıcılartblBindingSource;
        private CAFEDataSetTableAdapters.Kullanıcılar_tblTableAdapter kullanıcılar_tblTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kullanıcıadıDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sifreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn verikaydıDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button gnclle_btn;
        private System.Windows.Forms.ComboBox rol;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox id;
        private System.Windows.Forms.Button button1;
    }
}