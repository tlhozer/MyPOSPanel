using Guna.UI2.WinForms;
using Hızlı_Satış.Classes;
using Hızlı_Satış.Engines;
using Hızlı_Satış.UControls.Rapor;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Hızlı_Satış.Forms.Main
{
    public partial class RaporFrm : Form
    {
        private AppData _appData;

        public RaporFrm(AppData appData)
        {
            InitializeComponent();
            _appData = appData;
        }

        private object previousSender;
        private string page = "";

        private void kapatbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void raporclick_Click(object sender, EventArgs e)
        {
            if (page == "rapor")
            {
            }
            else
            {
                PanelTemizle(sender);
                Rapor rapor = new Rapor();
                rapor.Size = new Size(panel.Size.Width, panel.Size.Height);
                panel.Controls.Add(rapor);
                btnaktiflestir(sender);
                page = "rapor";
            }
        }

        private void PanelTemizle(object sender)
        {
            panel.Controls.Clear();
            Guna2TileButton tiklanan = sender as Guna2TileButton;
            tiklanan.ForeColor = Color.White;

            if (previousSender != null)
            {
                Guna2TileButton oncekitiklanan = previousSender as Guna2TileButton;
                oncekitiklanan.FillColor = Color.FromArgb(47, 54, 64);
                oncekitiklanan.ForeColor = Color.White;
            }
            previousSender = sender;
        }

        private void btnaktiflestir(object sender)
        {
            Guna2TileButton tiklanan = sender as Guna2TileButton;
            tiklanan.FillColor = SystemColors.Window;
            tiklanan.ForeColor = Color.Black;
        }

        private void RaporFrm_Load(object sender, EventArgs e)
        {
            FormEngine.BuildAndRun(this);
            raporclick.PerformClick();
            firmalbl.Text = _appData.FirmaUnvan;
            userlbl.Text = _appData.Kullanici;
        }
    }
}