using Hızlı_Satış.Classes;
using Hızlı_Satış.Engines;
using System;
using System.Windows.Forms;

namespace Hızlı_Satış.Forms.Stok
{
    public partial class BarkodUrunEkleFrm : Form
    {
        private AppData _appData;

        public BarkodUrunEkleFrm(AppData appData)
        {
            InitializeComponent();
            _appData = appData;
        }

        private void kapatbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void BarkodUrunEkleFrm_Load(object sender, EventArgs e)
        {
            FormEngine.BuildAndRun(this);
            firmalbl.Text = _appData.FirmaUnvan;
            userlbl.Text = _appData.Kullanici;
            urunbarkod.Focus();
        }
    }
}