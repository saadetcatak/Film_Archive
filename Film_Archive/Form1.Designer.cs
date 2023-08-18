namespace Film_Archive
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.GbFilmListe = new System.Windows.Forms.GroupBox();
            this.GbEkran = new System.Windows.Forms.GroupBox();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.GbYeniListe = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtAd = new System.Windows.Forms.TextBox();
            this.TxtKategori = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtLink = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnKaydet = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.BtnTamEkran = new System.Windows.Forms.Button();
            this.BtnHakkımızda = new System.Windows.Forms.Button();
            this.BtnRenk = new System.Windows.Forms.Button();
            this.BtnCıkıs = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.GbFilmListe.SuspendLayout();
            this.GbEkran.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.GbYeniListe.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 3);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1233, 100);
            this.panel1.TabIndex = 0;
            // 
            // GbFilmListe
            // 
            this.GbFilmListe.Controls.Add(this.dataGridView1);
            this.GbFilmListe.Location = new System.Drawing.Point(266, 109);
            this.GbFilmListe.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.GbFilmListe.Name = "GbFilmListe";
            this.GbFilmListe.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.GbFilmListe.Size = new System.Drawing.Size(254, 638);
            this.GbFilmListe.TabIndex = 0;
            this.GbFilmListe.TabStop = false;
            this.GbFilmListe.Text = "Film Listesi";
            // 
            // GbEkran
            // 
            this.GbEkran.Controls.Add(this.webBrowser1);
            this.GbEkran.Location = new System.Drawing.Point(528, 109);
            this.GbEkran.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.GbEkran.Name = "GbEkran";
            this.GbEkran.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.GbEkran.Size = new System.Drawing.Size(747, 638);
            this.GbEkran.TabIndex = 1;
            this.GbEkran.TabStop = false;
            this.GbEkran.Text = "Ekran";
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(4, 26);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(739, 609);
            this.webBrowser1.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1099, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(125, 91);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // GbYeniListe
            // 
            this.GbYeniListe.Controls.Add(this.groupBox4);
            this.GbYeniListe.Controls.Add(this.BtnKaydet);
            this.GbYeniListe.Controls.Add(this.TxtLink);
            this.GbYeniListe.Controls.Add(this.label4);
            this.GbYeniListe.Controls.Add(this.TxtKategori);
            this.GbYeniListe.Controls.Add(this.label3);
            this.GbYeniListe.Controls.Add(this.TxtAd);
            this.GbYeniListe.Controls.Add(this.label2);
            this.GbYeniListe.Location = new System.Drawing.Point(5, 109);
            this.GbYeniListe.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.GbYeniListe.Name = "GbYeniListe";
            this.GbYeniListe.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.GbYeniListe.Size = new System.Drawing.Size(253, 638);
            this.GbYeniListe.TabIndex = 1;
            this.GbYeniListe.TabStop = false;
            this.GbYeniListe.Text = "Yeni Listesi";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("MV Boli", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label1.Location = new System.Drawing.Point(49, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(400, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sinema Koltuk Yazılım";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Film Ad:";
            // 
            // TxtAd
            // 
            this.TxtAd.Location = new System.Drawing.Point(100, 135);
            this.TxtAd.Name = "TxtAd";
            this.TxtAd.Size = new System.Drawing.Size(146, 30);
            this.TxtAd.TabIndex = 2;
            // 
            // TxtKategori
            // 
            this.TxtKategori.Location = new System.Drawing.Point(100, 186);
            this.TxtKategori.Name = "TxtKategori";
            this.TxtKategori.Size = new System.Drawing.Size(146, 30);
            this.TxtKategori.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Kategori:";
            // 
            // TxtLink
            // 
            this.TxtLink.Location = new System.Drawing.Point(100, 232);
            this.TxtLink.Name = "TxtLink";
            this.TxtLink.Size = new System.Drawing.Size(146, 30);
            this.TxtLink.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 237);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "Link:";
            // 
            // BtnKaydet
            // 
            this.BtnKaydet.Location = new System.Drawing.Point(100, 283);
            this.BtnKaydet.Name = "BtnKaydet";
            this.BtnKaydet.Size = new System.Drawing.Size(146, 35);
            this.BtnKaydet.TabIndex = 7;
            this.BtnKaydet.Text = "Kaydet";
            this.BtnKaydet.UseVisualStyleBackColor = true;
            this.BtnKaydet.Click += new System.EventHandler(this.BtnKaydet_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.BtnCıkıs);
            this.groupBox4.Controls.Add(this.BtnRenk);
            this.groupBox4.Controls.Add(this.BtnHakkımızda);
            this.groupBox4.Controls.Add(this.BtnTamEkran);
            this.groupBox4.Location = new System.Drawing.Point(7, 372);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(239, 259);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "İşlemler";
            // 
            // BtnTamEkran
            // 
            this.BtnTamEkran.Location = new System.Drawing.Point(19, 39);
            this.BtnTamEkran.Name = "BtnTamEkran";
            this.BtnTamEkran.Size = new System.Drawing.Size(197, 35);
            this.BtnTamEkran.TabIndex = 8;
            this.BtnTamEkran.Text = "Tam Ekran";
            this.BtnTamEkran.UseVisualStyleBackColor = true;
            this.BtnTamEkran.Click += new System.EventHandler(this.BtnTamEkran_Click);
            // 
            // BtnHakkımızda
            // 
            this.BtnHakkımızda.Location = new System.Drawing.Point(19, 96);
            this.BtnHakkımızda.Name = "BtnHakkımızda";
            this.BtnHakkımızda.Size = new System.Drawing.Size(197, 35);
            this.BtnHakkımızda.TabIndex = 9;
            this.BtnHakkımızda.Text = "Hakkımızda";
            this.BtnHakkımızda.UseVisualStyleBackColor = true;
            this.BtnHakkımızda.Click += new System.EventHandler(this.BtnHakkımızda_Click);
            // 
            // BtnRenk
            // 
            this.BtnRenk.Location = new System.Drawing.Point(19, 151);
            this.BtnRenk.Name = "BtnRenk";
            this.BtnRenk.Size = new System.Drawing.Size(197, 35);
            this.BtnRenk.TabIndex = 10;
            this.BtnRenk.Text = "Renk Değiştir";
            this.BtnRenk.UseVisualStyleBackColor = true;
            this.BtnRenk.Click += new System.EventHandler(this.BtnRenk_Click);
            // 
            // BtnCıkıs
            // 
            this.BtnCıkıs.Location = new System.Drawing.Point(19, 209);
            this.BtnCıkıs.Name = "BtnCıkıs";
            this.BtnCıkıs.Size = new System.Drawing.Size(197, 35);
            this.BtnCıkıs.TabIndex = 11;
            this.BtnCıkıs.Text = "Çıkış";
            this.BtnCıkıs.UseVisualStyleBackColor = true;
            this.BtnCıkıs.Click += new System.EventHandler(this.BtnCıkıs_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(4, 26);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(246, 609);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.Color.Olive;
            this.ClientSize = new System.Drawing.Size(1279, 752);
            this.Controls.Add(this.GbYeniListe);
            this.Controls.Add(this.GbEkran);
            this.Controls.Add(this.GbFilmListe);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.GbFilmListe.ResumeLayout(false);
            this.GbEkran.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.GbYeniListe.ResumeLayout(false);
            this.GbYeniListe.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox GbFilmListe;
        private System.Windows.Forms.GroupBox GbEkran;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.GroupBox GbYeniListe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtLink;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtKategori;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtAd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnKaydet;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button BtnRenk;
        private System.Windows.Forms.Button BtnHakkımızda;
        private System.Windows.Forms.Button BtnTamEkran;
        private System.Windows.Forms.Button BtnCıkıs;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

