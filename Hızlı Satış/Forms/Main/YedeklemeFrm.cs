using Guna.UI2.WinForms;
using Hızlı_Satış.Classes;
using Hızlı_Satış.Engines;
using Hızlı_Satış.UControls.Yedekleme;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Hızlı_Satış.Forms.Main
{
    public partial class YedeklemeFrm : Form
    {
        private AppData _appData;

        public YedeklemeFrm(AppData appData)
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

        private void yedeklemeclick_Click(object sender, EventArgs e)
        {
            if (page == "yedekleme")
            {
            }
            else
            {
                PanelTemizle(sender);
                Yedekleme yedekleme = new Yedekleme();
                yedekleme.Size = new Size(panel.Size.Width, panel.Size.Height);
                panel.Controls.Add(yedekleme);
                btnaktiflestir(sender);
                page = "yedekleme";
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

        private void YedeklemeFrm_Load(object sender, EventArgs e)
        {
            FormEngine.BuildAndRun(this);
            yedeklemeclick.PerformClick();
            firmalbl.Text = _appData.FirmaUnvan;
            userlbl.Text = _appData.Kullanici;
        }
    }
}