using Guna.UI2.WinForms;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Hızlı_Satış.Forms.Tool
{
    public partial class NumericKeyboardFrm : Form
    {
        public NumericKeyboardFrm()
        {
            InitializeComponent();
        }

        private string rakamrenk = "";
        private string digerrenk = "";

        private void diger2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void diger3_Click(object sender, EventArgs e)
        {
            text.Clear();
        }

        private void StilUygula()
        {
            Color RkmRnk = System.Drawing.ColorTranslator.FromHtml(rakamrenk);
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

            diger1.FillColor = Dgrenk;
            diger2.FillColor = Dgrenk;
        }

        private void NumericKeyboardFrm_Load(object sender, EventArgs e)
        {
            if (Properties.KeyboardColor.Default.rakamrenk == "")
            {
                rakamrenk = "#2c3e50";
            }
            else
            {
                rakamrenk = Properties.KeyboardColor.Default.rakamrenk;
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

        private void tustiklaa(object sender, EventArgs e)
        {
            Guna2Button guna2Button = sender as Guna2Button;
            text.Text += guna2Button.Text;
        }
    }
}