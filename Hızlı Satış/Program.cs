using Hızlı_Satış.Engines;
using System;
using System.Windows.Forms;
using static Hızlı_Satış.Engines.StartControl;

namespace Hızlı_Satış
{
    internal static class Program
    {
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Kontrol();

            AppEngine.RunApp();
        }
    }
}