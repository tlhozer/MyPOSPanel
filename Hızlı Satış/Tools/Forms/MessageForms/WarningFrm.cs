using System;
using System.Windows.Forms;

namespace Hızlı_Satış.Tools.Forms.MessageForms
{
    public partial class WarningFrm : Form
    {
        public WarningFrm(string baslik, string text)
        {
            InitializeComponent();
            basliktxt.Text = baslik;
            aciklamatxt.Text = text;
        }

        private void WarningFrm_Load(object sender, EventArgs e)
        {
        }

        private void kapatbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}