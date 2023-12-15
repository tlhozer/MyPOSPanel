using Hızlı_Satış.Classes;
using System.Windows.Forms;

namespace Hızlı_Satış.Engines
{
    public static class AppEngine
    {
        //Licence Engine
        //Database Engine
        //Update Engine

      

        public static void RunApp()
        {
            AppData appData = new AppData();
            appData.FirmaUnvan = "Mert Market";
            Application.Run(new LoginFrm(appData));
        }
    }
}