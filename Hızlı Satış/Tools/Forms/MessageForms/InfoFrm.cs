using System;
using System.Windows.Forms;

namespace Hızlı_Satış.Tools.Forms.MessageForms
{
    public partial class InfoFrm : Form
    {
        public InfoFrm(string baslik, string text)
        {
            InitializeComponent();
            basliktxt.Text = baslik;
            aciklamatxt.Text = text;
        }

        private void InfoFrm_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private int sayi = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (sayi > 1)
            {
                timer1.Stop();
                this.Hide();
            }
            else
            {
                sayi++;
            }
        }
    }
}