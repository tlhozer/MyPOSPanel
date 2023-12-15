using Hızlı_Satış.Classes;
using Hızlı_Satış.Forms.Stok;
using System.Windows.Forms;

namespace Hızlı_Satış.UControls.Stok
{
    public partial class YeniStokKarti : UserControl
    {
        private AppData _appData;

        public YeniStokKarti(AppData appData)
        {
            InitializeComponent();
            _appData = appData;
        }

        private void barkodlurunekle_Click(object sender, System.EventArgs e)
        {
            BarkodUrunEkleFrm barkodUrunEkleFrm = new BarkodUrunEkleFrm(_appData);
            barkodUrunEkleFrm.TopMost = true;
            barkodUrunEkleFrm.Show();
        }
    }
}