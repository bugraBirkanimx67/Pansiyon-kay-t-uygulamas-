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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AyCicegiPansiyonUygulamasİ_V._1
{
    public partial class FrmSifreGuncelle : Form
    {
        public FrmSifreGuncelle()
        {
            InitializeComponent();
        }
        SqlConnection Baglanti = new SqlConnection("Data Source=LENOVO\\SQLEXPRESS;Initial Catalog=\"Aycicegi Pansiyon\";Integrated Security=True;Encrypt=False");

        private void BtnGirisYap_Click(object sender, EventArgs e)
        {
          
            Baglanti.Open();
            SqlCommand komut = new SqlCommand("update AdminGiris set Kullanici='" + TxtKullaniciAdi.Text + "',Sifre='" + TxtSifre.Text + "'", Baglanti);
            komut.ExecuteNonQuery();
            Baglanti.Close();
           

        }
    }
}
