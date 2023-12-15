using Guna.UI2.WinForms;
using Hızlı_Satış.Classes;
using Hızlı_Satış.Engines;
using Hızlı_Satış.UControls.Stok;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Hızlı_Satış.Forms.Main
{
    public partial class StokFrm : Form
    {
        private AppData _appData;

        public StokFrm(AppData appData)
        {
            InitializeComponent();
            _appData = appData;
        }

        private string page = "";
        private object previousSender;

        private void StokFrm_Load(object sender, EventArgs e)
        {
            firmalbl.Text = _appData.FirmaUnvan;
            userlbl.Text = _appData.Kullanici;
            stoklistebtn.PerformClick();
            FormEngine.BuildAndRun(this);
        }

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

        private void stoklistebtn_Click(object sender, EventArgs e)
        {
            if (page == "stoklistesi")
            {
            }
            else
            {
                PanelTemizle(sender);
                StokListesi stokListesi = new StokListesi();
                stokListesi.Size = new Size(panel.Size.Width, panel.Size.Height);
                panel.Controls.Add(stokListesi);
                btnaktiflestir(sender);
                page = "stoklistesi";
            }
        }

        private void yenistokbtn_Click(object sender, EventArgs e)
        {
            if (page == "yenistok")
            {
            }
            else
            {
                PanelTemizle(sender);
                YeniStokKarti yeniStokKarti = new YeniStokKarti(_appData);
                yeniStokKarti.Size = new Size(panel.Size.Width, panel.Size.Height);
                panel.Controls.Add(yeniStokKarti);
                btnaktiflestir(sender);
                page = "yenistok";
            }
        }

        private void hizlislembtn_Click(object sender, EventArgs e)
        {
            if (page == "hizlislemler")
            {
            }
            else
            {
                PanelTemizle(sender);
                Hizlislemler hizlislemler = new Hizlislemler();
                hizlislemler.Size = new Size(panel.Size.Width, panel.Size.Height);
                panel.Controls.Add(hizlislemler);
                btnaktiflestir(sender);
                page = "hizlislemler";
            }
        }

        private void sayimbtn_Click(object sender, EventArgs e)
        {
            if (page == "sayim")
            {
            }
            else
            {
                PanelTemizle(sender);
                Sayimislemleri sayimislemleri = new Sayimislemleri();
                sayimislemleri.Size = new Size(panel.Size.Width, panel.Size.Height);
                panel.Controls.Add(sayimislemleri);
                btnaktiflestir(sender);
                page = "sayim";
            }
        }

        private void etiketbtn_Click(object sender, EventArgs e)
        {
            if (page == "etiket")
            {
            }
            else
            {
                PanelTemizle(sender);
                EtiketBarkod etiketBarkod = new EtiketBarkod();
                etiketBarkod.Size = new Size(panel.Size.Width, panel.Size.Height);
                panel.Controls.Add(etiketBarkod);
                btnaktiflestir(sender);
                page = "etiket";
            }
        }

        private void hizliraporbtn_Click(object sender, EventArgs e)
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

        private void stokaktarimbtn_Click(object sender, EventArgs e)
        {
            if (page == "stokaktarim")
            {
            }
            else
            {
                PanelTemizle(sender);
                StokAktarim stokAktarim = new StokAktarim();
                stokAktarim.Size = new Size(panel.Size.Width, panel.Size.Height);
                panel.Controls.Add(stokAktarim);
                btnaktiflestir(sender);
                page = "stokaktarim";
            }
        }

        private void stokislembtn_Click(object sender, EventArgs e)
        {
            if (page == "stokislem")
            {
            }
            else
            {
                PanelTemizle(sender);
                Stokİslemleri stokİslemleri = new Stokİslemleri();
                stokİslemleri.Size = new Size(panel.Size.Width, panel.Size.Height);
                panel.Controls.Add(stokİslemleri);
                btnaktiflestir(sender);
                page = "stokislem";
            }
        }
    }
}