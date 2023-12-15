using Guna.UI2.WinForms;
using Hızlı_Satış.Classes;
using Hızlı_Satış.Engines;
using Hızlı_Satış.UControls.BelgeDizayn;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Hızlı_Satış.Forms.Main
{
    public partial class BelgeDizaynFrm : Form
    {
        private AppData _appData;

        public BelgeDizaynFrm(AppData appData)
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

        private void BelgeDizaynFrm_Load(object sender, EventArgs e)
        {
            FormEngine.BuildAndRun(this);
            belgedizayn.PerformClick();
            firmalbl.Text = _appData.FirmaUnvan;
            userlbl.Text = _appData.Kullanici;
        }

        private void belgedizayn_Click(object sender, EventArgs e)
        {
            if (page == "belgedizayn")
            {
            }
            else
            {
                PanelTemizle(sender);
                BelgeDizayn belgeDizayn = new BelgeDizayn();
                belgeDizayn.Size = new Size(panel.Size.Width, panel.Size.Height);
                panel.Controls.Add(belgeDizayn);
                btnaktiflestir(sender);
                page = "belgedizayn";
            }
        }
    }
}