using AutoLike.Features;
using AutoLike.Model;
using AutoLike.Utils;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.DevTools;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Header;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace AutoLike.Controller
{
    public class Form1Controller
    {
        private file _file;
        private account _account;
        private List<account> _listAccounts;
        private SQLiteUtils _sqliteUtils;
        private Form1 form1;
        private ChromeDriverUtils _chromeDriverUtils;
        List<ChromeDriver> _listDriver = new List<ChromeDriver>();
        Dictionary<string,ChromeDriver> _dictionaryDriver = new Dictionary<string,ChromeDriver>();

        public Form1Controller()
        {
            _file = new file();
            _account = new account();
            _listAccounts = new List<account>();
            _sqliteUtils = new SQLiteUtils();
            _chromeDriverUtils = new ChromeDriverUtils();
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

        public void loadGeneralSetting(TextBox profileFolderPath, ComboBox selectProxy,TextBox apiKeyTextBox)
        {
            if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\AutoLike\GeneralSetting.txt"))
            {
                string[] dt = File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\AutoLike\GeneralSetting.txt").Split('|');
                try
                {
                    selectProxy.SelectedItem = dt[0];
                    profileFolderPath.Text = dt[1];
                    apiKeyTextBox.Text = dt[2];
                }
                catch { }
            }
        }

        /*
         * 
         * Feature Get INFO
         * 
         */

        public void getInfoAccounts(DataGridView dataGridView)
        {
            List<account> danhSach = new List<account>();

            for (int i = 0; i < dataGridView.Rows.Count; i++)
            {
                if (dataGridView.Rows[i].Cells["checkboxItemAccount"].Value.ToString() == "True" && dataGridView.Rows[i].Cells["tinhtrangAccount"].Value.ToString() == "Live")
                {
                    account acc = new account();
                    acc.UID = dataGridView.Rows[i].Cells["uidAccount"].Value.ToString();
                    acc.COOKIE = dataGridView.Rows[i].Cells["cookieAccount"].Value.ToString();
                    acc.TOKEN = dataGridView.Rows[i].Cells["tokenAccount"].Value.ToString();
                    acc.PASS = dataGridView.Rows[i].Cells["passAccount"].Value.ToString();
                    acc.M2FA = dataGridView.Rows[i].Cells["code2faAccount"].Value.ToString();
                    acc.LIVE = dataGridView.Rows[i].Cells["tinhtrangAccount"].Value.ToString();
                    acc.PROXY = dataGridView.Rows[i].Cells["proxyAccount"].Value.ToString();
                    acc.TRANGTHAI = dataGridView.Rows[i].Cells["trangthaiAccount"].Value.ToString();
                    acc.SOPAGE = dataGridView.Rows[i].Cells["pageNumberAccount"].Value.ToString();
                    danhSach.Add(acc);
                }
              
            }
                
            List<page> listPage = new List<page>();
     
            foreach(account item in danhSach)
            {
                Dictionary<string,string> listIdGroup = FacebookUtils.getListPage(item.COOKIE, "","");
                if(listIdGroup != null && listIdGroup.Count > 0)
                {
                    item.SOPAGE = listIdGroup.Count.ToString();
                    
                    SQLiteUtils.updateByUID(item);
                    foreach (var kvp in listIdGroup)
                    {
                        string key = kvp.Key;
                        string value = kvp.Value;
                        page page = new page();
                        page.UID = item.UID;
                        page.PAGEID = key;
                        page.NAME = value;
                        listPage.Add(page);
                    }
                }    
            }

            SQLiteUtils.insertPage(listPage);

        }

        /*
         * 
         * Feature get AccessTokenEAAG
         * 
         */


        public void getAccessTokenEAAG(DataGridView dataGridView)
        {
            List<account> danhSach = new List<account>();

            for (int i = 0; i < dataGridView.Rows.Count; i++)
            {
                if (dataGridView.Rows[i].Cells["checkboxItemAccount"].Value.ToString() == "True" && dataGridView.Rows[i].Cells["tinhtrangAccount"].Value.ToString() == "Live")
                {
                    account acc = new account();
                    acc.UID = dataGridView.Rows[i].Cells["uidAccount"].Value.ToString();
                    acc.COOKIE = dataGridView.Rows[i].Cells["cookieAccount"].Value.ToString();
                    acc.TOKEN = dataGridView.Rows[i].Cells["tokenAccount"].Value.ToString();
                    acc.PASS = dataGridView.Rows[i].Cells["passAccount"].Value.ToString();
                    acc.M2FA = dataGridView.Rows[i].Cells["code2faAccount"].Value.ToString();
                    acc.LIVE = dataGridView.Rows[i].Cells["tinhtrangAccount"].Value.ToString();
                    acc.PROXY = dataGridView.Rows[i].Cells["proxyAccount"].Value.ToString();
                    acc.TRANGTHAI = dataGridView.Rows[i].Cells["trangthaiAccount"].Value.ToString();
                    acc.SOPAGE = dataGridView.Rows[i].Cells["pageNumberAccount"].Value.ToString();
                    danhSach.Add(acc);
                }

            }

            foreach (account item in danhSach)
            {
                if (item.COOKIE != "")
                {
                    string[] ua = File.ReadAllText("user_agent.txt").Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
                    Random rd = new Random();
                    string userAgent = ua[rd.Next(0, ua.Length)];
                    string token = FacebookUtils.getTokenEAAG(item.COOKIE, false, "", "");
                    Console.WriteLine("=====" + token);
                    if(token != "")
                    {
                        item.TOKEN = token;
                        SQLiteUtils.updateByUID(item);
                    }
                }

            }


        }

        /*
         * 
         * Check Status Cookie
         * 
         */
        public void checkStatusCookie(DataGridView dataGridView)
        {
            List<account> danhSach = new List<account>();

            for (int i = 0; i < dataGridView.Rows.Count; i++)
            {
                if (dataGridView.Rows[i].Cells["checkboxItemAccount"].Value.ToString() == "True" && dataGridView.Rows[i].Cells["tinhtrangAccount"].Value.ToString() == "Live")
                {
                    account acc = new account();
                    acc.UID = dataGridView.Rows[i].Cells["uidAccount"].Value.ToString();
                    acc.COOKIE = dataGridView.Rows[i].Cells["cookieAccount"].Value.ToString();
                    acc.TOKEN = dataGridView.Rows[i].Cells["tokenAccount"].Value.ToString();
                    acc.PASS = dataGridView.Rows[i].Cells["passAccount"].Value.ToString();
                    acc.M2FA = dataGridView.Rows[i].Cells["code2faAccount"].Value.ToString();
                    acc.LIVE = dataGridView.Rows[i].Cells["tinhtrangAccount"].Value.ToString();
                    acc.PROXY = dataGridView.Rows[i].Cells["proxyAccount"].Value.ToString();
                    acc.TRANGTHAI = dataGridView.Rows[i].Cells["trangthaiAccount"].Value.ToString();
                    acc.SOPAGE = dataGridView.Rows[i].Cells["pageNumberAccount"].Value.ToString();
                    danhSach.Add(acc);
                }

            }

            foreach (account item in danhSach)
            {
                if (item.COOKIE != "")
                {
                    string result = FacebookUtils.CheckLiveCookie(item.COOKIE, "", "");
                    Console.WriteLine(result);

                }

            }


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
                    acc.COOKIE = dataGridView.Rows[i].Cells["cookieAccount"].Value.ToString();
                    acc.TOKEN = dataGridView.Rows[i].Cells["tokenAccount"].Value.ToString();
                    acc.PASS = dataGridView.Rows[i].Cells["passAccount"].Value.ToString();
                    acc.M2FA = dataGridView.Rows[i].Cells["code2faAccount"].Value.ToString();
                    acc.LIVE = dataGridView.Rows[i].Cells["tinhtrangAccount"].Value.ToString();
                    acc.PROXY = dataGridView.Rows[i].Cells["proxyAccount"].Value.ToString();
                    acc.TRANGTHAI = dataGridView.Rows[i].Cells["trangthaiAccount"].Value.ToString();
                    acc.SOPAGE = dataGridView.Rows[i].Cells["pageNumberAccount"].Value.ToString();
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
            int itemIndex = 0;
            ProxyUtils proxyUtils = new ProxyUtils();
         
            if (apiKeyList.Count > 0)
            {
                for(int i = 0; i < apiKeyList.Count; i++)
                {
                    await proxyUtils.getNewProxy(Constants.Constants.GetNewProxyShopLike(apiKeyList[i]));
                }
                
            }

            int batchSize = Convert.ToInt32(flowNum.Value); // Số lượng item mỗi lần xử lý
            int maxConcurrency = Convert.ToInt32(flowNum.Value); // Số lượng luồng tối đa
            int screenHeight = SystemInformation.VirtualScreen.Height;
            int screenWidth = SystemInformation.VirtualScreen.Width;
            if (screenHeight > 1920)
            {
                screenWidth = 1920;
            }
            SemaphoreSlim semaphore = new SemaphoreSlim(maxConcurrency);
            int x = 0; int y = 0;
            for (int i = 0; i < listAcccounts.Count; i += batchSize)
            {
                List<account> batch = listAcccounts.GetRange(i, Math.Min(batchSize, listAcccounts.Count - i));
 

                try
                {
                    await Task.WhenAll(batch.Select(async item =>
                    {
                        await semaphore.WaitAsync();
                        try
                        {
                                Random random = new Random();
                                int index = random.Next(apiKeyList.Count);
                                string randomKey = apiKeyList[index];
                                string proxy = await proxyUtils.getCurrentProxy(Constants.Constants.GetCurrentProxyShopLike(randomKey, "hd"));
                                item.PROXY = proxy;

                                if (itemIndex == 0 || itemIndex == 10 || itemIndex == 20 || itemIndex == 30)
                                {
                                    y = 0;
                                    x = 0;
                                }
                                else if ((itemIndex > 0 && itemIndex < 5) || (itemIndex > 10 && itemIndex < 15) || (itemIndex > 20 && itemIndex < 25) || (itemIndex > 30 && itemIndex < 35))
                                {
                                    y = 0;
                                    x += screenWidth / 5;
                                }
                                else if (itemIndex == 5 || itemIndex == 15 || itemIndex == 25 || itemIndex == 35)
                                {
                                    y = screenHeight / 2;
                                    x = 0;
                                }
                                else if ((itemIndex > 5 && itemIndex < 10) || (itemIndex > 15 && itemIndex <= 20) || (itemIndex > 25 && itemIndex < 30) || (itemIndex > 35 && itemIndex < 40))
                                {
                                    y = screenHeight / 2;
                                    x += screenWidth / 5;
                                }
                                else { }
                                itemIndex++;
                                await ProcessItemLoginAcc(ProfileFolderPath, item, itemIndex, flowNum, selectProxy, x, y);
                            
                        }
                        finally
                        {
                            semaphore.Release();
                        }
                    }));
                }
                finally
                {
                    // Sau khi hoàn thành một batch, đóng tất cả các ChromeDriver
                    foreach (var driver in _listDriver)
                    {
                        driver.Quit();
                    }
                }
            }

            Console.WriteLine("DONE ALL TASK!!!");
        }

        /*
        * Process Login with item Account
        */
        public async Task ProcessItemLoginAcc(string ProfileFolderPath, account item, int itemIndex, NumericUpDown flowNum, ComboBox selectProxy,int x, int y)
        {

            ChromeDriver chromeDriver = _chromeDriverUtils.initChrome(ProfileFolderPath, item, itemIndex, flowNum, selectProxy, x, y);
            _listDriver.Add(chromeDriver);
            _dictionaryDriver.Add(item.UID, chromeDriver);
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
                    //ChromeDriverUtils.ChromeDetroy(chromeDriver, _listDriver);
                }
                else if (ChromeDriverUtils.FindTextInChrome(chromeDriver, "tạm thời bị khóa", "lock"))
                {
                    item.LIVE = "Checkpoint";
                    item.TRANGTHAI = "Tạm thời bị khóa !...";
                    //ChromeDriverUtils.ChromeDetroy(chromeDriver, _listDriver);

                }
                else if (ChromeDriverUtils.FindTextInChrome(chromeDriver, "chúng tôi đã đình chỉ tài khoản của bạn", "We suspend"))
                {
                    item.LIVE = "Checkpoint";
                    item.TRANGTHAI = "Đình chỉ tài khoản !...";
                    //ChromeDriverUtils.ChromeDetroy(chromeDriver, _listDriver);
                }
                else if(ChromeDriverUtils.FindTextInChrome(chromeDriver, "chúng tôi cần xác nhận rằng tài khoản này thuộc về bạn", "We need to confirm"))
                {
                    item.LIVE = "Checkpoint";
                    item.TRANGTHAI = "Xác nhận tài khoản !...";
                    //ChromeDriverUtils.ChromeDetroy(chromeDriver, _listDriver);
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
                    //ChromeDriverUtils.ChromeDetroy(chromeDriver, _listDriver);
                }
                else
                {
                    item.TRANGTHAI = "Có lỗi xảy ra !...";
                    //ChromeDriverUtils.ChromeDetroy(chromeDriver, _listDriver);
                }
            }
            catch
            {
                if (chromeDriver.FindElement(By.XPath("/html/body/div[1]/div[2]/div[1]/div/div[2]/div[2]/form/div[1]/div[1]")).Text.Contains("mật khẩu"))
                {

                    item.TRANGTHAI = "Sai Password!...";
                    //ChromeDriverUtils.ChromeDetroy(chromeDriver, _listDriver);
                }
            }

            SQLiteUtils.updateByUID(item);
            Console.WriteLine($"Processing item: ========");
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
                    acc.COOKIE = dataGridView.Rows[i].Cells["cookieAccount"].Value.ToString();
                    acc.TOKEN = dataGridView.Rows[i].Cells["tokenAccount"].Value.ToString();
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
            int itemIndex = 0;
            ProxyUtils proxyUtils = new ProxyUtils();

            if (apiKeyList.Count > 0)
            {
                for (int i = 0; i < apiKeyList.Count; i++)
                {
                    await proxyUtils.getNewProxy(Constants.Constants.GetNewProxyShopLike(apiKeyList[i]));
                }

            }

            int batchSize = Convert.ToInt32(flowNum.Value); // Số lượng item mỗi lần xử lý
            int maxConcurrency = Convert.ToInt32(flowNum.Value); // Số lượng luồng tối đa
            int screenHeight = SystemInformation.VirtualScreen.Height;
            int screenWidth = SystemInformation.VirtualScreen.Width;
            if (screenHeight > 1920)
            {
                screenWidth = 1920;
            }
            SemaphoreSlim semaphore = new SemaphoreSlim(maxConcurrency);
            int x = 0; int y = 0;
            for (int i = 0; i < listAcccounts.Count; i += batchSize)
            {
                List<account> batch = listAcccounts.GetRange(i, Math.Min(batchSize, listAcccounts.Count - i));


                try
                {
                    await Task.WhenAll(batch.Select(async item =>
                    {
                        await semaphore.WaitAsync();
                        try
                        {
                            Random random = new Random();
                            int index = random.Next(apiKeyList.Count);
                            string randomKey = apiKeyList[index];
                            string proxy = await proxyUtils.getCurrentProxy(Constants.Constants.GetCurrentProxyShopLike(randomKey, "hd"));
                            item.PROXY = proxy;

                            if (itemIndex == 0 || itemIndex == 10 || itemIndex == 20 || itemIndex == 30)
                            {
                                y = 0;
                                x = 0;
                            }
                            else if ((itemIndex > 0 && itemIndex < 5) || (itemIndex > 10 && itemIndex < 15) || (itemIndex > 20 && itemIndex < 25) || (itemIndex > 30 && itemIndex < 35))
                            {
                                y = 0;
                                x += screenWidth / 5;
                            }
                            else if (itemIndex == 5 || itemIndex == 15 || itemIndex == 25 || itemIndex == 35)
                            {
                                y = screenHeight / 2;
                                x = 0;
                            }
                            else if ((itemIndex > 5 && itemIndex < 10) || (itemIndex > 15 && itemIndex <= 20) || (itemIndex > 25 && itemIndex < 30) || (itemIndex > 35 && itemIndex < 40))
                            {
                                y = screenHeight / 2;
                                x += screenWidth / 5;
                            }
                            else { }
                            itemIndex++;
                            await processItemRegPageAcc(ProfileFolderPath, item, itemIndex, flowNum, selectProxy, dataGridView, x, y);

                        }
                        finally
                        {
                            semaphore.Release();
                        }
                    }));
                }
                finally
                {
                    // Sau khi hoàn thành một batch, đóng tất cả các ChromeDriver
                    foreach (var driver in _listDriver)
                    {
                        driver.Quit();
                    }
                }
            }

            Console.WriteLine("DONE ALL TASK!!!");

        }

        /*
         * Process Reg Page for Item Acc
         */
        public async Task processItemRegPageAcc(string ProfileFolderPath, account item, int itemIndex, NumericUpDown flowNum, ComboBox selectProxy,DataGridView dataGridView, int x, int y)
        {
            ChromeDriver chromeDriver = _chromeDriverUtils.initChrome(ProfileFolderPath, item, itemIndex, flowNum, selectProxy, x, y);
            _listDriver.Add(chromeDriver);
            Thread.Sleep(1000);
            RegPage regPage = new RegPage();
            regPage.RegPageWithUID(chromeDriver, fullPathNamePage,dataGridView,item, _listDriver);

            SQLiteUtils.updateByUID(item);
            Console.WriteLine($"Processing item: =======");
        }


        /*
         * 
         * Feature Seeding Page
         * 
         */


        public void likePost(string ProfileFolderPath, DataGridView dataGridView, NumericUpDown flowNum, ComboBox selectProxy, List<string> apiKeyList)
        {

            List<account> danhSach = new List<account>();

            for (int i = 0; i < dataGridView.Rows.Count; i++)
            {
                if (dataGridView.Rows[i].Cells["checkboxItemAccount"].Value.ToString() == "True")
                {
                    account acc = new account();
                    acc.UID = dataGridView.Rows[i].Cells["uidAccount"].Value.ToString();
                    acc.COOKIE = dataGridView.Rows[i].Cells["cookieAccount"].Value.ToString();
                    acc.TOKEN = dataGridView.Rows[i].Cells["tokenAccount"].Value.ToString();
                    acc.PASS = dataGridView.Rows[i].Cells["passAccount"].Value.ToString();
                    acc.M2FA = dataGridView.Rows[i].Cells["code2faAccount"].Value.ToString();
                    acc.LIVE = dataGridView.Rows[i].Cells["tinhtrangAccount"].Value.ToString();
                    acc.PROXY = dataGridView.Rows[i].Cells["proxyAccount"].Value.ToString();
                    acc.TRANGTHAI = dataGridView.Rows[i].Cells["trangthaiAccount"].Value.ToString();
                    acc.SOPAGE = dataGridView.Rows[i].Cells["pageNumberAccount"].Value.ToString();
                    danhSach.Add(acc);
                }
            }

            ProcessLikePost(ProfileFolderPath, dataGridView, flowNum, selectProxy, danhSach, apiKeyList);
        }

        /*
         * Process Reg Page
         */

        public async void ProcessLikePost(string ProfileFolderPath, DataGridView dataGridView, NumericUpDown flowNum, ComboBox selectProxy, List<account> listAcccounts, List<string> apiKeyList)
        {
            int itemIndex = 0;
            ProxyUtils proxyUtils = new ProxyUtils();

            if (apiKeyList.Count > 0)
            {
                for (int i = 0; i < apiKeyList.Count; i++)
                {
                    await proxyUtils.getNewProxy(Constants.Constants.GetNewProxyShopLike(apiKeyList[i]));
                }

            }

            int batchSize = Convert.ToInt32(flowNum.Value); // Số lượng item mỗi lần xử lý
            int maxConcurrency = Convert.ToInt32(flowNum.Value); // Số lượng luồng tối đa
            int screenHeight = SystemInformation.VirtualScreen.Height;
            int screenWidth = SystemInformation.VirtualScreen.Width;
            if (screenHeight > 1920)
            {
                screenWidth = 1920;
            }
            SemaphoreSlim semaphore = new SemaphoreSlim(maxConcurrency);
            int x = 0; int y = 0;
            for (int i = 0; i < listAcccounts.Count; i += batchSize)
            {
                List<account> batch = listAcccounts.GetRange(i, Math.Min(batchSize, listAcccounts.Count - i));


                try
                {
                    await Task.WhenAll(batch.Select(async item =>
                    {
                        await semaphore.WaitAsync();
                        try
                        {
                            Random random = new Random();
                            int index = random.Next(apiKeyList.Count);
                            string randomKey = apiKeyList[index];
                            string proxy = await proxyUtils.getCurrentProxy(Constants.Constants.GetCurrentProxyShopLike(randomKey, "hd"));
                            item.PROXY = proxy;

                            if (itemIndex == 0 || itemIndex == 10 || itemIndex == 20 || itemIndex == 30)
                            {
                                y = 0;
                                x = 0;
                            }
                            else if ((itemIndex > 0 && itemIndex < 5) || (itemIndex > 10 && itemIndex < 15) || (itemIndex > 20 && itemIndex < 25) || (itemIndex > 30 && itemIndex < 35))
                            {
                                y = 0;
                                x += screenWidth / 5;
                            }
                            else if (itemIndex == 5 || itemIndex == 15 || itemIndex == 25 || itemIndex == 35)
                            {
                                y = screenHeight / 2;
                                x = 0;
                            }
                            else if ((itemIndex > 5 && itemIndex < 10) || (itemIndex > 15 && itemIndex <= 20) || (itemIndex > 25 && itemIndex < 30) || (itemIndex > 35 && itemIndex < 40))
                            {
                                y = screenHeight / 2;
                                x += screenWidth / 5;
                            }
                            else { }
                            itemIndex++;
                            await processItemLikePost(ProfileFolderPath, item, itemIndex, flowNum, selectProxy, dataGridView, x, y);

                        }
                        finally
                        {
                            semaphore.Release();
                        }
                    }));
                }
                finally
                {
                    // Sau khi hoàn thành một batch, đóng tất cả các ChromeDriver
                    foreach (var driver in _listDriver)
                    {
                        driver.Quit();
                    }
                }
            }

            Console.WriteLine("DONE TASK Like Post!!!");

        }

        /*
         * Process Reg Page for Item Acc
         */
        public async Task processItemLikePost(string ProfileFolderPath, account item, int itemIndex, NumericUpDown flowNum, ComboBox selectProxy, DataGridView dataGridView, int x, int y)
        {
            ChromeDriver chromeDriver = _chromeDriverUtils.initChrome(ProfileFolderPath, item, itemIndex, flowNum, selectProxy, x, y);
            _listDriver.Add(chromeDriver);

            List<string> listPageString = SQLiteUtils.getPageListByUid(item);
            List<page> listPage = new List<page>();
            foreach(var list in listPageString)
            {
                string[] itemInfo = list.Split('|');

                if(itemInfo.Length > 0)
                {
                    page pageNew = new page();
                    pageNew.PAGEID = itemInfo[0];
                    pageNew.UID = itemInfo[1];
                    pageNew.NAME = itemInfo[2];
                    listPage.Add(pageNew);

                }
            }
            Thread.Sleep(1000);
            Post likePost = new Post();
            Random random = new Random();
            int randomIndex = random.Next(0, listPage.Count);
            page randomPage = listPage[randomIndex];

            //string ui = likePost.getPostUid();
            //string[] uidPost = null;
            //if (ui != "")
            //{
            //    uidPost = ui.Replace("----", "|").Split('|');
            //}
            string[] uidPost = new string[1];
            uidPost[0] = "697866975718518";

            likePost.LikePost(chromeDriver, dataGridView, item, uidPost, randomPage);

            SQLiteUtils.updateByUID(item);
            Console.WriteLine($"Processing item: =======");
        }
    }
}
