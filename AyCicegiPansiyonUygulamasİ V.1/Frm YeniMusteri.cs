﻿using System;
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
    public partial class Frm_YeniMusteri : Form
    {
        public Frm_YeniMusteri()
        {
            InitializeComponent();
        }
        SqlConnection Baglanti=new SqlConnection("Data Source=LENOVO\\SQLEXPRESS;Initial Catalog=\"Aycicegi Pansiyon\";Integrated Security=True;Encrypt=False");

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BtnOda101_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "101";
            Baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Oda101(Adi ,Soyadi)values('" + TxtAdi.Text+"','"+ TxtSoyadi.Text+"')",Baglanti);
            komut.ExecuteNonQuery();
            Baglanti.Close();
        }

        private void BtnOda102_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "102";
            Baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Oda102(Adi ,Soyadi)values('" + TxtAdi.Text + "','" + TxtSoyadi.Text + "')", Baglanti);
            komut.ExecuteNonQuery();
            Baglanti.Close();
        }

        private void BtnOda103_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "103";
            Baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Oda103 (Adi ,Soyadi) values('" + TxtAdi.Text + "','" + TxtSoyadi.Text + "')", Baglanti);
            komut.ExecuteNonQuery();
            Baglanti.Close();
        }

        private void BtnOda104_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "104";
            Baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Oda104(Adi ,Soyadi)values('" + TxtAdi.Text + "','" + TxtSoyadi.Text + "')", Baglanti);
            komut.ExecuteNonQuery();
            Baglanti.Close();
        }

        private void BtnOda105_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "105";
            Baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Oda105(Adi ,Soyadi)values('" + TxtAdi.Text + "','" + TxtSoyadi.Text + "')", Baglanti);
            komut.ExecuteNonQuery();
            Baglanti.Close();
        }

        private void BtnOda106_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "106";
            Baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Oda106(Adi ,Soyadi)values('" + TxtAdi.Text + "','" + TxtSoyadi.Text + "')", Baglanti);
            komut.ExecuteNonQuery();
            Baglanti.Close();
        }

        private void BtnOda107_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "107";
            Baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Oda107(Adi ,Soyadi)values('" + TxtAdi.Text + "','" + TxtSoyadi.Text + "')", Baglanti);
            komut.ExecuteNonQuery();
            Baglanti.Close();
        }

        private void BtnOda108_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "108";
            Baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Oda108(Adi ,Soyadi)values('" + TxtAdi.Text + "','" + TxtSoyadi.Text + "')", Baglanti);
            komut.ExecuteNonQuery();
            Baglanti.Close();
        }

        private void BtnOda109_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "109";
            Baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Oda109(Adi ,Soyadi)values('" + TxtAdi.Text + "','" + TxtSoyadi.Text + "')", Baglanti);
            komut.ExecuteNonQuery();
            Baglanti.Close();
        }

        private void BtnDoluOda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Kırmızı renkli butonlar dolu odaları gösterir");
        }

        private void BtnBosOda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Yeşil renkli butonlar boş  odaları gösterir");
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
           
            Baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into MusteriEkle(Ad,Soyad,Cinsiyet,Telefon ,Mail,TC,OdaNo,Ucret,GirisTarihi,CikisTarihi) values('" + TxtAdi.Text+"','"+TxtSoyadi.Text+"','"+comboBox1.Text+ "','" + MskTxtTelefon.Text + "','"  + TxtMail.Text + "','" + TxtKimlikNo.Text + "','" + TxtOdaNo.Text + "','" + TxtUcret.Text + "','" + DtpGirisTarihi.Value.ToString("yyyy-MM-dd") + "','" + DtpCikisTarihi.Value.ToString("yyyy-MM-dd") + "')",Baglanti);
            komut.ExecuteNonQuery();
            Baglanti.Close();
            MessageBox.Show("Müşteri kaydı yapıldı");
        }


        private void DtmCikisTarihi_ValueChanged(object sender, EventArgs e)
        {
            int Ucret;
            DateTime KucukTarih = Convert.ToDateTime(DtpGirisTarihi.Text);
            DateTime BuyukTarih = Convert.ToDateTime(DtpCikisTarihi.Text);
            TimeSpan sonuc;
            sonuc = BuyukTarih - KucukTarih;
            label11.Text = sonuc.TotalDays.ToString();
            Ucret = Convert.ToInt32(label11.Text) * 700;
            TxtUcret.Text = Ucret.ToString();
        }

        private void Frm_YeniMusteri_Load(object sender, EventArgs e)
        {
            Baglanti.Open();
            SqlCommand komut1 = new SqlCommand("select * from Oda101", Baglanti);
            SqlDataReader oku1 = komut1.ExecuteReader();

            while (oku1.Read())
            {
                BtnOda101.Text = oku1["Adi"].ToString() + " " + oku1["Soyadi"].ToString();


            }
            Baglanti.Close();
            if (BtnOda101.Text != "101")
            {
                BtnOda101.BackColor = Color.Red;
                BtnOda101.Enabled = false;
            }

            //****************************************************************************
            Baglanti.Open();
            SqlCommand komut2 = new SqlCommand("select * from Oda102", Baglanti);
            SqlDataReader oku2 = komut2.ExecuteReader();

            while (oku2.Read())
            {
                BtnOda102.Text = oku2["Adi"].ToString() + " " + oku2["Soyadi"].ToString();


            }
            Baglanti.Close();
            if (BtnOda102.Text != "102")
            {
                BtnOda102.BackColor = Color.Red;
                BtnOda102.Enabled = false;
            }


            //****************************************************************************
            Baglanti.Open();
            SqlCommand komut3 = new SqlCommand("select * from Oda103", Baglanti);
            SqlDataReader oku3 = komut3.ExecuteReader();

            while (oku3.Read())
            {
                BtnOda103.Text = oku3["Adi"].ToString() + " " + oku3["Soyadi"].ToString();


            }
            Baglanti.Close();
            if (BtnOda103.Text != "103")
            {
                BtnOda103.BackColor = Color.Red;
                BtnOda103.Enabled = false;
            }
           


            //****************************************************************************
            Baglanti.Open();
            SqlCommand komut4 = new SqlCommand("select * from Oda104", Baglanti);
            SqlDataReader oku4 = komut4.ExecuteReader();

            while (oku4.Read())
            {
                BtnOda104.Text = oku4["Adi"].ToString() + " " + oku4["Soyadi"].ToString();


            }
            Baglanti.Close();
            if (BtnOda104.Text != "104")
            {
                BtnOda104.BackColor = Color.Red;
                BtnOda104.Enabled = false;
            }
            //****************************************************************************
            Baglanti.Open();
            SqlCommand komut5 = new SqlCommand("select * from Oda105", Baglanti);
            SqlDataReader oku5 = komut5.ExecuteReader();

            while (oku5.Read())
            {
                BtnOda105.Text = oku5["Adi"].ToString() + " " + oku5["Soyadi"].ToString();


            }
            Baglanti.Close();
            if (BtnOda105.Text != "105")
            {
                BtnOda105.BackColor = Color.Red;
                BtnOda105.Enabled = false;
            }

            //****************************************************************************


            Baglanti.Open();
            SqlCommand komut6 = new SqlCommand("select * from Oda106", Baglanti);
            SqlDataReader oku6 = komut6.ExecuteReader();

            while (oku6.Read())
            {
                BtnOda106.Text = oku6["Adi"].ToString() + " " + oku6["Soyadi"].ToString();


            }
            Baglanti.Close();
            if (BtnOda106.Text != "106")
            {
                BtnOda106.BackColor = Color.Red;
                BtnOda106.Enabled = false;
            }


            //****************************************************************************
            Baglanti.Open();
            SqlCommand komut7 = new SqlCommand("select * from Oda107", Baglanti);
            SqlDataReader oku7 = komut7.ExecuteReader();

            while (oku7.Read())
            {
                BtnOda107.Text = oku7["Adı"].ToString() + " " + oku7["Soyadı"].ToString();


            }
            Baglanti.Close();
            if (BtnOda107.Text != "107")
            {
                BtnOda107.BackColor = Color.Red;
                BtnOda107.Enabled = false;
            }





            //****************************************************************************
            Baglanti.Open();
            SqlCommand komut8 = new SqlCommand("select * from Oda108", Baglanti);
            SqlDataReader oku8 = komut8.ExecuteReader();

            while (oku8.Read())
            {
                BtnOda108.Text = oku8["Adi"].ToString() + " " + oku8["Soyadi"].ToString();


            }
            Baglanti.Close();
            if (BtnOda108.Text != "108")
            {
                BtnOda108.BackColor = Color.Red;
                BtnOda108.Enabled = false;
            }


            //****************************************************************************

            Baglanti.Open();
            SqlCommand komut9 = new SqlCommand("select * from Oda109", Baglanti);
            SqlDataReader oku9 = komut9.ExecuteReader();

            while (oku9.Read())
            {
                BtnOda109.Text = oku9["Adi"].ToString() + " " + oku9["Soyadi"].ToString();


            }
            Baglanti.Close();
            if (BtnOda109.Text != "109")
            {
                BtnOda109.BackColor = Color.Red;
                BtnOda109.Enabled = false;
            }

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
//Data Source=LENOVO\SQLEXPRESS;Initial Catalog="Aycicegi Pansiyon";Integrated Security=True;Encrypt=False
