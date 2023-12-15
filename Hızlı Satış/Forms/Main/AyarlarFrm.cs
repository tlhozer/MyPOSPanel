using Guna.UI2.WinForms;
using Hızlı_Satış.Classes;
using Hızlı_Satış.Engines;
using Hızlı_Satış.UControls.Ayarlar;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Hızlı_Satış.Forms.Main
{
    public partial class AyarlarFrm : Form
    {
        private AppData _appData;

        public AyarlarFrm(AppData appData)
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

        private void AyarlarFrm_Load(object sender, EventArgs e)
        {
            firmasabitleri.PerformClick();
            firmalbl.Text = _appData.FirmaUnvan;
            userlbl.Text = _appData.Kullanici;
            FormEngine.BuildAndRun(this);
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

        private void firmasabitleri_Click(object sender, EventArgs e)
        {
            if (page == "firmasabit")
            {
            }
            else
            {
                PanelTemizle(sender);
                FirmaSabitleri firmaSabitleri = new FirmaSabitleri();
                firmaSabitleri.Size = new Size(panel.Size.Width, panel.Size.Height);
                panel.Controls.Add(firmaSabitleri);
                btnaktiflestir(sender);
                page = "firmasabit";
            }
        }

        private void KullanicilarBtn_Click(object sender, EventArgs e)
        {
            if (page == "kullanicilar")
            {
            }
            else
            {
                PanelTemizle(sender);
                Kullanicilar kullanicilar = new Kullanicilar();
                kullanicilar.Size = new Size(panel.Size.Width, panel.Size.Height);
                panel.Controls.Add(kullanicilar);
                btnaktiflestir(sender);
                page = "kullanicilar";
            }
        }

        private void cihazlarbtn_Click(object sender, EventArgs e)
        {
            if (page == "cihazlar")
            {
            }
            else
            {
                PanelTemizle(sender);
                Cihazlar cihazlar = new Cihazlar();
                cihazlar.Size = new Size(panel.Size.Width, panel.Size.Height);
                panel.Controls.Add(cihazlar);
                btnaktiflestir(sender);
                page = "cihazlar";
            }
        }

        private void posekranbtn_Click(object sender, EventArgs e)
        {
            if (page == "posekrani")
            {
            }
            else
            {
                PanelTemizle(sender);
                PosEkrani posEkrani = new PosEkrani();
                posEkrani.Size = new Size(panel.Size.Width, panel.Size.Height);
                panel.Controls.Add(posEkrani);
                btnaktiflestir(sender);
                page = "posekrani";
            }
        }

        private void kullanimayarlari_Click(object sender, EventArgs e)
        {
            if (page == "kullanimayari")
            {
            }
            else
            {
                PanelTemizle(sender);
                UControls.Ayarlar.KullanimAyarlari kullanim = new UControls.Ayarlar.KullanimAyarlari();
                kullanim.Size = new Size(panel.Size.Width, panel.Size.Height);
                panel.Controls.Add(kullanim);
                btnaktiflestir(sender);
                page = "kullanimayari";
            }
        }

        private void sonislembtn_Click(object sender, EventArgs e)
        {
            if (page == "sonislem")
            {
            }
            else
            {
                PanelTemizle(sender);
                Sonislemler sonislemler = new Sonislemler();
                sonislemler.Size = new Size(panel.Size.Width, panel.Size.Height);
                panel.Controls.Add(sonislemler);
                btnaktiflestir(sender);
                page = "sonislem";
            }
        }

        private void entegrebtn_Click(object sender, EventArgs e)
        {
            if (page == "entegrasyon")
            {
            }
            else
            {
                PanelTemizle(sender);
                Entegrasyon entegrasyon = new Entegrasyon();
                entegrasyon.Size = new Size(panel.Size.Width, panel.Size.Height);
                panel.Controls.Add(entegrasyon);
                btnaktiflestir(sender);
                page = "entegrasyon";
            }
        }

        private void lisansbtn_Click(object sender, EventArgs e)
        {
            if (page == "lisansbilgisi")
            {
            }
            else
            {
                PanelTemizle(sender);
                LisansBilgileri lisansBilgileri = new LisansBilgileri();
                lisansBilgileri.Size = new Size(panel.Size.Width, panel.Size.Height);
                panel.Controls.Add(lisansBilgileri);
                btnaktiflestir(sender);
                page = "lisansbilgisi";
            }
        }

        private void bakimbtn_Click(object sender, EventArgs e)
        {
            if (page == "bakim")
            {
            }
            else
            {
                PanelTemizle(sender);
                BakimYedek bakimYedek = new BakimYedek();
                bakimYedek.Size = new Size(panel.Size.Width, panel.Size.Height);
                panel.Controls.Add(bakimYedek);
                btnaktiflestir(sender);
                page = "bakim";
            }
        }

        private void Temabtn_Click(object sender, EventArgs e)
        {
            if (page == "tema")
            {
            }
            else
            {
                PanelTemizle(sender);
                TemaAyari temaAyari = new TemaAyari();
                temaAyari.Size = new Size(panel.Size.Width, panel.Size.Height);
                panel.Controls.Add(temaAyari);
                btnaktiflestir(sender);
                page = "tema";
            }
        }
    }
}