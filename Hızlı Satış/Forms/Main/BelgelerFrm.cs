using Guna.UI2.WinForms;
using Hızlı_Satış.Classes;
using Hızlı_Satış.Engines;
using Hızlı_Satış.UControls.Belgeler;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Hızlı_Satış.Forms.Main
{
    public partial class BelgelerFrm : Form
    {
        private AppData _appData;

        public BelgelerFrm(AppData appData)
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

        private void belgelerclick_Click(object sender, EventArgs e)
        {
            if (page == "belgeler")
            {
            }
            else
            {
                PanelTemizle(sender);
                Belgeler belgeler = new Belgeler();
                belgeler.Size = new Size(panel.Size.Width, panel.Size.Height);
                panel.Controls.Add(belgeler);
                btnaktiflestir(sender);
                page = "belgeler";
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

        private void BelgelerFrm_Load(object sender, EventArgs e)
        {
            FormEngine.BuildAndRun(this);
            belgelerclick.PerformClick();
            userlbl.Text = _appData.Kullanici;
            firmalbl.Text = _appData.FirmaUnvan;
        }
    }
}