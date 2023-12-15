using System;
using System.Windows.Forms;

namespace Hızlı_Satış.Tools.Forms.MessageForms
{
    public partial class ErrorFrm : Form
    {
        public ErrorFrm(string baslik, string text)
        {
            InitializeComponent();
            basliktxt.Text = baslik;
            aciklamatxt.Text = text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void ErrorFrm_Load(object sender, EventArgs e)
        {
        }
    }
}