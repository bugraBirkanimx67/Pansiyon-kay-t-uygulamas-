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
    public partial class FrmMesajlar : Form
    {
        public FrmMesajlar()
        {
            InitializeComponent();
        }
      
          SqlConnection Baglanti = new SqlConnection("Data Source=LENOVO\\SQLEXPRESS;Initial Catalog=\"Aycicegi Pansiyon\";Integrated Security=True;Encrypt=False");

        private void Verilerigoster()

        {
            Baglanti.Open();
            SqlCommand komut = new SqlCommand("select *from Mesaj", Baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["Mesajid"].ToString();
                ekle.SubItems.Add(oku["AdSoyad"].ToString());
                ekle.SubItems.Add(oku["Mesaj"].ToString());
            
                listView1.Items.Add(ekle);

            }
            Baglanti.Close();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            Baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Mesaj(AdSoyad,Mesaj) values('" + TxtAdSoyad.Text + "','" + richTextBox1.Text + "')", Baglanti);
            komut.ExecuteNonQuery();
            Baglanti.Close();

            Verilerigoster();
            MessageBox.Show("Mesajınız başarı ile kaydedildi otelimiz iyi günler diler :)");
        }

        private void FrmMesajlar_Load(object sender, EventArgs e)
        {
            Verilerigoster();
        }

        private void richTextBox1_DoubleClick(object sender, EventArgs e)
        {




        }

        int id= 0;
        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            id = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            TxtAdSoyad.Text = listView1.SelectedItems[0].SubItems[1].Text;
            richTextBox1.Text = listView1.SelectedItems[0].SubItems[2].Text;
        }
    }
}
