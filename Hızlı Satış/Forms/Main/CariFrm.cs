using Guna.UI2.WinForms;
using Hızlı_Satış.Classes;
using Hızlı_Satış.Engines;
using Hızlı_Satış.UControls.Cari;
using Hızlı_Satış.UControls.Stok;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Hızlı_Satış.Forms.Main
{
    public partial class CariFrm : Form
    {
        private AppData _appData;

        public CariFrm(AppData appData)
        {
            InitializeComponent();
            _appData = appData;
        }

        private string page = "";
        private object previousSender;

        private void cariclick_Click(object sender, EventArgs e)
        {
            if (page == "cariliste")
            {
            }
            else
            {
                PanelTemizle(sender);
                CariListesi cariListesi = new CariListesi();
                cariListesi.Size = new Size(panel.Size.Width, panel.Size.Height);
                panel.Controls.Add(cariListesi);
                btnaktiflestir(sender);
                page = "cariliste";
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

        private void yenicariclick_Click(object sender, EventArgs e)
        {
            if (page == "yenicari")
            {
            }
            else
            {
                PanelTemizle(sender);
                YeniCariKarti yeniCariKarti = new YeniCariKarti();
                yeniCariKarti.Size = new Size(panel.Size.Width, panel.Size.Height);
                panel.Controls.Add(yeniCariKarti);
                btnaktiflestir(sender);
                page = "yenicari";
            }
        }

        private void hizlislemclick_Click(object sender, EventArgs e)
        {
            if (page == "hizlislem")
            {
            }
            else
            {
                PanelTemizle(sender);
                Hizlislem hizlislem = new Hizlislem();
                hizlislem.Size = new Size(panel.Size.Width, panel.Size.Height);
                panel.Controls.Add(hizlislem);
                btnaktiflestir(sender);
                page = "hizlislem";
            }
        }

        private void hizliraporclick_Click(object sender, EventArgs e)
        {
            if (page == "hizlirapor")
            {
            }
            else
            {
                PanelTemizle(sender);
                HizliRapor hizliRapor = new HizliRapor();
                hizliRapor.Size = new Size(panel.Size.Width, panel.Size.Height);
                panel.Controls.Add(hizliRapor);
                btnaktiflestir(sender);
                page = "hizlirapor";
            }
        }

        private void carislemclick_Click(object sender, EventArgs e)
        {
            if (page == "carislem")
            {
            }
            else
            {
                PanelTemizle(sender);
                Carislem carislem = new Carislem();
                carislem.Size = new Size(panel.Size.Width, panel.Size.Height);
                panel.Controls.Add(carislem);
                btnaktiflestir(sender);
                page = "carislem";
            }
        }

        private void CariFrm_Load(object sender, EventArgs e)
        {
            cariclick.PerformClick();
            firmalbl.Text = _appData.FirmaUnvan;
            userlbl.Text = _appData.Kullanici;
            FormEngine.BuildAndRun(this);
        }

        private void kapatbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}