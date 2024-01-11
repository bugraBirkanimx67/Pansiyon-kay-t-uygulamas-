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
    public partial class FrmGazeteler : Form
    {
        public FrmGazeteler()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate ("https://www.hurriyet.com.tr/");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.milliyet.com.tr/");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.sozcu.com.tr/");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.haberturk.com/");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.fanatik.com.tr/");
        }

        private void btnOnedio_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://onedio.com/");
        }
    }
}
