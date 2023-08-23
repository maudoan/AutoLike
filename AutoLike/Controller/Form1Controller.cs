using AutoLike.Model;
using AutoLike.Utils;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
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
                
                using (StreamReader sr = new StreamReader(fullPath))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {

                        string[] elements = line.Split(new string[] { "//" }, StringSplitOptions.None);
                        _account.CATELOGE = elements[0];
                        _account.UID = elements.Length >= 0 ? elements[0] : "";
                        _account.PASS = elements.Length > 1 ? elements[1] : "";
                        _account.M2FA = elements.Length > 2 ? elements[2] : "";
                        _account.COOKIE = elements.Length > 3 ? elements[3] : "";
                        _account.TOKEN = elements.Length > 4 ? elements[4] : "";
                        _account.COOKIELD = elements.Length > 5 ? elements[5] : "";
                        _account.TOKENLD = elements.Length > 6 ? elements[6] : "";
                        _account.EMAIL = elements.Length > 7 ? elements[7] : "";
                        _account.PASSMAIL = elements.Length > 8 ? elements[8] : "";
                        _account.NAMTAO = elements.Length > 9 ? elements[9] : "";
                        _account.TEN = elements.Length > 10 ? elements[10] : "";
                        _account.SINHNHAT = elements.Length > 11 ? elements[11] : "";
                        _account.FRIEND = elements.Length > 12 ? elements[12] : "";
                        _account.GROUP = elements.Length > 13 ? elements[13] : "";
                        _account.GENDER = elements.Length > 14 ? elements[14] : "";
                        _account.LIVE = elements.Length > 15 ? elements[15] : "";
                        _account.PROXY = elements.Length > 16 ? elements[16] : "";
                        _account.LASTACTIVE = elements.Length > 17 ? elements[17] : "";
                        _account.DANHMUC = elements.Length > 18 ? elements[18] : "";
                        _account.GHICHU = elements.Length > 19 ? elements[19] : "";
                        _account.NGAYBU = elements.Length > 20 ? elements[20] : "";
                        _account.TRANGTHAI = elements.Length > 21 ? elements[21] : "";

                        _listAccounts.Clear();
                        _listAccounts.Add( _account );
                    }
                }
                _sqliteUtils.insertListAccount(_listAccounts);



            }
            catch (Exception ex)
            {
               
                Console.WriteLine("Lỗi khi đọc tệp: " + ex.Message);
            }

        }

        public List<String> LoadFileAccount()
        {
            List<string> dm = _sqliteUtils.getlistdanhmuc("DM");
            return dm;
        }
    }
}
