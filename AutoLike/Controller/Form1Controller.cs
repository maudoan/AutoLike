using AutoLike.Features;
using AutoLike.Model;
using AutoLike.Utils;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
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
        private ChromeDriverUtils _chormeDriverUtils;

        public Form1Controller()
        {
            _file = new file();
            _account = new account();
            _listAccounts = new List<account>();
            _sqliteUtils = new SQLiteUtils();
            _chormeDriverUtils = new ChromeDriverUtils();
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

        public void SaveToDbFromImportFile(string fullPath)
        {
            try
            {
                _listAccounts.Clear();
                using (StreamReader sr = new StreamReader(fullPath))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        account account = new account();
                        string[] elements = line.Split(new string[] { "//" }, StringSplitOptions.None);
                        account.CATELOGE =elements.Length >=0 ? elements[0] : "";
                        account.UID = elements.Length > 1 ? elements[1] : "";
                        account.PASS = elements.Length > 2 ? elements[2] : "";
                        account.M2FA = elements.Length > 3 ? elements[3] : "";
                        account.COOKIE = elements.Length > 4 ? elements[4] : "";
                        account.TOKEN = elements.Length > 5 ? elements[5] : "";
                        account.COOKIELD = elements.Length > 6 ? elements[6] : "";
                        account.TOKENLD = elements.Length > 7 ? elements[7] : "";
                        account.EMAIL = elements.Length > 8 ? elements[8] : "";
                        account.PASSMAIL = elements.Length > 9 ? elements[9] : "";
                        account.NAMTAO = elements.Length > 10 ? elements[10] : "";
                        account.TEN = elements.Length > 11 ? elements[11] : "";
                        account.SINHNHAT = elements.Length > 12 ? elements[12] : "";
                        account.FRIEND = elements.Length > 13 ? elements[13] : "";
                        account.GROUP = elements.Length > 14 ? elements[14] : "";
                        account.GENDER = elements.Length > 15 ? elements[15] : "";
                        account.LIVE = elements.Length > 16 ? elements[16] : "";
                        account.PROXY = elements.Length > 17 ? elements[17] : "";
                        account.LASTACTIVE = elements.Length > 18 ? elements[18] : "";
                        account.DANHMUC = elements.Length > 19 ? elements[19] : "";
                        account.GHICHU = elements.Length > 20 ? elements[20] : "";
                        account.NGAYBU = elements.Length > 21 ? elements[21] : "";
                        account.TRANGTHAI = elements.Length > 22 ? elements[22] : "";

                        _listAccounts.Add(account);
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

        public async void LoginChromeWithCookieToken(string ProfileFolderPath, DataGridView dataGridView, NumericUpDown flowNum, ComboBox selectProxy)
        {

            List<account> danhSach = new List<account>(); 

            for(int i = 0;i < dataGridView.Rows.Count;i++)
            {
                if(dataGridView.Rows[i].Cells["checkboxItemAccount"].Value.ToString() == "True")
                {
                    account acc = new account();
                    acc.UID = dataGridView.Rows[i].Cells["uidAccount"].Value.ToString();
                    acc.PASS = dataGridView.Rows[i].Cells["passAccount"].Value.ToString();
                    acc.M2FA = dataGridView.Rows[i].Cells["code2faAccount"].Value.ToString();
                    danhSach.Add(acc);
                }
            }

           await ProcessLoginChromeCookieToke(ProfileFolderPath, dataGridView, flowNum, selectProxy, danhSach);
        }

        public async Task ProcessLoginChromeCookieToke(string ProfileFolderPath, DataGridView dataGridView, NumericUpDown flowNum, ComboBox selectProxy, List<account> listAcccounts)
        {
            int maxConcurrency = 5; // Số lượng luồng tối đa được sử dụng
            int batchSize = 10; // Số lượng phần tử mỗi lần xử lý
            int indexItem = 0;
            var semaphore = new SemaphoreSlim(maxConcurrency);
            var completedItems = new List<account>();

            async Task ProcessBatchAsync(List<account> batch)
            {
                foreach (var item in batch)
                {
                    indexItem++;
                    // Thực hiện công việc của bạn trên item ở đây
                    ChromeDriver chromeDriver = _chormeDriverUtils.initChrome(ProfileFolderPath, item, indexItem, flowNum, selectProxy);
                    chromeDriver.Navigate().GoToUrl("https://www.facebook.com");
                    await Task.Delay(1000);
               
                    Login.loginWithUID(chromeDriver, item);

                    await Task.Delay(1000); // Ví dụ: Giả định công việc mất 1 giây để hoàn thành.

                    // Sau khi hoàn thành công việc, thêm item này vào danh sách đã hoàn thành
                    completedItems.Add(item);
                }
            }

            var batches = listAcccounts
                .Select((item, index) => new { Item = item, Index = index })
                .GroupBy(x => x.Index / batchSize)
                .Select(group => group.Select(x => x.Item).ToList())
                .ToList();

            var tasks = new List<Task>();

            foreach (var batch in batches)
            {
                await semaphore.WaitAsync(); // Chờ để lấy quyền sử dụng luồng
                tasks.Add(Task.Run(async () =>
                {
                    try
                    {
                        await ProcessBatchAsync(batch);
                    }
                    finally
                    {
                        semaphore.Release(); // Hoàn thành công việc, giải phóng luồng
                    }
                }));
            }

            await Task.WhenAll(tasks);

            // Xử lý các item còn lại sau khi tất cả các batch đã hoàn thành
            var remainingItems = listAcccounts.Except(completedItems).ToList();
            foreach (var item in remainingItems)
            {
                // Thực hiện xử lý cho các item còn lại ở đây
                indexItem++;
                ChromeDriver chromeDriver = _chormeDriverUtils.initChrome(ProfileFolderPath, item, indexItem, flowNum, selectProxy);
                await Task.Delay(1000); // Ví dụ: Giả định công việc mất 1 giây để hoàn thành.
            }


            // Khi tất cả công việc đã hoàn thành
            Console.WriteLine("ALl TASK DONE!!!");
        }
    }
}
