using Hızlı_Satış.Classes.DataClasses;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Data;

using static Hızlı_Satış.Engines.DatabaseEngine;

namespace Hızlı_Satış.Database
{
    public static class PosDAL
    {
        private static MySqlCommand cmd;
        private static MySqlDataAdapter adapter;
        private static DataTable dt;
        private static MySqlDataReader satir;

        public static List<string> GetPosCategorys()
        {
            List<string> kategoriler = new List<string>();
            dt = new DataTable();
            BaglantiAc();
            adapter = new MySqlDataAdapter("SELECT * FROM tbl_Pos_Kategoriler ORDER BY kategori_sira ASC", mysqlbaglan);
            adapter.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {
                kategoriler.Add(dr["kategori_name"].ToString());
            }
            BaglantiKapat();
            return kategoriler;
        }

        public static bool PosKategoriEkle(PosKategori kategori)
        {
            try
            {
                BaglantiAc();
                string sorgu = "INSERT INTO tbl_Pos_Kategoriler (kategori_name,kategori_sira) values (@p1,@p2)";
                cmd = new MySqlCommand(sorgu, mysqlbaglan);
                cmd.Parameters.AddWithValue("@p1", kategori.KategoriAdi);
                cmd.Parameters.AddWithValue("@p2", 0);
                cmd.ExecuteNonQuery();
                BaglantiKapat();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool PosKategoriDuzenle(string eskikategori, string yenikategori)
        {
            BaglantiAc();

            string updateQuery = "UPDATE tbl_Pos_Kategoriler SET kategori_name = @YeniKategoriAdi WHERE kategori_name=@eskikategori";

            cmd = new MySqlCommand(updateQuery, mysqlbaglan);
            cmd.Parameters.AddWithValue("@YeniKategoriAdi", yenikategori);
            cmd.Parameters.AddWithValue("@eskikategori", eskikategori);

            int rowsAffected = cmd.ExecuteNonQuery();

            BaglantiKapat();

            return rowsAffected > 0;
        }

        public static bool PosKategoriSiralamaKaydet(string eskikategori, string yenikategori)
        {
            BaglantiAc();

            string updateQuery = "UPDATE tbl_Pos_Kategoriler SET kategori_sira = @kategorisira WHERE kategori_name=@kategoriadi";

            cmd = new MySqlCommand(updateQuery, mysqlbaglan);
            cmd.Parameters.AddWithValue("@kategorisira", yenikategori);
            cmd.Parameters.AddWithValue("@kategoriadi", eskikategori);

            int rowsAffected = cmd.ExecuteNonQuery();

            BaglantiKapat();

            return rowsAffected > 0;
        }
    }
}