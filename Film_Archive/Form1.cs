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

namespace Film_Archive
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection("Data Source=SAADET\\SQLEXPRESS01;Initial Catalog=DbFilmArsivi;Integrated Security=True");

        void filmler()
        {
            SqlDataAdapter adapter = new SqlDataAdapter("Select*from TblFilmler",connection);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource= dt;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            filmler();
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            if (TxtAd.Text != "" && TxtKategori.Text != "" && TxtLink.Text != "") 
            { 

            connection.Open();
            SqlCommand command = new SqlCommand("Insert into TblFilmler (Ad,Kategori,Link) values (@p1,@p2,@p3)",connection);
            command.Parameters.AddWithValue("@p1", TxtAd.Text);
            command.Parameters.AddWithValue("@p2", TxtKategori.Text);
            command.Parameters.AddWithValue("@p3", TxtLink.Text);
            command.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Film listenize kaydedildi.", "Kaydet", MessageBoxButtons.OK, MessageBoxIcon.Information);
            filmler();

            }

             else
            {
                MessageBox.Show("Film ismi, kategorisi veya linki boş bırakılamaz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int choose = dataGridView1.SelectedCells[0].RowIndex;
            string link = dataGridView1.Rows[choose].Cells[3].Value.ToString();
            webBrowser1.Navigate(link);

        }

        private void BtnHakkımızda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bu proje Saadet Çatak Akgüneş tarafından 18.08.2023 tarihinde geliştirildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnCıkıs_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnTamEkran_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            GbYeniListe.Visible = false;
            GbFilmListe.Visible = false;
            GbEkran.Dock = DockStyle.Fill;
            this.WindowState = FormWindowState.Maximized;
        }

        private void BtnRenk_Click(object sender, EventArgs e)
        {
            System.Drawing.Color[] renkler = {Color.Brown, Color.Red, Color.Green,Color.Blue,Color.BlueViolet,Color.DarkGreen,Color.DarkOliveGreen,Color.FloralWhite};
            Random rnd=new Random();
            int sayi=rnd.Next(renkler.Length);
            this.BackColor= renkler[sayi];

        }
    }
}
