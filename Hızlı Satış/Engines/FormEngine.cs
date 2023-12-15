using System.Windows.Forms;

namespace Hızlı_Satış.Engines
{
    public static class FormEngine
    {
        public static void BuildAndRun(Form form)
        {
            form.Icon = Properties.Resources.AppIcon;
            form.StartPosition = FormStartPosition.CenterScreen;

            if (Properties.General.Default.FullScreen == "0")
            {
                form.WindowState = FormWindowState.Maximized;
            }
            else if (Properties.General.Default.FullScreen == "1")
            {
                form.WindowState = FormWindowState.Normal;
                form.StartPosition = FormStartPosition.CenterScreen;
            }
        }
    }
}