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
    public partial class FrmMusteriler : Form
    {
        public FrmMusteriler()
        {
            InitializeComponent();
        }
        SqlConnection Baglanti = new SqlConnection(" Data Source = LENOVO\\SQLEXPRESS;Initial Catalog = \"Aycicegi Pansiyon\"; Integrated Security = True; Encrypt=False");

        private void Verilerigoster()
        {
            Baglanti.Open();
            SqlCommand komut = new SqlCommand("select *from MusteriEkle",Baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["id"].ToString();
                ekle.SubItems.Add(oku["Ad"].ToString());
                ekle.SubItems.Add(oku["Soyad"].ToString());
                ekle.SubItems.Add(oku["Cinsiyet"].ToString());
                ekle.SubItems.Add(oku["Telefon"].ToString());
                ekle.SubItems.Add(oku["Mail"].ToString());
                ekle.SubItems.Add(oku["TC"].ToString());
                ekle.SubItems.Add(oku["OdaNo"].ToString());
                ekle.SubItems.Add(oku["Ucret"].ToString());
                ekle.SubItems.Add(oku["GirisTarihi"].ToString());
                ekle.SubItems.Add(oku["CikisTarihi"].ToString());
             listView1.Items.Add(ekle);

            }
            Baglanti.Close(); 
        }


       

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {

        }
        int id = 0;
        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            id = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            TxtAdi.Text =(listView1.SelectedItems[0].SubItems[1].Text);
            TxtSoyadi.Text= (listView1.SelectedItems[0].SubItems[2].Text);
            comboBox1.Text = (listView1.SelectedItems[0].SubItems[3].Text);
            MskTxtTelefon.Text = (listView1.SelectedItems[0].SubItems[4].Text);
            TxtMail.Text= (listView1.SelectedItems[0].SubItems[5].Text);
             TxtKimlikNo.Text =(listView1.SelectedItems[0].SubItems[6].Text);
            TxtOdaNo.Text = (listView1.SelectedItems[0].SubItems[7].Text);
            TxtUcret.Text =(listView1.SelectedItems[0].SubItems[8].Text);
            DtpGirisTarihi.Text= (listView1.SelectedItems[0].SubItems[9].Text);
            DtpCikisTarihi.Text = (listView1.SelectedItems[0].SubItems[10].Text);

        }

        private void BtnVerileriGoster_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            Verilerigoster();
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            if (TxtOdaNo.Text == "101")
            {
                listView1.Items.Clear();
                Baglanti.Open();
                SqlCommand komut = new SqlCommand("Delete from Oda101 ", Baglanti);
                komut.ExecuteNonQuery();
                Baglanti.Close();
                Verilerigoster();
            }


            if (TxtOdaNo.Text == "102")
            {
                listView1.Items.Clear();
                Baglanti.Open();
                SqlCommand komut = new SqlCommand("Delete from Oda102 ", Baglanti);
                komut.ExecuteNonQuery();
                Baglanti.Close();
                Verilerigoster();
            }


            if (TxtOdaNo.Text == "103")
            {
                listView1.Items.Clear();
                Baglanti.Open();
                SqlCommand komut = new SqlCommand("Delete from Oda103 ", Baglanti);
                komut.ExecuteNonQuery();
                Baglanti.Close();
                Verilerigoster();
            }


            if (TxtOdaNo.Text == "104")
            {
                listView1.Items.Clear();
                Baglanti.Open();
                SqlCommand komut = new SqlCommand("Delete from Oda104 ", Baglanti);
                komut.ExecuteNonQuery();
                Baglanti.Close();
                Verilerigoster();
            }

            if (TxtOdaNo.Text == "105")
            {
                listView1.Items.Clear();
                Baglanti.Open();
                SqlCommand komut = new SqlCommand("Delete from Oda105 ", Baglanti);
                komut.ExecuteNonQuery();
                Baglanti.Close();
                Verilerigoster();
            }


            if (TxtOdaNo.Text == "106")
            {
                listView1.Items.Clear();
                Baglanti.Open();
                SqlCommand komut = new SqlCommand("Delete from Oda106 ", Baglanti);
                komut.ExecuteNonQuery();
                Baglanti.Close();
                Verilerigoster();
            }

            if (TxtOdaNo.Text == "107")
            {
                listView1.Items.Clear();
                Baglanti.Open();
                SqlCommand komut = new SqlCommand("Delete from Oda107 ", Baglanti);
                komut.ExecuteNonQuery();
                Baglanti.Close();
                Verilerigoster();
            }


            if (TxtOdaNo.Text == "108")
            {
                listView1.Items.Clear();
                Baglanti.Open();
                SqlCommand komut = new SqlCommand("Delete from Oda108 ", Baglanti);
                komut.ExecuteNonQuery();
                Baglanti.Close();
                Verilerigoster();
            }


            if (TxtOdaNo.Text == "109")
            {
                listView1.Items.Clear();
                Baglanti.Open();
                SqlCommand komut = new SqlCommand("Delete from Oda109 ", Baglanti);
                komut.ExecuteNonQuery();
                Baglanti.Close();
                Verilerigoster();
            }




        }

        private void BtnTemizle_Click(object sender, EventArgs e)
        {
            TxtAdi.Clear();
            TxtSoyadi.Clear();
            comboBox1.Text = "";
            MskTxtTelefon.Clear();
            TxtMail.Clear();
            TxtKimlikNo.Clear();
            TxtOdaNo.Clear();
            TxtUcret.Clear();
            DtpGirisTarihi.Text = "";
            DtpCikisTarihi.Text = "";

        }

        private void FrmMusteriler_Load(object sender, EventArgs e)
        {

        }

        private void BtnGüncelle_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            Baglanti.Open();
            SqlCommand komut = new SqlCommand("update MusteriEkle set Ad='" + TxtAdi.Text + "',Soyad='" + TxtSoyadi.Text+"',Cinsiyet='"+comboBox1.Text+"',Telefon='"+MskTxtTelefon.Text+"',Mail='"+TxtMail.Text+"',TC='"+TxtKimlikNo.Text+"',OdaNo='"+TxtOdaNo.Text+"',Ucret='"+TxtUcret.Text+"',GirisTarihi='" + DtpGirisTarihi.Value.ToString("yyyy-MM-dd") + "',CikisTarihi='"+ DtpCikisTarihi.Value.ToString("yyyy-MM-dd") + "'where id="+id+"",Baglanti);
            komut.ExecuteNonQuery();
            Baglanti.Close();
            Verilerigoster();
        }

        private void BtnAra_Click(object sender, EventArgs e)
        {
            Baglanti.Open();
            SqlCommand komut = new SqlCommand("select *from MusteriEkle where Ad like '%"+textBox1.Text+"%'", Baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["id"].ToString();
                ekle.SubItems.Add(oku["Ad"].ToString());
                ekle.SubItems.Add(oku["Soyad"].ToString());
                ekle.SubItems.Add(oku["Cinsiyet"].ToString());
                ekle.SubItems.Add(oku["Telefon"].ToString());
                ekle.SubItems.Add(oku["Mail"].ToString());
                ekle.SubItems.Add(oku["TC"].ToString());
                ekle.SubItems.Add(oku["OdaNo"].ToString());
                ekle.SubItems.Add(oku["Ucret"].ToString());
                ekle.SubItems.Add(oku["GirisTarihi"].ToString());
                ekle.SubItems.Add(oku["CikisTarihi"].ToString());
                listView1.Items.Add(ekle);

            }
            Baglanti.Close();
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }
    }
}
// Data Source = LENOVO\SQLEXPRESS;Initial Catalog = "Aycicegi Pansiyon"; Integrated Security = True; Encrypt=False
//SqlCommand komut = new SqlCommand("Delete from MusteriEkle where id=(" + id + ")", Baglanti);
