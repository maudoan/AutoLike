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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Header;

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
                        account.CATELOGE = elements.Length >= 0 ? elements[0] : "";
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
                        account.SOPAGE = elements.Length > 23 ? elements[23] : "";

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

        public void LoadFileAccount(DataGridView dataGridView)
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
                    for (int i = 0; i < 23; i++)
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

        /*
         * 
         * Feature Create Profile
         * 
         */

        /*
         * init Login
         */
        public void LoginChromeWithCookieToken(string ProfileFolderPath, DataGridView dataGridView, NumericUpDown flowNum, ComboBox selectProxy, List<string> apiKeyList)
        {

            List<account> danhSach = new List<account>();

            for (int i = 0; i < dataGridView.Rows.Count; i++)
            {
                if (dataGridView.Rows[i].Cells["checkboxItemAccount"].Value.ToString() == "True")
                {
                    account acc = new account();
                    acc.UID = dataGridView.Rows[i].Cells["uidAccount"].Value.ToString();
                    acc.PASS = dataGridView.Rows[i].Cells["passAccount"].Value.ToString();
                    acc.M2FA = dataGridView.Rows[i].Cells["code2faAccount"].Value.ToString();
                    danhSach.Add(acc);
                }
            }

            ProcessLoginChromeCookieToken(ProfileFolderPath, dataGridView, flowNum, selectProxy, danhSach, apiKeyList);
        }

        /*
         * Process Login
         */
        public async void ProcessLoginChromeCookieToken(string ProfileFolderPath, DataGridView dataGridView, NumericUpDown flowNum, ComboBox selectProxy, List<account> listAcccounts, List<string> apiKeyList)
        {
            int maxThreads = 5; // Số lượng luồng tối đa
            int itemindex = 0;
            ProxyUtils proxyUtils = new ProxyUtils();
         
            if (apiKeyList.Count > 0)
            {
                for(int i = 0; i < apiKeyList.Count; i++)
                {
                    await proxyUtils.getNewProxy(Constants.Constants.GetNewProxyShopLike(apiKeyList[i]));
                }
                
            }

            var cancellationTokenSource = new CancellationTokenSource();
            var cancellationToken = cancellationTokenSource.Token;

            // Sử dụng Semaphore để giới hạn số lượng luồng được tạo ra đồng thời
            SemaphoreSlim semaphore = new SemaphoreSlim(maxThreads, maxThreads);

            List<Task> tasks = new List<Task>();

            foreach (var item in listAcccounts)
            {
                itemindex++;
                Random random = new Random();

                // Lấy một phần tử ngẫu nhiên từ danh sách
                int index = random.Next(apiKeyList.Count);
                string randomKey = apiKeyList[index];
                string proxy = await proxyUtils.getCurrentProxy(Constants.Constants.GetCurrentProxyShopLike(randomKey, "hd"));
                item.PROXY = proxy;
                await semaphore.WaitAsync(); // Chờ cho đến khi có sẵn slot trong Semaphore
                Task task = Task.Run(() => ProcessItemLoginAcc(ProfileFolderPath, item, itemindex, flowNum, selectProxy), cancellationToken)
                    .ContinueWith((t) => semaphore.Release()); // Giải phóng slot khi hoàn thành

                tasks.Add(task);
            }

            // Đợi tất cả các công việc hoàn thành (tất cả item đã xử lý)
            await Task.WhenAll(tasks);

            Console.WriteLine("DONE ALL TASK!!!");

        }

        /*
        * Process Login with item Account
        */
        public void ProcessItemLoginAcc(string ProfileFolderPath, account item, int itemindex, NumericUpDown flowNum, ComboBox selectProxy)
        {

            ChromeDriver chromeDriver = _chormeDriverUtils.initChrome(ProfileFolderPath, item, itemindex, flowNum, selectProxy);
            chromeDriver.Navigate().GoToUrl("https://www.facebook.com");
            Thread.Sleep(1000);

            if (ChromeDriverUtils.FindClickElementInChrome(chromeDriver, "Đăng nhập", "Log in", false))
            {
                Login.LoginWithUID(chromeDriver, item);
            }
            else if (ChromeDriverUtils.FindTextInChrome(chromeDriver, "Trang chủ", "Home"))
            {
                try
                {
                    string cookie = ChromeDriverUtils.getcookie(chromeDriver);
                    if (cookie != null)
                    {
                        item.COOKIE = cookie;
                    }
                }
                catch { }
            }

            Thread.Sleep(1000);

            try
            {
                if (ChromeDriverUtils.FindTextInChrome(chromeDriver, "Quên mật khẩu?", "Password") ||
                ChromeDriverUtils.FindTextInChrome(chromeDriver, "mật khẩu cũ", "old"))
                {
                    item.TRANGTHAI = "Sai password....";
                    ChromeDriverUtils.ChromeDetroy(chromeDriver);
                }
                else if (ChromeDriverUtils.FindTextInChrome(chromeDriver, "tạm thời bị khóa", "lock"))
                {
                    item.LIVE = "Checkpoint";
                    item.TRANGTHAI = "Tạm thời bị khóa !...";
                    ChromeDriverUtils.ChromeDetroy(chromeDriver);

                }
                else if (ChromeDriverUtils.FindTextInChrome(chromeDriver, "chúng tôi đã đình chỉ tài khoản của bạn", "We suspend"))
                {
                    item.LIVE = "Checkpoint";
                    item.TRANGTHAI = "Đình chỉ tài khoản !...";
                    ChromeDriverUtils.ChromeDetroy(chromeDriver);
                }
                else if(ChromeDriverUtils.FindTextInChrome(chromeDriver, "chúng tôi cần xác nhận rằng tài khoản này thuộc về bạn", "We need to confirm"))
                {
                    item.LIVE = "Checkpoint";
                    item.TRANGTHAI = "Xác nhận tài khoản !...";
                    ChromeDriverUtils.ChromeDetroy(chromeDriver);
                }
                else if (ChromeDriverUtils.FindTextInChrome(chromeDriver, "Trang chủ", "Home"))
                {
                    try
                    {
                        string cookie = ChromeDriverUtils.getcookie(chromeDriver);
                        if (cookie != null)
                        {
                            item.COOKIE = cookie;
                        }

                    }
                    catch { }

                    item.LIVE = "Live";
                    item.TRANGTHAI = "Login Facebook thành công !...";
                    ChromeDriverUtils.ChromeDetroy(chromeDriver);
                }
            }
            catch
            {
                if (chromeDriver.FindElement(By.XPath("/html/body/div[1]/div[2]/div[1]/div/div[2]/div[2]/form/div[1]/div[1]")).Text.Contains("mật khẩu"))
                {

                    item.TRANGTHAI = "Sai Password!...";
                    ChromeDriverUtils.ChromeDetroy(chromeDriver);
                }
            }

            SQLiteUtils.updateByUID(item);
            Console.WriteLine($"Processing item: {item}");
        }

        /*
        * chia nhỏ Item
        */

        public static IEnumerable<List<T>> PartitionList<T>(List<T> source, int batchSize)
        {
            for (int i = 0; i < source.Count; i += batchSize)
            {
                yield return source.GetRange(i, Math.Min(batchSize, source.Count - i));
            }
        }

        /*
         * 
         * Feature Reg Page
         * 
         * 
         */

        string fullPathNamePage = string.Empty;

        /*
         * Select path File Name Page
         */
        public string selectFileNamePage()
        {
            var fullFilePath = string.Empty;
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text Files|*.txt";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                fullFilePath = openFileDialog.FileName;
                fullPathNamePage = fullFilePath;
                return fullFilePath;
            }
            return fullFilePath;
        }

        /*
         * Get random Name Page
         */
        public string getNamePage()
        {
            var namePage = string.Empty;
            if (!string.IsNullOrEmpty(fullPathNamePage))
            {
                List<string> lines = File.ReadAllLines(fullPathNamePage).ToList();

                // Kiểm tra xem tệp tin có dòng nào không
                if (lines.Count == 0)
                {
                    Console.WriteLine("Tệp tin trống.");
                }

                // Sử dụng một số ngẫu nhiên để chọn một dòng ngẫu nhiên
                Random rng = new Random();
                int randomIndex = rng.Next(0, lines.Count);
                namePage = lines[randomIndex];
            }
           
            return namePage;
        }
        
        /*
         * init regPage
         */

        public void regPage(string ProfileFolderPath, DataGridView dataGridView, NumericUpDown flowNum, ComboBox selectProxy, List<string> apiKeyList)
        {

            List<account> danhSach = new List<account>();

            for (int i = 0; i < dataGridView.Rows.Count; i++)
            {
                if (dataGridView.Rows[i].Cells["checkboxItemAccount"].Value.ToString() == "True")
                {
                    account acc = new account();
                    acc.UID = dataGridView.Rows[i].Cells["uidAccount"].Value.ToString();
                    acc.PASS = dataGridView.Rows[i].Cells["passAccount"].Value.ToString();
                    acc.M2FA = dataGridView.Rows[i].Cells["code2faAccount"].Value.ToString();
                    acc.LIVE = dataGridView.Rows[i].Cells["tinhtrangAccount"].Value.ToString();
                    acc.PROXY = dataGridView.Rows[i].Cells["proxyAccount"].Value.ToString();
                    acc.TRANGTHAI = dataGridView.Rows[i].Cells["trangthaiAccount"].Value.ToString();
                    acc.SOPAGE = dataGridView.Rows[i].Cells["pageNumberAccount"].Value.ToString();
                    danhSach.Add(acc);
                }
            }

            ProcessRegPage(ProfileFolderPath, dataGridView, flowNum, selectProxy, danhSach, apiKeyList);
        }

        /*
         * Process Reg Page
         */

        public async void ProcessRegPage(string ProfileFolderPath, DataGridView dataGridView, NumericUpDown flowNum, ComboBox selectProxy, List<account> listAcccounts, List<string> apiKeyList)
        {
            int maxThreads = 5; // Số lượng luồng tối đa
            int itemindex = 0;
            ProxyUtils proxyUtils = new ProxyUtils();

            if (apiKeyList.Count > 0)
            {
                for (int i = 0; i < apiKeyList.Count; i++)
                {
                    await proxyUtils.getNewProxy(Constants.Constants.GetNewProxyShopLike(apiKeyList[i]));
                }

            }

            var cancellationTokenSource = new CancellationTokenSource();
            var cancellationToken = cancellationTokenSource.Token;

            // Sử dụng Semaphore để giới hạn số lượng luồng được tạo ra đồng thời
            SemaphoreSlim semaphore = new SemaphoreSlim(maxThreads, maxThreads);

            List<Task> tasks = new List<Task>();

            foreach (var item in listAcccounts)
            {
                itemindex++;
                Random random = new Random();

                // Lấy một phần tử ngẫu nhiên từ danh sách
                int index = random.Next(apiKeyList.Count);
                string randomKey = apiKeyList[index];
                string proxy = await proxyUtils.getCurrentProxy(Constants.Constants.GetCurrentProxyShopLike(randomKey, "hd"));
                item.PROXY = proxy;
                await semaphore.WaitAsync(); // Chờ cho đến khi có sẵn slot trong Semaphore
                Task task = Task.Run(() => processItemRegPageAcc(ProfileFolderPath, item, itemindex, flowNum, selectProxy, dataGridView), cancellationToken)
                    .ContinueWith((t) => semaphore.Release()); // Giải phóng slot khi hoàn thành

                tasks.Add(task);
            }

            // Đợi tất cả các công việc hoàn thành (tất cả item đã xử lý)
            await Task.WhenAll(tasks);

            Console.WriteLine("DONE ALL TASK!!!");

        }

        /*
         * Process Reg Page for Item Acc
         */
        public void processItemRegPageAcc(string ProfileFolderPath, account item, int itemindex, NumericUpDown flowNum, ComboBox selectProxy,DataGridView dataGridView)
        {

            ChromeDriver chromeDriver = _chormeDriverUtils.initChrome(ProfileFolderPath, item, itemindex, flowNum, selectProxy);      
            Thread.Sleep(1000);
            RegPage regPage = new RegPage();
            regPage.RegPageWithUID(chromeDriver, fullPathNamePage,dataGridView,item);

            SQLiteUtils.updateByUID(item);
            Console.WriteLine($"Processing item: {item}");
        }
    }
}
