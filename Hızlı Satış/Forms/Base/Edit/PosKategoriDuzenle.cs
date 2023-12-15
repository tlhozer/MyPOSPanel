using Hızlı_Satış.Database;
using Hızlı_Satış.Engines;
using System;
using System.Windows.Forms;

namespace Hızlı_Satış.Forms.Base.Edit
{
    public partial class PosKategoriDuzenle : Form
    {
        public PosKategoriDuzenle()
        {
            InitializeComponent();
        }

        public string kategoriadi = "";

        private void PosKategoriDuzenle_Load(object sender, EventArgs e)
        {
        }

        private void kaydetbtn_Click(object sender, EventArgs e)
        {
            if (duzenlebox.Text.Length > 0)
            {
                if (PosDAL.PosKategoriDuzenle(kategoriadi, duzenlebox.Text))
                {
                    this.Hide();
                }
                else
                {
                }
            }
            else
            {
                MessageEngine.WarningMessage("Uyarı", "Kategori Alanı Boş Olamaz..", this);
            }
        }

        private void vazgecbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}