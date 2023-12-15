using Guna.UI2.WinForms;
using Hızlı_Satış.Classes;
using Hızlı_Satış.Engines;
using Hızlı_Satış.UControls.Kasa;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Hızlı_Satış.Forms.Main
{
    public partial class KasaFrm : Form
    {
        private AppData _appData;

        public KasaFrm(AppData appData)
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

        private void kasaclick_Click(object sender, EventArgs e)
        {
            if (page == "kasa")
            {
            }
            else
            {
                PanelTemizle(sender);
                Kasa kasa = new Kasa();
                kasa.Size = new Size(panel.Size.Width, panel.Size.Height);
                panel.Controls.Add(kasa);
                btnaktiflestir(sender);
                page = "kasa";
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

        private void KasaFrm_Load(object sender, EventArgs e)
        {
            FormEngine.BuildAndRun(this);
            kasaclick.PerformClick();
            firmalbl.Text = _appData.FirmaUnvan;
            userlbl.Text = _appData.Kullanici;
        }
    }
}