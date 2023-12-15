using Guna.UI2.WinForms;
using Hızlı_Satış.Database;
using Hızlı_Satış.Engines;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Hızlı_Satış.Forms.HizliSatis
{
    public partial class PosDefaultFrm : Form
    {
        public PosDefaultFrm()
        {
            InitializeComponent();
        }

        private void kapatbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private List<String> KategoriList = PosDAL.GetPosCategorys();

        private void PosDefaultFrm_Load(object sender, EventArgs e)
        {
            FormEngine.BuildAndRun(this);

            KategoriYerlestir();
        }

        public void KategoriYerlestir()
        {
            if (KategoriList.Count > 0)
            {
                int yukseklik = (kategoripanel.Height - (KategoriList.Count + 7)) / KategoriList.Count;
                int genislik = kategoripanel.Width;

                foreach (String item in KategoriList)
                {
                    Guna2TileButton tileButton = new Guna2TileButton();
                    tileButton.Text = item;
                    tileButton.Height = yukseklik;
                    tileButton.Width = genislik - 2;
                    tileButton.Margin = new Padding(1);
                    tileButton.BorderRadius = 5;
                    kategoripanel.Controls.Add(tileButton);
                }
            }
        }
    }
}