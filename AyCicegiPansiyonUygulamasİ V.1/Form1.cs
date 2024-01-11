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
using System.Data.Common;

namespace AyCicegiPansiyonUygulamasİ_V._1
{
    public partial class FrmAdminGiris : Form
    {
        public FrmAdminGiris()
        {
            InitializeComponent();
        }
        SqlConnection Baglanti=new SqlConnection("Data Source=LENOVO\\SQLEXPRESS;Initial Catalog=\"Aycicegi Pansiyon\";Integrated Security=True;Encrypt=False");
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnGirisYap_Click(object sender, EventArgs e)
        {
            try
            {
                Baglanti.Open();
                string SQL = "select *from AdminGiris where Kullanici=@KulLaniciadi AND Sifre=@Sifresi";
                SqlParameter prm1 = new SqlParameter("Kullaniciadi", TxtKullaniciAdi.Text);
                SqlParameter prm2 = new SqlParameter("Sifresi", TxtSifre.Text);
                SqlCommand komut = new SqlCommand(SQL,Baglanti);
                komut.Parameters.Add(prm1);
                komut.Parameters.Add(prm2);
               DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(komut);
                da.Fill(dt);

                if (dt.Rows.Count>0)
                {
                    FrmAnaForm frm = new FrmAnaForm();
                    frm.Show();
                    this.Hide();    
                    
                }

            }
            catch (Exception)
            {

                MessageBox.Show("HATALI GİRİŞ ");
            }
         

        }

        private void TxtKullaniciAdi_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
