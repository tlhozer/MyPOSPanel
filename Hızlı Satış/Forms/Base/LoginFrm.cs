using Guna.UI2.WinForms;
using Hızlı_Satış.Classes;
using Hızlı_Satış.Database;
using Hızlı_Satış.Engines;
using Hızlı_Satış.Forms.Main;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Hızlı_Satış
{
    public partial class LoginFrm : Form
    {
        private AppData _appdata;

        public LoginFrm(AppData appData)
        {
            InitializeComponent();
            _appdata = appData;
        }

       

        private string version = Application.ProductVersion;

        private void LoginFrm_Load(object sender, EventArgs e)
        {
            versiyonlbl.Text += " Versiyon: " + version;
            timer1.Start();
            KullaniciGetir();
        }

        private void kapat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void girisbtn_Click(object sender, EventArgs e)
        {
            if (parolabox.Text.Length > 0)
            {
                if (UserDAL.GirisYap(kullanicibox.Text, parolabox.Text))
                {
                    _appdata.Kullanici = kullanicibox.Text;
                    MenuFrm menuFrm = new MenuFrm(_appdata);
                    this.Hide();
                    menuFrm.ShowDialog();
                }
                else
                {
                    MessageEngine.ErrorMessage("Hata!", "Parola Yanlış", this);
                    parolabox.Focus();
                }
            }
            else
            {
                MessageEngine.WarningMessage("Uyarı", "Parola Alanı Boş Kalamaz.", this);
            }
        }


        private void tustikla(object sender, EventArgs e)
        {
            Guna2Button btn = sender as Guna2Button;
            parolabox.Text += btn.Text;
            parolabox.Select(parolabox.Text.Length, 0);
        }

        private void silbtn_Click(object sender, EventArgs e)
        {
            parolabox.Clear();
        }

        private void teksil_Click(object sender, EventArgs e)
        {
            if (parolabox.Text.Length > 0)
            {
                string prl = parolabox.Text;
                parolabox.Text = prl.Substring(0, prl.Length - 1);
            }
        }

        private void KullaniciGetir()
        {
            kullanicibox.Items.Clear();
            List<string> Kullanicilar = UserDAL.GetLoginUsers();
            foreach (string k in Kullanicilar)
            {
                kullanicibox.Items.Add(k);
            }

            kullanicibox.SelectedIndex = 0;
            parolabox.Focus();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime tarih = DateTime.Now;
            tarihlbl.Text = tarih.ToString("f");
        }

        private void versiyonlbl_Click(object sender, EventArgs e)
        {

        }
    }
}