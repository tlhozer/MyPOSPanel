using Guna.UI2.WinForms;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Hızlı_Satış.Forms.Tool
{
    public partial class FullKeyboardFrm : Form
    {
        public FullKeyboardFrm()
        {
            InitializeComponent();
        }

        private string rakamrenk = "";
        private string harfrenk = "";
        private string digerrenk = "";
        private bool CapsLook = true;

        private void FullKeyboardFrm_Load(object sender, EventArgs e)
        {
            if (Properties.KeyboardColor.Default.rakamrenk == "")
            {
                rakamrenk = "#2c3e50";
            }
            else
            {
                rakamrenk = Properties.KeyboardColor.Default.rakamrenk;
            }
            if (Properties.KeyboardColor.Default.harfrenk == "")
            {
                harfrenk = "#2c3e50";
            }
            else
            {
                harfrenk = Properties.KeyboardColor.Default.harfrenk;
            }

            if (Properties.KeyboardColor.Default.digerrenk == "")
            {
                digerrenk = "#2c3e50";
            }
            else
            {
                digerrenk = Properties.KeyboardColor.Default.digerrenk;
            }

            StilUygula();
        }

        private void StilUygula()
        {
            Color RkmRnk = System.Drawing.ColorTranslator.FromHtml(rakamrenk);
            Color HrfRk = System.Drawing.ColorTranslator.FromHtml(harfrenk);
            Color Dgrenk = System.Drawing.ColorTranslator.FromHtml(digerrenk);

            rkm1.FillColor = RkmRnk;
            rkm2.FillColor = RkmRnk;
            rkm3.FillColor = RkmRnk;
            rkm4.FillColor = RkmRnk;
            rkm5.FillColor = RkmRnk;
            rkm6.FillColor = RkmRnk;
            rkm7.FillColor = RkmRnk;
            rkm8.FillColor = RkmRnk;
            rkm9.FillColor = RkmRnk;
            rkm0.FillColor = RkmRnk;

            hrf1.FillColor = HrfRk;
            hrf2.FillColor = HrfRk;
            hrf3.FillColor = HrfRk;
            hrf4.FillColor = HrfRk;
            hrf5.FillColor = HrfRk;
            hrf6.FillColor = HrfRk;
            hrf7.FillColor = HrfRk;
            hrf8.FillColor = HrfRk;
            hrf9.FillColor = HrfRk;
            hrf10.FillColor = HrfRk;
            hrf11.FillColor = HrfRk;
            hrf12.FillColor = HrfRk;
            hrf13.FillColor = HrfRk;
            hrf14.FillColor = HrfRk;
            hrf15.FillColor = HrfRk;
            hrf16.FillColor = HrfRk;
            hrf17.FillColor = HrfRk;
            hrf18.FillColor = HrfRk;
            hrf19.FillColor = HrfRk;
            hrf20.FillColor = HrfRk;
            hrf21.FillColor = HrfRk;
            hrf22.FillColor = HrfRk;
            hrf23.FillColor = HrfRk;
            hrf24.FillColor = HrfRk;
            hrf25.FillColor = HrfRk;
            hrf26.FillColor = HrfRk;
            hrf27.FillColor = HrfRk;
            hrf28.FillColor = HrfRk;
            hrf29.FillColor = HrfRk;
            hrf30.FillColor = HrfRk;
            hrf31.FillColor = HrfRk;
            hrf32.FillColor = HrfRk;

            diger1.FillColor = Dgrenk;
            diger2.FillColor = Dgrenk;
            diger3.FillColor = Dgrenk;
            diger4.FillColor = Dgrenk;
            diger6.FillColor = Dgrenk;
            diger8.FillColor = Dgrenk;
            diger9.FillColor = Dgrenk;
        }

        private void BuyukHarf()
        {
            if (CapsLook == true)
            {
                hrf1.Text = hrf1.Text.ToLower();
                hrf2.Text = hrf2.Text.ToLower();
                hrf3.Text = hrf3.Text.ToLower();
                hrf4.Text = hrf4.Text.ToLower();
                hrf5.Text = hrf5.Text.ToLower();
                hrf6.Text = hrf6.Text.ToLower();
                hrf7.Text = hrf7.Text.ToLower();
                hrf8.Text = hrf8.Text.ToLower();
                hrf9.Text = hrf9.Text.ToLower();
                hrf10.Text = hrf10.Text.ToLower();
                hrf11.Text = hrf11.Text.ToLower();
                hrf12.Text = hrf12.Text.ToLower();
                hrf13.Text = hrf13.Text.ToLower();
                hrf14.Text = hrf14.Text.ToLower();
                hrf15.Text = hrf15.Text.ToLower();
                hrf16.Text = hrf16.Text.ToLower();
                hrf17.Text = hrf17.Text.ToLower();
                hrf18.Text = hrf18.Text.ToLower();
                hrf19.Text = hrf19.Text.ToLower();
                hrf20.Text = hrf20.Text.ToLower();
                hrf21.Text = hrf21.Text.ToLower();
                hrf22.Text = hrf22.Text.ToLower();
                hrf23.Text = hrf23.Text.ToLower();
                hrf24.Text = hrf24.Text.ToLower();
                hrf25.Text = hrf25.Text.ToLower();
                hrf26.Text = hrf26.Text.ToLower();
                hrf27.Text = hrf27.Text.ToLower();
                hrf28.Text = hrf28.Text.ToLower();
                hrf29.Text = hrf29.Text.ToLower();
                hrf30.Text = hrf30.Text.ToLower();
                hrf31.Text = hrf31.Text.ToLower();
                hrf32.Text = hrf32.Text.ToLower();

                CapsLook = false;
                diger8.Text = "Capslock Kapalı";
            }
            else
            {
                hrf1.Text = hrf1.Text.ToUpper();
                hrf2.Text = hrf2.Text.ToUpper();
                hrf3.Text = hrf3.Text.ToUpper();
                hrf4.Text = hrf4.Text.ToUpper();
                hrf5.Text = hrf5.Text.ToUpper();
                hrf6.Text = hrf6.Text.ToUpper();
                hrf7.Text = hrf7.Text.ToUpper();
                hrf8.Text = hrf8.Text.ToUpper();
                hrf9.Text = hrf9.Text.ToUpper();
                hrf10.Text = hrf10.Text.ToUpper();
                hrf11.Text = hrf11.Text.ToUpper();
                hrf12.Text = hrf12.Text.ToUpper();
                hrf13.Text = hrf13.Text.ToUpper();
                hrf14.Text = hrf14.Text.ToUpper();
                hrf15.Text = hrf15.Text.ToUpper();
                hrf16.Text = hrf16.Text.ToUpper();
                hrf17.Text = hrf17.Text.ToUpper();
                hrf18.Text = hrf18.Text.ToUpper();
                hrf19.Text = hrf19.Text.ToUpper();
                hrf20.Text = hrf20.Text.ToUpper();
                hrf21.Text = hrf21.Text.ToUpper();
                hrf22.Text = hrf22.Text.ToUpper();
                hrf23.Text = hrf23.Text.ToUpper();
                hrf24.Text = hrf24.Text.ToUpper();
                hrf25.Text = hrf25.Text.ToUpper();
                hrf26.Text = hrf26.Text.ToUpper();
                hrf27.Text = hrf27.Text.ToUpper();
                hrf28.Text = hrf28.Text.ToUpper();
                hrf29.Text = hrf29.Text.ToUpper();
                hrf30.Text = hrf30.Text.ToUpper();
                hrf31.Text = hrf31.Text.ToUpper();
                hrf32.Text = hrf32.Text.ToUpper();
                CapsLook = true;
                diger8.Text = "Capslock Açık";
            }
        }

        private void TusClik(object sender, EventArgs e)
        {
            Guna2Button btn = sender as Guna2Button;
            text.Text += btn.Text;
        }

        private void enterclick_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void diger5_Click_1(object sender, EventArgs e)
        {
            text.Clear();
        }

        private void diger9_Click(object sender, EventArgs e)
        {
            text.Text += " ";
        }

        private void diger8_Click_1(object sender, EventArgs e)
        {
            BuyukHarf();
        }

        private void diger7_Click(object sender, EventArgs e)
        {
            if (text.Text != "")
            {
                text.Text = text.Text.Substring(0, text.Text.Length - 1);
            }
        }
    }
}