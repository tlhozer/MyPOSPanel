using Hızlı_Satış.Tools.Forms.MessageForms;
using System.Drawing;
using System.Windows.Forms;

namespace Hızlı_Satış.Engines
{
    public static class MessageEngine
    {
        public static void SuccesMessage(string baslik, string text, Form Acan)
        {
            SuccesFrm succesFrm = new SuccesFrm(baslik, text);
            Color Succes = Color.FromArgb(46, 204, 113);
            Ozellestir(succesFrm, Acan, Succes);
        }

        public static void ErrorMessage(string baslik, string text, Form Acan)
        {
            ErrorFrm errorFrm = new ErrorFrm(baslik, text);
            Color Error = Color.FromArgb(231, 76, 60);
            Ozellestir(errorFrm, Acan, Error);
        }

        public static void WarningMessage(string baslik, string text, Form Acan)
        {
            WarningFrm warningFrm = new WarningFrm(baslik, text);
            Color Warning = Color.FromArgb(254, 185, 6);
            Ozellestir(warningFrm, Acan, Warning);
        }

        public static void InfoMessage(string baslik, string text, Form Acan)
        {
            InfoFrm ınfoFrm = new InfoFrm(baslik, text);
            Color Info = Color.FromArgb(20, 148, 223);
            Ozellestir(ınfoFrm, Acan, Info);
        }

        private static void Ozellestir(Form msgForm, Form AcanForm, Color renk)
        {
            BackgroundFrm background = new BackgroundFrm();

            using (msgForm)
            {
                background.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
                background.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                background.Opacity = .50d;
                background.BackColor = renk;
                background.WindowState = System.Windows.Forms.FormWindowState.Normal;
                background.Size = AcanForm.Size;
                background.TopMost = true;
                background.Location = AcanForm.Location;
                background.ShowInTaskbar = false;
                background.Show();
                msgForm.TopMost = true;
                msgForm.ShowDialog();
                background.Dispose();
            }
            AcanForm.TopMost = true;
        }
    }
}