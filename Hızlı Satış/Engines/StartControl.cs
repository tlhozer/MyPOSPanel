using System.Diagnostics;
using System.Windows.Forms;

namespace Hızlı_Satış.Engines
{
    public class StartControl
    {
        public static void Kontrol()
        {
            Process prcess = Process.GetCurrentProcess();
            Process[] prcessList = Process.GetProcessesByName(prcess.ProcessName);

            if (prcessList.Length > 1)
            {
                MessageBox.Show("Program Zaten Açık!", "Sistem", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }
        }
    }
}