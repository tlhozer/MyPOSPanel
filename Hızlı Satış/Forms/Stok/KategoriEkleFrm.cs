using Hızlı_Satış.Classes;
using Hızlı_Satış.Classes.DataClasses;
using Hızlı_Satış.Database;
using Hızlı_Satış.Engines;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Hızlı_Satış.Forms.Stok
{
    public partial class KategoriEkleFrm : Form
    {
        private AppData _appdata;

        public KategoriEkleFrm(AppData appData)
        {
            InitializeComponent();
            _appdata = appData;
        }

        public string kategoriadi = "";

        private void kaydetbtn_Click(object sender, EventArgs e)
        {
            if (eklebox.Text != "")
            {
                List<string> liste = PosDAL.GetPosCategorys();
                PosKategori posKategori = new PosKategori();
                posKategori.KategoriAdi = eklebox.Text;
                if (PosDAL.PosKategoriEkle(posKategori))
                {
                    MessageEngine.SuccesMessage("Başarılı", "Kayıt Edili", this);
                }
                else
                {
                    MessageEngine.ErrorMessage("Error", "Hata Oluştu", this);
                }
            }
            else
            {
                MessageEngine.WarningMessage("Uyarı", "Kategori Adı Boş Olamaz", this);
            }
        }

        private void vazgecbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}