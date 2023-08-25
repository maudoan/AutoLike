using AutoLike.Model;
using AutoLike.Utils;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoLike.Controller
{
    public class Form1Controller
    {
        private file _file;
        private account _account;
        private List<account> _listAccounts;
        private SQLiteUtils _sqliteUtils;
        private Form1 form1;

        public Form1Controller()
        {
            _file = new file();
            _account = new account();
            _listAccounts = new List<account>();
            _sqliteUtils = new SQLiteUtils();
        }

        public Boolean SelectFile()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text Files|*.txt";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string fullFilePath = openFileDialog.FileName;
                string fileName = Path.GetFileName(fullFilePath);
                _file.Name = fileName;
                SaveToDbFromImportFile(fullFilePath);
                return true;
            }
            return false;
        }

        public string GetSelectedFileName()
        {
            return _file.Name;
        }

        public void SaveToDbFromImportFile(String fullPath)
        {
            try
            {
                _listAccounts.Clear();
                using (StreamReader sr = new StreamReader(fullPath))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {

                        string[] elements = line.Split(new string[] { "//" }, StringSplitOptions.None);
                        _account.CATELOGE =elements.Length >=0 ? elements[0] : "";
                        _account.UID = elements.Length > 1 ? elements[1] : "";
                        _account.PASS = elements.Length > 2 ? elements[2] : "";
                        _account.M2FA = elements.Length > 3 ? elements[3] : "";
                        _account.COOKIE = elements.Length > 4 ? elements[4] : "";
                        _account.TOKEN = elements.Length > 5 ? elements[5] : "";
                        _account.COOKIELD = elements.Length > 6 ? elements[6] : "";
                        _account.TOKENLD = elements.Length > 7 ? elements[7] : "";
                        _account.EMAIL = elements.Length > 8 ? elements[8] : "";
                        _account.PASSMAIL = elements.Length > 9 ? elements[9] : "";
                        _account.NAMTAO = elements.Length > 10 ? elements[10] : "";
                        _account.TEN = elements.Length > 11 ? elements[11] : "";
                        _account.SINHNHAT = elements.Length > 12 ? elements[12] : "";
                        _account.FRIEND = elements.Length > 13 ? elements[13] : "";
                        _account.GROUP = elements.Length > 14 ? elements[14] : "";
                        _account.GENDER = elements.Length > 15 ? elements[15] : "";
                        _account.LIVE = elements.Length > 16 ? elements[16] : "";
                        _account.PROXY = elements.Length > 17 ? elements[17] : "";
                        _account.LASTACTIVE = elements.Length > 18 ? elements[18] : "";
                        _account.DANHMUC = elements.Length > 19 ? elements[19] : "";
                        _account.GHICHU = elements.Length > 20 ? elements[20] : "";
                        _account.NGAYBU = elements.Length > 21 ? elements[21] : "";
                        _account.TRANGTHAI = elements.Length > 22 ? elements[22] : "";

                        _listAccounts.Add( _account );
                    }
                }
                _sqliteUtils.insertListAccount(_listAccounts);
                if (_sqliteUtils.checkExitsCategory(_listAccounts[0].CATELOGE) == false)
                {
                    _sqliteUtils.addCategory(_listAccounts[0].CATELOGE);
                }




            }
            catch (Exception ex)
            {
               
                Console.WriteLine("Lỗi khi đọc tệp: " + ex.Message);
            }

        }

        public void  LoadFileAccount(DataGridView dataGridView)
        {
            List<string> dm = _sqliteUtils.getListCategory("DM");
            for (int i = 0; i < dm.Count; i++)
            {
                 dataGridView.Rows.Add(dm[i]);
            }
        }

        public List<string> getListAccount(string fileName, DataGridView dataGridView)
        {

            List<string> list = new List<string>();
            if (fileName == "ALL")
            {
                //for (int i1 = 0; i1 < listFileDataGridView.Rows.Count; i1++)
                //{
                //    List<string> list1 = FBAutoKitDo.SQLite.getlistac(dataGridView6.Rows[i1].Cells[0].Value.ToString());
                //    for (int i2 = 0; i2 < list1.Count; i2++)
                //    {
                //        list.Add(list1[i2]);
                //    }
                //}
            }
            else
            {
                list = _sqliteUtils.getlistAccount(fileName);
            }

            dataGridView.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.EnableResizing;
            int rowCount = dataGridView.Rows.Count;

            foreach (var item in list)
            {
                try
                {
                    string[] acc = item.Split('|');

                    StringBuilder sb = new StringBuilder();
                    sb.Append((rowCount + 1).ToString()).Append(",").Append(false);
                    for (int i = 0; i < 22; i++)
                    {
                        sb.Append(",").Append(i == 10 ? acc[10].Replace("\"", "'") : acc[i]);
                    }

                    int friend;
                    int.TryParse(acc[12], out friend);
                    sb.Append(",").Append(friend);

                    dataGridView.Rows.Add(sb.ToString().Split(','));

                    rowCount++;

                    DataGridViewRow row = dataGridView.Rows[rowCount - 1];
                    if (row.Cells["tinhtrangAccount"].Value.ToString().Contains("Die") || row.Cells["tinhtrangAccount"].Value.ToString().ToLower().Contains("check") || row.Cells["tinhtrangAccount"].Value.ToString().Contains("LỖI"))
                    {
                        row.DefaultCellStyle.BackColor = Color.FromArgb(248, 198, 198);
                    }
                    else
                    {
                        row.DefaultCellStyle.BackColor = Color.FromArgb(203, 245, 203);
                    }

                }
                catch (Exception ex) 
                {
                    Console.WriteLine(ex.Message);
                }
                
            }

            return list;

        }
    }
}
