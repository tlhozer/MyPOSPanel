using Hızlı_Satış.Classes;
using Hızlı_Satış.Forms.Stok;
using System;
using System.Windows.Forms;

namespace Hızlı_Satış.UControls.Shotrcuts
{
    public partial class ShortYeniUrunEkle : UserControl
    {
        private AppData _appData;

        public ShortYeniUrunEkle(AppData appData)
        {
            InitializeComponent();
            _appData = appData;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            BarkodUrunEkleFrm barkodUrunEkleFrm = new BarkodUrunEkleFrm(_appData);
            barkodUrunEkleFrm.ShowDialog();
        }
    }
}