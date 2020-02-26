using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace StokTakip
{
    public partial class UyeOl : Form
    {
        public UyeOl()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            SqlConnection baglanti;
            SqlCommand komut;
            SqlDataAdapter da;

            string KullaniciAdi = textBox1.Text;
            string Sifre = textBox2.Text;
            string TelefonNo = textBox4.Text;
            string Mail = textBox5.Text;
            string Meslek = comboBox1.Text;
            string CalistigiYer = comboBox2.Text;
            






            baglanti = new SqlConnection("server=MURATPC\\SQLEXPRESS; Initial Catalog=Stok_Takip;Integrated Security=SSPI");
            komut = new  SqlCommand();
            baglanti.Open();
            komut.Connection = baglanti;
            komut.CommandText= "Insert into tbl_KullaniciKayit (KullaniciAdi,Sifre,TelefonNo,Mail,Meslek,CalistigiYer) values (@KullaniciAdi,@Sifre,@TelefonNo,@Mail,@Meslek,@CalistigiYer)";
            komut.Parameters.AddWithValue("@KullaniciAdi", textBox1.Text);
            komut.Parameters.AddWithValue("@Sifre", textBox2.Text);
            komut.Parameters.AddWithValue("@TelefonNo", textBox4.Text);
            komut.Parameters.AddWithValue("@Mail", textBox5.Text);
            komut.Parameters.AddWithValue("@Meslek", comboBox1.Text);
            komut.Parameters.AddWithValue("@CalistigiYer", comboBox2.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kayıt İşlemi Gerçekleşti.");


        }
    }
}
