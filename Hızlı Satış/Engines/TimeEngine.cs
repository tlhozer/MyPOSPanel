using System;

namespace Hızlı_Satış.Engines
{
    public static class TimeEngine
    {
        public static string GetFullTime()
        {
            DateTime tarih = DateTime.Now;
            return tarih.ToString("f");
        }
    }
}