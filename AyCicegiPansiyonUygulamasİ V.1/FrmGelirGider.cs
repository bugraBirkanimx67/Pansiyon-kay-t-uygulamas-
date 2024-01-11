using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace AyCicegiPansiyonUygulamasİ_V._1
{
    public partial class FrmGelirGider : Form
    {
        public FrmGelirGider()
        {
            InitializeComponent();
        }
        SqlConnection Baglanti = new SqlConnection("Data Source=LENOVO\\SQLEXPRESS;Initial Catalog=\"Aycicegi Pansiyon\";Integrated Security=True;Encrypt=False");
        
        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int personel;



            personel = Convert.ToInt16(textBox1.Text);
            lblpersonelmaas.Text = (personel * 17000).ToString();

            int sonuc;
            sonuc = Convert.ToInt32(lblkasatoplam.Text) - (Convert.ToInt32(lblpersonelmaas.Text)+Convert.ToInt32(lblAlınanUrunTutarı1.Text) + Convert.ToInt32(lblAlınanUrunTutarı2.Text) + Convert.ToInt32(lblAlınanUrunTutarı3.Text) + Convert.ToInt32(lblfaturatoplam1.Text) + Convert.ToInt32(lblfaturatoplam2.Text) + Convert.ToInt32(lblfaturatoplam3.Text));
            lblsonuc.Text = sonuc.ToString();
        }

        private void FrmGelirGider_Load(object sender, EventArgs e)
        {//Kasadaki toplam tutar
            Baglanti.Open();
            SqlCommand komut = new SqlCommand(" select sum (Ucret) as toplam from MusteriEkle", Baglanti);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                lblkasatoplam.Text = oku["toplam"].ToString();
            }
            Baglanti.Close();

            //Gıdalar 

            Baglanti.Open();
            SqlCommand komut2 = new SqlCommand(" select sum (Gida) as toplam1 from Stoklar", Baglanti);
            SqlDataReader oku2= komut2.ExecuteReader();

            while (oku2.Read())
            {
               lblAlınanUrunTutarı1.Text = oku2["toplam1"].ToString();
            }
            Baglanti.Close();


            //içecekler
            Baglanti.Open();
            SqlCommand komut3 = new SqlCommand(" select sum (İcecek) as toplam2 from Stoklar", Baglanti);
            SqlDataReader oku3 = komut3.ExecuteReader();

            while (oku3.Read())
            {
               lblAlınanUrunTutarı2.Text = oku3["toplam2"].ToString();
            }
            Baglanti.Close();



            //Çerezler

            Baglanti.Open();
            SqlCommand komut4 = new SqlCommand(" select sum (Cerezler) as toplam3 from Stoklar", Baglanti);
            SqlDataReader oku4 = komut4.ExecuteReader();

            while (oku4.Read())
            {
                lblAlınanUrunTutarı3.Text = oku4["toplam3"].ToString();
            }
            Baglanti.Close();

            //elektrik

            Baglanti.Open();
            SqlCommand komut5 = new SqlCommand(" select sum (Elektrik) as toplam4 from Faturalar", Baglanti);
            SqlDataReader oku5 = komut5.ExecuteReader();

            while (oku5.Read())
            {
                lblfaturatoplam1.Text = oku5["toplam4"].ToString();
            }
            Baglanti.Close();


            //su
            Baglanti.Open();
            SqlCommand komut6 = new SqlCommand(" select sum (Su) as toplam5 from Faturalar", Baglanti);
            SqlDataReader oku6 = komut6.ExecuteReader();

            while (oku6.Read())
            {
               lblfaturatoplam2.Text = oku6["toplam5"].ToString();
            }
            Baglanti.Close();

            //internet
            Baglanti.Open();
            SqlCommand komut7= new SqlCommand(" select sum (İnternet) as toplam6 from Faturalar", Baglanti);
            SqlDataReader oku7 = komut7.ExecuteReader();

            while (oku7.Read())
            {
                lblfaturatoplam3.Text = oku7["toplam6"].ToString();
            }
            Baglanti.Close();


            int personel;



        }
    }
}
