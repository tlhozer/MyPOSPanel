using Hızlı_Satış.Forms.Tool;
using System.Drawing;
using System.Windows.Forms;

namespace Hızlı_Satış.UControls.Ayarlar
{
    public partial class KullanimAyarlari : UserControl
    {
        public KullanimAyarlari()
        {
            InitializeComponent();
        }

        private void genelkaydet_Click(object sender, System.EventArgs e)
        {
            if (ekranmoducheck.SelectedIndex == 0)
            {
                Properties.General.Default.FullScreen = "0";
                ekranmoducheck.SelectedIndex = 0;
            }
            else if (ekranmoducheck.SelectedIndex == 1)
            {
                Properties.General.Default.FullScreen = "1";
                ekranmoducheck.SelectedIndex = 1;
            }
            Properties.General.Default.Save();
            //  MessageEngine.SuccesMessage("Başarılı","Genel Ayarlar kayıt edildi");
            // User controlde this çalışmıyor form gönderdiği için
            Application.Restart();
        }

        private void rakamrenksec_Click(object sender, System.EventArgs e)
        {
            ColorDialog RenkSec = new ColorDialog();
            RenkSec.FullOpen = true;
            if (RenkSec.ShowDialog() == DialogResult.OK) // colordialog'tan bir renk seçildiyse işlem yapılacak.
            {
                rakambox.BackColor = RenkSec.Color;
            }
        }

        private void harfrenksec_Click(object sender, System.EventArgs e)
        {
            ColorDialog RenkSec = new ColorDialog();
            RenkSec.FullOpen = true;
            if (RenkSec.ShowDialog() == DialogResult.OK) // colordialog'tan bir renk seçildiyse işlem yapılacak.
            {
                harfbox.BackColor = RenkSec.Color;
            }
        }

        private void tusrenksec_Click(object sender, System.EventArgs e)
        {
            ColorDialog RenkSec = new ColorDialog();
            RenkSec.FullOpen = true;
            if (RenkSec.ShowDialog() == DialogResult.OK) // colordialog'tan bir renk seçildiyse işlem yapılacak.
            {
                digerbox.BackColor = RenkSec.Color;
            }
        }

        private void sifirlaclick_Click(object sender, System.EventArgs e)
        {
            rakambox.BackColor = Color.FromArgb(47, 54, 64);
            harfbox.BackColor = Color.FromArgb(47, 54, 64);
            digerbox.BackColor = Color.FromArgb(47, 54, 64);

            kaydetbtn.PerformClick();
        }

        private void klavyegosterlclick_Click(object sender, System.EventArgs e)
        {
            FullKeyboardFrm fullKeyboardFrm = new FullKeyboardFrm();
            fullKeyboardFrm.TopMost = true;
            fullKeyboardFrm.ShowDialog();
        }

        private void numericklavyeclick_Click(object sender, System.EventArgs e)
        {
            NumericKeyboardFrm numericKeyboardFrm = new NumericKeyboardFrm();
            numericKeyboardFrm.TopMost = true;
            numericKeyboardFrm.ShowDialog();
        }

        private string HexDonustur(Color color)
        {
            Color myColor = Color.FromArgb(color.R, color.G, color.B);
            string hex = myColor.R.ToString("X2") + myColor.G.ToString("X2") + myColor.B.ToString("X2");
            return "#" + hex;
        }

        private void kaydetbtn_Click(object sender, System.EventArgs e)
        {
            Color renkcolor = rakambox.BackColor;
            Color harfcolor = harfbox.BackColor;
            Color digercolor = digerbox.BackColor;

            Properties.KeyboardColor.Default.rakamrenk = HexDonustur(renkcolor);
            Properties.KeyboardColor.Default.harfrenk = HexDonustur(harfcolor);
            Properties.KeyboardColor.Default.digerrenk = HexDonustur(digercolor);
            Properties.KeyboardColor.Default.Save();
            MessageBox.Show("Klavye renkleri kaydedildi");
        }

        private string rakamrenk = "";
        private string harfrenk = "";
        private string digerrenk = "";

        private void KullanimAyarlari_Load(object sender, System.EventArgs e)
        {
            varsayilansifre.Text = Properties.KullanimAyarlari.Default.varsayilansifre;
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

            Color RkmRnk = System.Drawing.ColorTranslator.FromHtml(rakamrenk);
            Color HrfRk = System.Drawing.ColorTranslator.FromHtml(harfrenk);
            Color Dgrenk = System.Drawing.ColorTranslator.FromHtml(digerrenk);
            rakambox.BackColor = RkmRnk;
            harfbox.BackColor = HrfRk;
            digerbox.BackColor = Dgrenk;

            if (Properties.General.Default.FullScreen == "1")
            {
                ekranmoducheck.SelectedIndex = 1;
            }
            else
            {
                ekranmoducheck.SelectedIndex = 0;
            }
        }
    }
}