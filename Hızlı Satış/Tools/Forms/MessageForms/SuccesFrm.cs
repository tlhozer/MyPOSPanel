using System;
using System.Windows.Forms;

namespace Hızlı_Satış.Tools.Forms.MessageForms
{
    public partial class SuccesFrm : Form
    {
        public SuccesFrm(string baslik, string aciklama)
        {
            InitializeComponent();
            basliktxt.Text = baslik;
            aciklamatxt.Text = aciklama;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void SuccesFrm_Load(object sender, EventArgs e)
        {
        }
    }
}