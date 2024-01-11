using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AyCicegiPansiyonUygulamasİ_V._1
{
    public partial class FrmAnaForm : Form
    {
        public FrmAnaForm()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmOdalar fr = new FrmOdalar();
            fr.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmAdminGiris fr = new FrmAdminGiris();
            fr.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
         Frm_YeniMusteri fr=new Frm_YeniMusteri();
            fr.Show();
            this.Hide();
        }

        private void BtnMusteriler_Click(object sender, EventArgs e)
        {
            FrmMusteriler frm = new FrmMusteriler();
            frm.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ayçiçeği pansiyon uygulamasına hoşgeldiniz /Tirebolu Giresun ");
        }

        private void FrmAnaForm_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToLongDateString();
            label2.Text = DateTime.Now.ToLongTimeString();

        }

        private void Btncikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FrmGelirGider fr = new FrmGelirGider();
            fr.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FrmStoklar fr=new FrmStoklar();
            fr.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            FrmRadioDinle2 fr=new FrmRadioDinle2();
            fr.Show();
        }

        private void Btngazateler_Click(object sender, EventArgs e)
        {
            FrmGazeteler fr=new FrmGazeteler();
            fr.Show();
        }

        private void btnsifreGüncelle_Click(object sender, EventArgs e)
        {
            FrmSifreGuncelle fr=new FrmSifreGuncelle();
            fr.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FrmMesajlar fr=new FrmMesajlar();
            fr.Show();
        }
    }
}
