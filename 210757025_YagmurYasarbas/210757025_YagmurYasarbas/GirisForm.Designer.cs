namespace _210757025_YagmurYasarbas
{
    partial class GirisForm
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GirisForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.kayıtadön = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cıkıs_giris = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.kullanıcıadı_giris = new System.Windows.Forms.TextBox();
            this.sifre_giris = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.giris = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.kayıtadön);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(259, 424);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(29, 46);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(199, 197);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // kayıtadön
            // 
            this.kayıtadön.BackColor = System.Drawing.Color.DodgerBlue;
            this.kayıtadön.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.kayıtadön.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kayıtadön.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.kayıtadön.Location = new System.Drawing.Point(29, 344);
            this.kayıtadön.Name = "kayıtadön";
            this.kayıtadön.Size = new System.Drawing.Size(174, 51);
            this.kayıtadön.TabIndex = 9;
            this.kayıtadön.Text = "Kayıt Ol";
            this.kayıtadön.UseVisualStyleBackColor = false;
            this.kayıtadön.Click += new System.EventHandler(this.kayıtadön_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(50, 312);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Hesabın Yok mu?";
            // 
            // cıkıs_giris
            // 
            this.cıkıs_giris.AutoSize = true;
            this.cıkıs_giris.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cıkıs_giris.Location = new System.Drawing.Point(523, 9);
            this.cıkıs_giris.Name = "cıkıs_giris";
            this.cıkıs_giris.Size = new System.Drawing.Size(33, 34);
            this.cıkıs_giris.TabIndex = 1;
            this.cıkıs_giris.Text = "X";
            this.cıkıs_giris.Click += new System.EventHandler(this.cıkıs_giris_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(285, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "Kullanıcı Adı";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // kullanıcıadı_giris
            // 
            this.kullanıcıadı_giris.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kullanıcıadı_giris.Location = new System.Drawing.Point(289, 179);
            this.kullanıcıadı_giris.Name = "kullanıcıadı_giris";
            this.kullanıcıadı_giris.Size = new System.Drawing.Size(253, 28);
            this.kullanıcıadı_giris.TabIndex = 4;
            this.kullanıcıadı_giris.TextChanged += new System.EventHandler(this.kullanıcıadı_giris_TextChanged);
            // 
            // sifre_giris
            // 
            this.sifre_giris.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sifre_giris.Location = new System.Drawing.Point(289, 256);
            this.sifre_giris.Name = "sifre_giris";
            this.sifre_giris.PasswordChar = '*';
            this.sifre_giris.Size = new System.Drawing.Size(253, 28);
            this.sifre_giris.TabIndex = 5;
            this.sifre_giris.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(295, 222);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 21);
            this.label4.TabIndex = 6;
            this.label4.Text = "Sifre";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(289, 305);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(129, 24);
            this.checkBox1.TabIndex = 7;
            this.checkBox1.Text = "Şifre Göster";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // giris
            // 
            this.giris.BackColor = System.Drawing.Color.DodgerBlue;
            this.giris.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.giris.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.giris.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.giris.Location = new System.Drawing.Point(289, 335);
            this.giris.Name = "giris";
            this.giris.Size = new System.Drawing.Size(174, 51);
            this.giris.TabIndex = 8;
            this.giris.Text = "Giris";
            this.giris.UseVisualStyleBackColor = false;
            this.giris.Click += new System.EventHandler(this.giris_Click);
            // 
            // GirisForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 424);
            this.Controls.Add(this.giris);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.sifre_giris);
            this.Controls.Add(this.kullanıcıadı_giris);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cıkıs_giris);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.DodgerBlue;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GirisForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GirisForm";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label cıkıs_giris;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox kullanıcıadı_giris;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button kayıtadön;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox sifre_giris;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button giris;
    }
}

