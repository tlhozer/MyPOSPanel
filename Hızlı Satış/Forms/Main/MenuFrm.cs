using Hızlı_Satış.Classes;
using Hızlı_Satış.Engines;
using Hızlı_Satış.Forms.Base.Edit;
using Hızlı_Satış.Forms.HizliSatis;
using Hızlı_Satış.UControls.Shotrcuts;
using System;
using System.Windows.Forms;

namespace Hızlı_Satış.Forms.Main
{
    public partial class MenuFrm : Form
    {
        private AppData _appData;

        public MenuFrm(AppData appData)
        {
            InitializeComponent();
            _appData = appData;
        }

        private void hizlisatisbtn_Click(object sender, EventArgs e)
        {
        }

        private void MenuFrm_Load(object sender, EventArgs e)
        {
            firmalbl.Text = _appData.FirmaUnvan;
            userlbl.Text = _appData.Kullanici;
            FormEngine.BuildAndRun(this);
            KisayollariYukle();
        }

        private void KisayollariYukle()
        {
            icpanel.Controls.Clear();

            string k1 = Properties.Shortcuts.Default.short1;
            string k2 = Properties.Shortcuts.Default.short2;
            string k3 = Properties.Shortcuts.Default.short3;
            string k4 = Properties.Shortcuts.Default.short4;
            string k5 = Properties.Shortcuts.Default.short5;
            string k6 = Properties.Shortcuts.Default.short6;

            if (k1 != "" && k1 != "Boş")
            {
                KisayolGetir(k1, 0);
            }
            if (k2 != "" && k2 != "Boş")
            {
                KisayolGetir(k2, 1);
            }
            if (k3 != "" && k3 != "Boş")
            {
                KisayolGetir(k3, 2);
            }
            if (k4 != "" && k4 != "Boş")
            {
                KisayolGetir(k4, 3);
            }
            if (k5 != "" && k5 != "Boş")
            {
                KisayolGetir(k5, 4);
            }
            if (k6 != "" && k6 != "Boş")
            {
                KisayolGetir(k6, 5);
            }
        }

        private void KisayolGetir(string kelime, int yer)
        {
            if (kelime == "Yeni Ürün Kayıt")
            {
                ShortYeniUrunEkle shortYeniUrunEkle = new ShortYeniUrunEkle(_appData);
                icpanel.Controls.Add(shortYeniUrunEkle, 0, yer);
            }
            else
            {
                MessageBox.Show(kelime);
            }
        }

        private void kapatbtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void stokbtn_Click(object sender, EventArgs e)
        {
            StokFrm stokFrm = new StokFrm(_appData);
            stokFrm.TopMost = true;
            stokFrm.ShowDialog();
        }

        private void caribtn_Click(object sender, EventArgs e)
        {
            CariFrm cariFrm = new CariFrm(_appData);
            cariFrm.TopMost = true;
            cariFrm.ShowDialog();
        }

        private void ayarlarbtn_Click(object sender, EventArgs e)
        {
            AyarlarFrm ayarlarFrm = new AyarlarFrm(_appData);
            ayarlarFrm.TopMost = true;
            ayarlarFrm.ShowDialog();
        }

        private void hizlisatisbtn_Click_1(object sender, EventArgs e)
        {
            PosDefaultFrm defaultFrm = new PosDefaultFrm();
            defaultFrm.TopMost = true;
            defaultFrm.ShowDialog();
        }

        private void belgebtn_Click(object sender, EventArgs e)
        {
            BelgelerFrm belgelerFrm = new BelgelerFrm(_appData);
            belgelerFrm.TopMost = true;
            belgelerFrm.ShowDialog();
        }

        private void belgedizaynbtn_Click(object sender, EventArgs e)
        {
            BelgeDizaynFrm belgeDizaynFrm = new BelgeDizaynFrm(_appData);
            belgeDizaynFrm.TopMost = true;
            belgeDizaynFrm.ShowDialog();
        }

        private void yedeklemebtn_Click(object sender, EventArgs e)
        {
            YedeklemeFrm yedeklemeFrm = new YedeklemeFrm(_appData);
            yedeklemeFrm.TopMost = true;
            yedeklemeFrm.ShowDialog();
        }

        private void kasabtn_Click(object sender, EventArgs e)
        {
            KasaFrm kasaFrm = new KasaFrm(_appData);
            kasaFrm.TopMost = true;
            kasaFrm.ShowDialog();
        }

        private void raporlarbtn_Click(object sender, EventArgs e)
        {
            RaporFrm raporFrm = new RaporFrm(_appData);
            raporFrm.TopMost = true;
            raporFrm.ShowDialog();
        }

        private void kisayolac_Click(object sender, EventArgs e)
        {
            KisayolDuzenleFrm kisayolDuzenleFrm = new KisayolDuzenleFrm();
            kisayolDuzenleFrm.TopMost = true;
            kisayolDuzenleFrm.ShowDialog();
            KisayollariYukle();
        }
    }
}