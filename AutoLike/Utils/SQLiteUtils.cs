using AutoLike.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace AutoLike.Utils
{
    public class SQLiteUtils
    {
        public static string min;

        private static SQLiteConnection sqliteConnection;

        public SQLiteUtils()
        {

        }
        public void insertListAccount(List<account> listAccounts)
        {
            //deleteuidtrung(data);
            try
            {
                SQLiteConnection sqliteConnection = new SQLiteConnection();
                sqliteConnection.ConnectionString = "Data Source=Data.sqlite3;Version=3;";
                sqliteConnection.Open();
                SQLiteCommand sqliteCommand = new SQLiteCommand(sqliteConnection);
                SQLiteTransaction trans = sqliteConnection.BeginTransaction();
                sqliteCommand.Transaction = trans;
                Stopwatch sw = new Stopwatch();
                sw.Start();

                foreach (account item in listAccounts)
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
                Console.WriteLine("Đã Insert");
                //sqliteConnection.Dispose();
                sqliteConnection.Close();
            } catch(Exception e)
            {
                Console.WriteLine("Lỗi " + e.Message);
            }
            
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
        public List<String> getListCategory(string cateloge)
        {
            List<string> acc = new List<string>();
            try
            {

                string text = string.Format("SELECT * From data");
                SQLiteConnection sqliteConnection = new SQLiteConnection();
                sqliteConnection.ConnectionString = "Data Source=Data.sqlite3;Version=3;";
                sqliteConnection.Open();
                SQLiteCommand sqliteCommand = new SQLiteCommand(text, sqliteConnection);
                SQLiteDataReader sqliteDataReader = sqliteCommand.ExecuteReader();

                try
                {
                    while (sqliteDataReader.Read())
                    {
                        if (sqliteDataReader["CATELOGE"].ToString() == cateloge)
                        {
                            acc.Add(sqliteDataReader["DANHMUC"].ToString());
                        }

                    }
                }
                finally 
                {
                    sqliteDataReader.Close();

                    // Close the connection when done with it.
                    sqliteConnection.Close();
                }
               

                //sqliteConnection.Dispose();
            }
            catch
            {
                //SQLiteConnection sqliteConnection = new SQLiteConnection();
                //sqliteConnection.ConnectionString = "Data Source=Data.sqlite3;Version=3;";
                //sqliteConnection.Open();
                //string text = string.Format("CREATE TABLE data");
                //SQLiteCommand sqliteCommand = new SQLiteCommand(text, sqliteConnection);
                //sqliteCommand.ExecuteNonQuery();
                //sqliteConnection.Dispose();

            }


            return acc;
        }

        public void addCategory(string category)
        {

            string text = string.Format("INSERT INTO data ('CATELOGE', 'DANHMUC')" +
                " VALUES ('{0}','{1}')",
                "DM", category);
            SQLiteConnection sqliteConnection = new SQLiteConnection();
            sqliteConnection.ConnectionString = "Data Source=Data.sqlite3;Version=3;";
            sqliteConnection.Open();
            SQLiteCommand sqliteCommand = new SQLiteCommand(text, sqliteConnection);
            sqliteCommand.ExecuteNonQuery();
            Console.WriteLine("Đã ADD");
            sqliteConnection.Close();
        }

        public Boolean checkExitsCategory(string cateloge)
        {
            try
            {

                string text = string.Format("SELECT DANHMUC From [data] where [CATELOGE]='{0}'",
                       "DM");
                SQLiteConnection sqliteConnection = new SQLiteConnection();
                sqliteConnection.ConnectionString = "Data Source=Data.sqlite3;Version=3;";
                sqliteConnection.Open();
                SQLiteCommand sqliteCommand = new SQLiteCommand(text, sqliteConnection);
                SQLiteDataReader sqliteDataReader = sqliteCommand.ExecuteReader();

                try
                {
                    while (sqliteDataReader.Read())
                    {
                        if (sqliteDataReader["DANHMUC"].ToString() == cateloge)
                        {
                            return true;
                        }

                    }
                }
                finally
                {
                    sqliteDataReader.Close();

                    // Close the connection when done with it.
                    sqliteConnection.Close();
                }
                
                //sqliteConnection.Dispose();
            }
            catch(Exception e)
            {
                return false;
            }



            return false;
        }
    }
}
