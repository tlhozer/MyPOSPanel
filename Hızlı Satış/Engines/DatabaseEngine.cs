using MySql.Data.MySqlClient;
using System.Data;

namespace Hızlı_Satış.Engines
{
    internal class DatabaseEngine
    {
        public static MySqlConnection mysqlbaglan = new MySqlConnection("Server=45.143.98.61;Database=startpos;Uid=startpos_user;Pwd='Mert1474*';charset=utf8;");

        public static bool CheckDatabase()
        {
            try
            {
                mysqlbaglan.Open();
                if (mysqlbaglan.State != ConnectionState.Closed)
                {
                    //MessageBox.Show("Bağlantı Başarılı Bir Şekilde Gerçekleşti");
                    return true;
                }
                else
                {
                    //MessageBox.Show("Maalesef Bağlantı Yapılamadı...!");
                    return false;
                }
            }
            catch
            {
                return false;
            }
        }

        public static void BaglantiAc()
        {
            if (mysqlbaglan.State == ConnectionState.Closed)
            {
                mysqlbaglan.Open();
            }
            else
            {
                //BAĞLANTI AÇIK
            }
        }

        public static void BaglantiKapat()
        {
            if (mysqlbaglan.State == ConnectionState.Closed)
            {
            }
            else
            {
                mysqlbaglan.Close();
            }
        }
    }
}