namespace _210757025_YagmurYasarbas
{
    partial class AdminForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminForm));
            this.cikisbuton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.İstatistikler = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.KasiyerEkle = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cikisbuton
            // 
            this.cikisbuton.Location = new System.Drawing.Point(558, 708);
            this.cikisbuton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cikisbuton.Name = "cikisbuton";
            this.cikisbuton.Size = new System.Drawing.Size(240, 97);
            this.cikisbuton.TabIndex = 17;
            this.cikisbuton.Text = "Çıkış Yap";
            this.cikisbuton.UseVisualStyleBackColor = true;
            this.cikisbuton.Click += new System.EventHandler(this.cikisbuton_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(514, 14);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(284, 270);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // İstatistikler
            // 
            this.İstatistikler.Image = ((System.Drawing.Image)(resources.GetObject("İstatistikler.Image")));
            this.İstatistikler.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.İstatistikler.Location = new System.Drawing.Point(409, 325);
            this.İstatistikler.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.İstatistikler.Name = "İstatistikler";
            this.İstatistikler.Size = new System.Drawing.Size(227, 148);
            this.İstatistikler.TabIndex = 13;
            this.İstatistikler.Text = "İstatistikler";
            this.İstatistikler.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.İstatistikler.UseVisualStyleBackColor = true;
            this.İstatistikler.Click += new System.EventHandler(this.GöstergePaneli_Click);
            // 
            // button4
            // 
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button4.Location = new System.Drawing.Point(416, 518);
            this.button4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(220, 148);
            this.button4.TabIndex = 16;
            this.button4.Text = "Müşteriler";
            this.button4.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // KasiyerEkle
            // 
            this.KasiyerEkle.Image = ((System.Drawing.Image)(resources.GetObject("KasiyerEkle.Image")));
            this.KasiyerEkle.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.KasiyerEkle.Location = new System.Drawing.Point(715, 325);
            this.KasiyerEkle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.KasiyerEkle.Name = "KasiyerEkle";
            this.KasiyerEkle.Size = new System.Drawing.Size(220, 148);
            this.KasiyerEkle.TabIndex = 14;
            this.KasiyerEkle.Text = "Kasiyer Ekle";
            this.KasiyerEkle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.KasiyerEkle.UseVisualStyleBackColor = true;
            this.KasiyerEkle.Click += new System.EventHandler(this.KasiyerEkle_Click);
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.Location = new System.Drawing.Point(715, 518);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(220, 148);
            this.button1.TabIndex = 18;
            this.button1.Text = "Stoklar";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(1318, 834);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cikisbuton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.İstatistikler);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.KasiyerEkle);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "AdminForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminForm";
            this.Load += new System.EventHandler(this.AdminForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cikisbuton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button İstatistikler;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button KasiyerEkle;
        private System.Windows.Forms.Button button1;
    }
}