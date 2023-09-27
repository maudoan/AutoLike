using AutoLike.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Diagnostics;
using System.Threading;

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
            deleteuidtrung(listAccounts);
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
                   "'GENDER','LIVE','PROXY','LASTACTIVE','DANHMUC','GHICHU','NGAYBU','TRANGTHAI','SOPAGE')" +
                   " VALUES ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}','{12}','{13}','{14}','{15}','{16}','{17}','{18}','{19}','{20}','{21}','{22}','{23}')",
                   item.CATELOGE, item.UID, item.PASS, item.M2FA, item.COOKIE, item.TOKEN, item.COOKIELD, item.TOKENLD, item.EMAIL, item.PASSMAIL, item.NAMTAO, item.TEN, item.SINHNHAT, item.FRIEND, item.GROUP, item.GENDER, item.LIVE, item.PROXY, item.LASTACTIVE, item.CATELOGE, item.GHICHU, item.NGAYBU, item.TRANGTHAI, item.SOPAGE);
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

        public static void deleteuidtrung(List<account> listAccounts)
        {
            SQLiteConnection sqliteConnection = new SQLiteConnection();
            sqliteConnection.ConnectionString = "Data Source=Data.sqlite3;Version=3;";
            sqliteConnection.Open();
            SQLiteCommand sqliteCommand = new SQLiteCommand(sqliteConnection);
            SQLiteTransaction trans = sqliteConnection.BeginTransaction();
            sqliteCommand.Transaction = trans;
            Stopwatch sw = new Stopwatch();
            sw.Start();
            for (int i = 0; i < listAccounts.Count; i++)
            {
                string text = string.Format("DELETE FROM data where [UID]='{0}'", listAccounts[i].UID);
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

        
        public List<string> getlistAccount(string cateloge)
        {

          
                List<string> acc = new List<string>();

                SQLiteConnection sqliteConnection = new SQLiteConnection();
                sqliteConnection.ConnectionString = "Data Source=Data.sqlite3;Version=3;";
                sqliteConnection.Open();
                SQLiteCommand sqliteCommand = sqliteConnection.CreateCommand();

                sqliteCommand.CommandText = "SELECT * From [data]";
                sqliteCommand.CommandType = CommandType.Text;
                SQLiteDataReader sqliteDataReader = sqliteCommand.ExecuteReader();
                while (sqliteDataReader.Read())
                {

                    if (sqliteDataReader["CATELOGE"].ToString() == cateloge)
                    {
                        acc.Add(sqliteDataReader["UID"].ToString() + "|" +
                       sqliteDataReader["PASS"].ToString() + "|" +
                       sqliteDataReader["2FA"].ToString() + "|" +
                       sqliteDataReader["COOKIE"].ToString() + "|" +
                       sqliteDataReader["TOKEN"].ToString() + "|" +
                       sqliteDataReader["COOKIELD"].ToString() + "|" +
                        sqliteDataReader["TOKENLD"].ToString() + "|" +
                         sqliteDataReader["EMAIL"].ToString() + "|" +
                          sqliteDataReader["PASSMAIL"].ToString().Replace("\r", "").Replace("\n", "") + " | " +
                           sqliteDataReader["NAMTAO"].ToString() + "|" +
                            sqliteDataReader["TEN"].ToString() + "|" +
                             sqliteDataReader["SINHNHAT"].ToString() + "|" +
                              sqliteDataReader["FRIEND"].ToString() + "|" +
                               sqliteDataReader["GROUP"].ToString() + "|" +
                               sqliteDataReader["GENDER"].ToString() + "|" +
                               sqliteDataReader["LIVE"].ToString() + "|" +
                               sqliteDataReader["PROXY"].ToString() + "|" +
                               sqliteDataReader["LASTACTIVE"].ToString() + "|" +
                               sqliteDataReader["CATELOGE"].ToString() + "|" +
                               sqliteDataReader["GHICHU"].ToString() + "|" +
                                sqliteDataReader["NGAYBU"].ToString() + "|" +
                               sqliteDataReader["TRANGTHAI"].ToString() + "|" +
                               sqliteDataReader["SOPAGE"].ToString()
                       );
                    }


                }
                sqliteDataReader.Close();
                sqliteConnection.Close();
                return acc; 
        }

        public List<string> getAllAccount(string cateloge)
        {


            List<string> acc = new List<string>();

            SQLiteConnection sqliteConnection = new SQLiteConnection();
            sqliteConnection.ConnectionString = "Data Source=Data.sqlite3;Version=3;";
            sqliteConnection.Open();
            SQLiteCommand sqliteCommand = sqliteConnection.CreateCommand();

            sqliteCommand.CommandText = "SELECT * From [data]";
            sqliteCommand.CommandType = CommandType.Text;
            SQLiteDataReader sqliteDataReader = sqliteCommand.ExecuteReader();
            while (sqliteDataReader.Read())
            {

                if (sqliteDataReader["CATELOGE"].ToString() != cateloge)
                {
                    acc.Add(sqliteDataReader["UID"].ToString() + "|" +
                   sqliteDataReader["PASS"].ToString() + "|" +
                   sqliteDataReader["2FA"].ToString() + "|" +
                   sqliteDataReader["COOKIE"].ToString() + "|" +
                   sqliteDataReader["TOKEN"].ToString() + "|" +
                   sqliteDataReader["COOKIELD"].ToString() + "|" +
                    sqliteDataReader["TOKENLD"].ToString() + "|" +
                     sqliteDataReader["EMAIL"].ToString() + "|" +
                      sqliteDataReader["PASSMAIL"].ToString().Replace("\r", "").Replace("\n", "") + " | " +
                       sqliteDataReader["NAMTAO"].ToString() + "|" +
                        sqliteDataReader["TEN"].ToString() + "|" +
                         sqliteDataReader["SINHNHAT"].ToString() + "|" +
                          sqliteDataReader["FRIEND"].ToString() + "|" +
                           sqliteDataReader["GROUP"].ToString() + "|" +
                           sqliteDataReader["GENDER"].ToString() + "|" +
                           sqliteDataReader["LIVE"].ToString() + "|" +
                           sqliteDataReader["PROXY"].ToString() + "|" +
                           sqliteDataReader["LASTACTIVE"].ToString() + "|" +
                           sqliteDataReader["CATELOGE"].ToString() + "|" +
                           sqliteDataReader["GHICHU"].ToString() + "|" +
                            sqliteDataReader["NGAYBU"].ToString() + "|" +
                           sqliteDataReader["TRANGTHAI"].ToString() + "|" +
                           sqliteDataReader["SOPAGE"].ToString()
                   );
                }


            }
            sqliteDataReader.Close();
            sqliteConnection.Close();
            return acc;
        }

        public static void updateByUID(account item)
        {
            while (true)
            {
                Thread.Sleep(1);
                try
                {
                    string text = string.Format("UPDATE data set COOKIE='{0}',PROXY='{1}', LIVE='{2}', TRANGTHAI='{3}', SOPAGE='{4}' where UID='{5}'", item.COOKIE,item.PROXY, item.LIVE,item.TRANGTHAI,item.SOPAGE, item.UID);
                    SQLiteConnection sqliteConnection = new SQLiteConnection();
                    sqliteConnection.ConnectionString = "Data Source=Data.sqlite3;Version=3;";
                    sqliteConnection.Open();
                    SQLiteCommand sqliteCommand = new SQLiteCommand(text, sqliteConnection);
                    sqliteCommand.ExecuteNonQuery();
                    sqliteConnection.Dispose();
                    break;
                }
                catch { }
            }
        }

        public static void insertPage(List<page> listPage)
        {
            deletePageExisted(listPage);
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

                foreach (page item in listPage)
                {
                    string text = string.Format("INSERT INTO page ('PAGEID','UID','NAME') VALUES ('{0}', '{1}', '{2}')", item.PAGEID, item.UID, item.NAME);
                    sqliteCommand.CommandText = text;
                    sqliteCommand.ExecuteNonQuery();
                }
                trans.Commit();
                sw.Stop();
                min = sw.Elapsed.Minutes + " Phút " + sw.Elapsed.Seconds + " giây";
                Console.WriteLine("Đã Insert");
                //sqliteConnection.Dispose();
                sqliteConnection.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Lỗi " + e.Message);
            }

        }

        public static void deletePageExisted(List<page> listPage)
        {
            SQLiteConnection sqliteConnection = new SQLiteConnection();
            sqliteConnection.ConnectionString = "Data Source=Data.sqlite3;Version=3;";
            sqliteConnection.Open();
            SQLiteCommand sqliteCommand = new SQLiteCommand(sqliteConnection);
            SQLiteTransaction trans = sqliteConnection.BeginTransaction();
            sqliteCommand.Transaction = trans;
            Stopwatch sw = new Stopwatch();
            sw.Start();
            for (int i = 0; i < listPage.Count; i++)
            {
                string text = string.Format("DELETE FROM page where [PAGEID]='{0}'", listPage[i].PAGEID);
                sqliteCommand.CommandText = text;
                sqliteCommand.ExecuteNonQuery();
                
            }
            trans.Commit();
            sw.Stop();
            min = sw.Elapsed.Minutes + " Phút " + sw.Elapsed.Seconds + " giây";
            sqliteConnection.Dispose();
        }

        public static List<string> getPageListByUid(account acc)
        {

            List<string> listPage = new List<string>();

            SQLiteConnection sqliteConnection = new SQLiteConnection();
            sqliteConnection.ConnectionString = "Data Source=Data.sqlite3;Version=3;";
            sqliteConnection.Open();
            SQLiteCommand sqliteCommand = sqliteConnection.CreateCommand();
            string text = string.Format("SELECT * From [page] where [UID] = '{0}'", acc.UID);
            sqliteCommand.CommandText = text;
            sqliteCommand.CommandType = CommandType.Text;
            SQLiteDataReader sqliteDataReader = sqliteCommand.ExecuteReader();
            while (sqliteDataReader.Read())
            {

                if (sqliteDataReader["UID"].ToString() == acc.UID)
                {
                    listPage.Add(sqliteDataReader["PAGEID"].ToString() + "|" +
                    sqliteDataReader["UID"].ToString() + "|" +
                    sqliteDataReader["NAME"].ToString()

                   );
                }


            }


            return listPage;
        }

        public static void insertPost(List<post> listPost)
        {
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

                foreach (post item in listPost)
                {
                    string text = string.Format("INSERT INTO post ('POSTID','PAGEID') VALUES ('{0}', '{1}')", item.POSTID, item.PAGEID);
                    sqliteCommand.CommandText = text;
                    sqliteCommand.ExecuteNonQuery();
                }
                trans.Commit();
                sw.Stop();
                min = sw.Elapsed.Minutes + " Phút " + sw.Elapsed.Seconds + " giây";
                Console.WriteLine("Đã Insert");
                //sqliteConnection.Dispose();
                sqliteConnection.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Lỗi " + e.Message);
            }

        }

        public static void deleteAllItemByCateloge(string cateloge)
        {

            SQLiteConnection sqliteConnection = new SQLiteConnection();
            sqliteConnection.ConnectionString = "Data Source=Data.sqlite3;Version=3;";
            sqliteConnection.Open();
            SQLiteCommand sqliteCommand = new SQLiteCommand(sqliteConnection);
            SQLiteTransaction trans = sqliteConnection.BeginTransaction();
            sqliteCommand.Transaction = trans;
            Stopwatch sw = new Stopwatch();
            sw.Start();

            int count = 0;



            while (true)
            {
                sqliteCommand.CommandText = "SELECT COUNT(*) From [data] where [DANHMUC] ='" + cateloge + "'";
                sqliteCommand.CommandType = CommandType.Text;
                count = Convert.ToInt32(sqliteCommand.ExecuteScalar());
                if (count > 0)
                {
                    try
                    {
                        string text = string.Format("DELETE FROM data where [DANHMUC]='{0}'", cateloge);
                        sqliteCommand.CommandText = text;
                        sqliteCommand.ExecuteNonQuery();
                    }
                    catch { break; }
                }
                else { break; }

            }
            trans.Commit();
            sw.Stop();
            min = sw.Elapsed.Minutes + " Phút " + sw.Elapsed.Seconds + " giây";
            sqliteConnection.Dispose();
            Console.WriteLine("Đã Xóa DANHMUC");
        }
    }
}
