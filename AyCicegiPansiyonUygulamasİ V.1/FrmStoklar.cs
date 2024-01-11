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
    public partial class FrmStoklar : Form
    {
        public FrmStoklar()
        {
            InitializeComponent();
        }
        SqlConnection Baglanti = new SqlConnection("Data Source=LENOVO\\SQLEXPRESS;Initial Catalog=\"Aycicegi Pansiyon\";Integrated Security=True;Encrypt=False");
        private void veriler()
        {
            listView1.Items.Clear();

            Baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from Stoklar", Baglanti);
            SqlDataReader oku= komut.ExecuteReader();

            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["Gida"].ToString();
                ekle.SubItems.Add (oku["İcecek"].ToString());
                ekle.SubItems.Add(oku["Cerezler"].ToString());
                listView1.Items.Add(ekle);
            }
            Baglanti.Close();
        }
        private void veriler2()
        {
            listView2.Items.Clear();

            Baglanti.Open();
            SqlCommand komut2 = new SqlCommand("select * from Faturalar", Baglanti);
            SqlDataReader oku2 = komut2.ExecuteReader();

            while (oku2.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku2["Elektrik"].ToString();
                ekle.SubItems.Add(oku2["Su"].ToString());
                ekle.SubItems.Add(oku2["İnternet"].ToString());
                listView2.Items.Add(ekle);
            }
            Baglanti.Close();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            Baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Stoklar(Gida,İcecek,Cerezler) values('" + txtgidalar.Text + "','" + txticecekler.Text + "','" + txtcerez.Text+"')",Baglanti);
            komut.ExecuteNonQuery();
            Baglanti.Close() ;
            veriler();
        }

        private void FrmStoklar_Load(object sender, EventArgs e)
        {
            veriler();
            veriler2();
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void btnKaydet_Click_1(object sender, EventArgs e)
        {

        }

        private void BtnKaydet2_Click(object sender, EventArgs e)
        {
            Baglanti.Open();
            SqlCommand komut2 = new SqlCommand("insert into Faturalar(Elektrik,Su,İnternet) values('" +txtelektrik.Text + "','" +txtsu.Text + "','" + txticecekler.Text + "')", Baglanti);
            komut2.ExecuteNonQuery();
            Baglanti.Close();
            veriler2();
        }
    }
}
