using AutoLike.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoLike.Utils
{
    public class SQLiteUtils
    {
        public static string min;
        public void insertListAccount(List<account> listAccounts)
        {
            //deleteuidtrung(data);

            SQLiteConnection sqliteConnection = new SQLiteConnection();
            sqliteConnection.ConnectionString = "Data Source=Data.sqlite3;Version=3;";
            sqliteConnection.Open();
            SQLiteCommand sqliteCommand = new SQLiteCommand(sqliteConnection);
            SQLiteTransaction trans = sqliteConnection.BeginTransaction();
            sqliteCommand.Transaction = trans;
            Stopwatch sw = new Stopwatch();
            sw.Start();

            foreach(account item in listAccounts)
            {
                string text = string.Format("INSERT INTO data ('CATELOGE', 'UID','PASS','2FA','COOKIE','TOKEN','COOKIELD','TOKENLD','EMAIL','PASSMAIL','NAMTAO','TEN','SINHNHAT','FRIEND','GROUP'," +
               "'GENDER','LIVE','PROXY','LASTACTIVE','DANHMUC','GHICHU','NGAYBU','TRANGTHAI')" +
               " VALUES ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}','{12}','{13}','{14}','{15}','{16}','{17}','{18}','{19}','{20}','{21}','{22}')",
               item.CATELOGE, item.UID, item.PASS, item.M2FA, item.COOKIE, item.TOKEN, item.COOKIELD, item.TOKENLD, item.EMAIL, item.PASSMAIL, item.NAMTAO, item.TEN, item.SINHNHAT, item.FRIEND, item.GROUP, item.GENDER, item.LIVE, item.PROXY, item.LASTACTIVE, item.CATELOGE, item.GHICHU, item.NGAYBU, item.TRANGTHAI);
                sqliteCommand.CommandText = text;
                sqliteCommand.ExecuteNonQuery();
            }
            trans.Commit();
            sw.Stop();
            min = sw.Elapsed.Minutes + " Phút " + sw.Elapsed.Seconds + " giây";
            sqliteConnection.Dispose();
        }

        public static void deleteuidtrung(string data)
        {
            string[] dat1 = data.Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
            SQLiteConnection sqliteConnection = new SQLiteConnection();
            sqliteConnection.ConnectionString = "Data Source=Data.sqlite3;Version=3;";
            sqliteConnection.Open();
            SQLiteCommand sqliteCommand = new SQLiteCommand(sqliteConnection);
            SQLiteTransaction trans = sqliteConnection.BeginTransaction();
            sqliteCommand.Transaction = trans;
            Stopwatch sw = new Stopwatch();
            sw.Start();
            for (int i = 0; i < dat1.Length; i++)
            {
                string[] dat2 = dat1[i].Split('|');
                string text = string.Format("DELETE FROM data where [UID]='{0}'", dat2[0]);
                sqliteCommand.CommandText = text;
                sqliteCommand.ExecuteNonQuery();

            }
            trans.Commit();
            sw.Stop();
            min = sw.Elapsed.Minutes + " Phút " + sw.Elapsed.Seconds + " giây";
            sqliteConnection.Dispose();
        }
        public List<String> getlistdanhmuc(string cateloge)
        {
            List<string> acc = new List<string>();
            try
            {


                SQLiteConnection sqliteConnection = new SQLiteConnection();
                sqliteConnection.ConnectionString = "Data Source=Data.sqlite3;Version=3;";
                sqliteConnection.Open();
                using (SQLiteConnection sqliteConnection2 = sqliteConnection)
                {
                    using (SQLiteCommand sqliteCommand = sqliteConnection2.CreateCommand())
                    {
                        sqliteCommand.CommandText = "SELECT * From [data]";
                        sqliteCommand.CommandType = CommandType.Text;
                        SQLiteDataReader sqliteDataReader = sqliteCommand.ExecuteReader();
                        bool flag;
                        while (flag = sqliteDataReader.Read())
                        {
                            if (sqliteDataReader["CATELOGE"].ToString() == cateloge)
                            {
                                acc.Add(sqliteDataReader["UID"].ToString());
                            }

                        }
                    }
                }
                sqliteConnection.Dispose();
            }
            catch
            {

            }


            return acc;
        }
    }
}
