using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Security.Cryptography;
using System.Text;
using static Hızlı_Satış.Engines.DatabaseEngine;

namespace Hızlı_Satış.Database
{
    public class UserDAL
    {
        private static MySqlCommand cmd;
        private static MySqlDataAdapter adapter;
        private static DataTable dt;
        private static MySqlDataReader satir;

        public static List<string> GetLoginUsers()
        {
            List<string> isimler = new List<string>();
            dt = new DataTable();
            BaglantiAc();
            adapter = new MySqlDataAdapter("SELECT * FROM tbl_Kullanicilar WHERE kullanici_status=0", mysqlbaglan);
            adapter.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {
                isimler.Add(dr["kullanici_name"].ToString());
            }
            BaglantiKapat();
            return isimler;
        }

        public static bool GirisYap(string kullanici, string sifre)
        {
            string sifrele = MD5Hash(sifre);
            cmd = new MySqlCommand();
            BaglantiAc();
            cmd.Connection = mysqlbaglan;
            cmd.CommandText = "SELECT * FROM tbl_Kullanicilar WHERE kullanici_name='" + kullanici + "' AND kullanici_pass='" + sifrele + "'";
            satir = cmd.ExecuteReader();
            if (satir.Read())
            {
                satir.Close();
                BaglantiKapat();
                return true;
            }
            else
            {
                satir.Close();
                BaglantiKapat();
                return false;
            }
        }

        public static string MD5Hash(string text)
        {
            using (var md5 = MD5.Create())
            {
                string result = BitConverter.ToString(md5.ComputeHash(Encoding.UTF8.GetBytes(text)))
                                    .Replace("-", string.Empty).ToLower();
                return result;
            }
        }
    }
}