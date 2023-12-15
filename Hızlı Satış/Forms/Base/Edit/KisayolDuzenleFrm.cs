using Hızlı_Satış.Engines;
using System;
using System.Windows.Forms;

namespace Hızlı_Satış.Forms.Base.Edit
{
    public partial class KisayolDuzenleFrm : Form
    {
        public KisayolDuzenleFrm()
        {
            InitializeComponent();
            //FormEngine.BuildAndRun(this);
        }

        private void KisayolDuzenleFrm_Load(object sender, EventArgs e)
        {
            Yerlestir();
        }

        private void Yerlestir()
        {
            Doldur(k1, 1);
            Doldur(k2, 2);
            Doldur(k3, 3);
            Doldur(k4, 4);
            Doldur(k5, 5);
            Doldur(k6, 6);
        }

        private void Doldur(ComboBox cm, int sira)
        {
            cm.Items.Clear();
            cm.Items.Add("Boş");
            cm.Items.Add("Yeni Ürün Kayıt");
        }

        private void vazgecbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void kaydetbtn_Click(object sender, EventArgs e)
        {
            Properties.Shortcuts.Default.short1 = k1.Text;
            Properties.Shortcuts.Default.short2 = k2.Text;
            Properties.Shortcuts.Default.short3 = k3.Text;
            Properties.Shortcuts.Default.short4 = k4.Text;
            Properties.Shortcuts.Default.short5 = k5.Text;
            Properties.Shortcuts.Default.short6 = k6.Text;
            Properties.Shortcuts.Default.Save();

            MessageEngine.SuccesMessage("Başarılı", "Kısayollar Kayıt Edildi.", this);
            this.Hide();
        }
    }
}