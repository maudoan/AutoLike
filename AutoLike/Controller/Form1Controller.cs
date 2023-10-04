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
using System.Runtime.InteropServices;
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
        private List<account> _listAccounts;
        private SQLiteUtils _sqliteUtils;
        private Form1 form1;
        private ChromeDriverUtils _chromeDriverUtils;
        List<ChromeDriver> _listDriver = new List<ChromeDriver>();

        public Form1Controller()
        {
            _listAccounts = new List<account>();
            _sqliteUtils = new SQLiteUtils();
            _chromeDriverUtils = new ChromeDriverUtils();
        }

        public void turnOffChrome()
        {
            foreach (ChromeDriver driver in _listDriver)
            {

                try
                {
                    foreach (var process in Process.GetProcessesByName("chromedriver"))
                    {
                        process.Kill();
                    }
                    driver.Quit();
                    driver.Close();
                }
                catch { }

            }
            _listDriver.Clear();  
        }

        public List<string> listKeyShopLike(TextBox apiKeyTextBox)
        {
            List<string> keyApiList = new List<string>();
            string[] apiLine = apiKeyTextBox.Text.Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
            foreach (string line in apiLine)
            {
                keyApiList.Add(line);
            }

            return keyApiList;
        }

        public Boolean SelectFile(DataGridView dataGridView)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text Files|*.txt";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string fullFilePath = openFileDialog.FileName;
                int index = dataGridView.CurrentCell.RowIndex;
                string fileName = dataGridView.Rows[index].Cells[0].Value.ToString();
                SaveToDbFromImportFile(fullFilePath, fileName);
                return true;
            }
            return false;
        }

        public void SaveToDbFromImportFile(string fullPath, string cateloge)
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
                        string[] elements = line.Split(new string[] { "|" }, StringSplitOptions.None);
                        account.CATELOGE = cateloge;
                        account.UID = elements.Length >= 0 ? elements[0] : "";
                        account.PASS = elements.Length > 1 ? elements[1] : "";
                        account.M2FA = elements.Length > 2 ? elements[2] : "";
                        account.COOKIE = elements.Length > 3 ? elements[3] : "";
                        account.TOKEN = elements.Length > 4 ? elements[4] : "";
                        account.COOKIELD = elements.Length > 5 ? elements[5] : "";
                        account.TOKENLD = elements.Length > 6 ? elements[6] : "";
                        account.EMAIL = elements.Length > 7 ? elements[7] : "";
                        account.PASSMAIL = elements.Length > 8 ? elements[8] : "";
                        account.NAMTAO = elements.Length > 9 ? elements[9] : "";
                        account.TEN = elements.Length > 10 ? elements[10] : "";
                        account.SINHNHAT = elements.Length > 11 ? elements[11] : "";
                        account.FRIEND = elements.Length > 12 ? elements[12] : "";
                        account.GROUP = elements.Length > 13 ? elements[13] : "";
                        account.GENDER = elements.Length > 14 ? elements[14] : "";
                        account.LIVE = elements.Length > 15 ? elements[15] : "";
                        account.PROXY = elements.Length > 16 ? elements[16] : "";
                        account.LASTACTIVE = elements.Length > 17 ? elements[17] : "";
                        account.DANHMUC = elements.Length > 18 ? elements[18] : "";
                        account.GHICHU = elements.Length > 19 ? elements[19] : "";
                        account.NGAYBU = elements.Length > 20 ? elements[20] : "";
                        account.TRANGTHAI = elements.Length > 21 ? elements[21] : "";
                        account.SOPAGE = elements.Length > 22 ? elements[22] : "";

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

        public void saveCategory(DataGridView listFileDataGridView,TextBox importFileTextBox)
        {

            if (importFileTextBox.Text != "")
            {
                for (int i = 0; i < listFileDataGridView.Rows.Count; i++)
                {
                    if (listFileDataGridView.Rows[i].Cells[0].Value.ToString() == importFileTextBox.Text)
                    {
                        MessageBox.Show("Đã tồn tại TÊN FILE " + importFileTextBox.Text, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        goto end;
                    }
                }
                _sqliteUtils.addCategory(importFileTextBox.Text);

                MessageBox.Show("SAVE FILE SUCCESS !", "DONE", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadFileAccount(listFileDataGridView);
            }
            else
            {
                MessageBox.Show("Chưa nhập TÊN FILE cần LƯU !", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        end:
            Thread.Sleep(100);

        }

        public void deleteAllByCateloge(ToolStripMenuItem deleteFileToolStripMenuItem, DataGridView dataGridView)
        {

            int index = dataGridView.CurrentCell.RowIndex;
            string fileName = dataGridView.Rows[index].Cells[0].Value.ToString();
            DialogResult rs = MessageBox.Show("Bạn chắc chắn muốn xóa File: " + fileName + " ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (rs == DialogResult.Yes)
            {
                SQLiteUtils.deleteAllItemByCateloge(fileName);
                LoadFileAccount(dataGridView);
            }

        }

        public void LoadFileAccount(DataGridView dataGridView)
        {
            dataGridView.Rows.Clear();
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

                List<string> list1 = _sqliteUtils.getAllAccount("DM");
                for (int i2 = 0; i2 < list1.Count; i2++)
                {
                    list.Add(list1[i2]);
                }

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

        public void loadGeneralSetting(TextBox profileFolderPath, ComboBox selectProxy,TextBox apiKeyTextBox, NumericUpDown generalSettingflowNumberNumericUpDown)
        {
            if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\AutoLike\GeneralSetting.txt"))
            {
                string[] dt = File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\AutoLike\GeneralSetting.txt").Split('|');
                try
                {
                    selectProxy.SelectedItem = dt[0];
                    profileFolderPath.Text = dt[1];
                    apiKeyTextBox.Text = dt[2];
                    generalSettingflowNumberNumericUpDown.Value = int.Parse(dt[3].Trim());
                }
                catch { }
            }
        }

        public void loadLikePostSeeting(CheckBox likePost, TextBox apiKeyGetUidTextBox)
        {
            if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\AutoLike\LikePostSetting.txt"))
            {
                string[] dt = File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\AutoLike\LikePostSetting.txt").Split('|');
                try
                {
                    if (dt[0] == "True")
                    {
                        likePost.Checked = true;
                    } else
                    {
                        likePost.Checked = false;
                    }

                    apiKeyGetUidTextBox.Text = dt[1];
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
            if(danhSach.Count > 0)
            {
                processInsertBatchPage(danhSach, dataGridView);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn acc để get Page", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        public async void processInsertBatchPage(List<account> listAccounts, DataGridView dataGridView)
        {
            int batchSize = Convert.ToInt32(10); // Số lượng item mỗi lần xử lý
            int maxConcurrency = Convert.ToInt32(10); // Số lượng luồng tối đa

            List<page> listPage = new List<page>();
            SemaphoreSlim semaphore = new SemaphoreSlim(maxConcurrency);
            for (int i = 0; i < listAccounts.Count; i += batchSize)
            {
                List<account> batch = listAccounts.GetRange(i, Math.Min(batchSize, listAccounts.Count - i));


                try
                {
                    var tasks = batch.Select(async item =>
                    {
                        ChromeDriverUtils.updateColorStatus(dataGridView, item);
                        await semaphore.WaitAsync();
                        try
                        {

                            await Task.Run(async () =>
                            {
                                Dictionary<string, string> listIdGroup = FacebookUtils.getListPage(item.COOKIE, "", "");
                                if (listIdGroup != null && listIdGroup.Count > 0)
                                {
                                    item.SOPAGE = listIdGroup.Count.ToString();
                                    ChromeDriverUtils.updateNumPage(dataGridView, item);
                                    item.LIVE = "Live";
                                    ChromeDriverUtils.updateStatusAcc(dataGridView, item, "Live");
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
                                else
                                {
                                    item.SOPAGE = "0";
                                    item.LIVE = "Checkpoint";
                                    ChromeDriverUtils.updateStatusAcc(dataGridView, item, "Checkpoint");
                                    SQLiteUtils.updateByUID(item);
                                }
                                SQLiteUtils.insertPage(listPage);
                                await Task.Delay(1000);
                            });

                        }
                        finally
                        {
                            semaphore.Release();
                        }
                    });

                    await Task.WhenAll(tasks);
                    listPage.Clear();
                }
                finally
                {
                    Console.WriteLine("-------DONE ALL TASK Get ListPage!!!--------->");
                }
            }

            MessageBox.Show("Đã lấy xong số lượng Page!", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void processCloseApp ()
        {
            if(_listDriver.Count > 0)
            {
                foreach (var driver in _listDriver)
                {
                    foreach (var process in Process.GetProcessesByName("chromedriver"))
                    {
                        process.Kill();
                    }
                    Console.WriteLine("--------Out Chrome------>");
                    driver.Quit();
                    driver.Close();
                }
            }

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
                    Console.WriteLine("-----" +result+ "----->");

                }

            }


        }
        /*
         * 
         * Feature Create Profile
         * 
         */

        private DateTime lastApiCallTime = DateTime.MinValue;
        private TimeSpan callInterval = TimeSpan.FromMinutes(1);

        /*
         * init Login
         */
        public void LoginChromeWithCookieToken(string ProfileFolderPath, DataGridView dataGridView, NumericUpDown flowNum, bool selectProxy, List<string> apiKeyList)
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
        public async void ProcessLoginChromeCookieToken(string ProfileFolderPath, DataGridView dataGridView, NumericUpDown flowNum, bool selectProxy, List<account> listAcccounts, List<string> apiKeyList)
        {
            int itemIndex = 0;

            ProxyUtils proxyUtils = new ProxyUtils();

            DateTime currentTime = DateTime.Now;

            if (currentTime - lastApiCallTime >= callInterval)
            {
                // Nếu đã đủ thời gian, thực hiện gọi API
                if (apiKeyList.Count > 0)
                {
                    for (int i = 0; i < apiKeyList.Count; i++)
                    {
                        proxyUtils.getNewProxy(Constants.Constants.GetNewProxyShopLike(apiKeyList[i]));
                    }
                }

                // Cập nhật thời gian gọi cuối cùng
                lastApiCallTime = currentTime;
            }
            else
            {
                // Nếu chưa đủ thời gian, không thực hiện gọi lại API
                Console.WriteLine("-------->  Waitng For 1 minute " + (callInterval - (currentTime - lastApiCallTime)));
            }

            int batchSize = Convert.ToInt32(flowNum.Value); // Số lượng item mỗi lần xử lý
            int maxConcurrency = Convert.ToInt32(flowNum.Value); // Số lượng luồng tối đa
            int screenWidth = Screen.PrimaryScreen.Bounds.Width;
            int screenHeight = Screen.PrimaryScreen.Bounds.Height;
            if (screenWidth > 1920)
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
                    var tasks = batch.Select(async item =>
                    {
                        await semaphore.WaitAsync();
                        try
                        {
                            Random random = new Random();
                            int index = random.Next(apiKeyList.Count);
                            string randomKey = apiKeyList[index];
                            string proxy = proxyUtils.getCurrentProxy(Constants.Constants.GetCurrentProxyShopLike(randomKey, "hd"));
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

                            if(itemIndex == flowNum.Value)
                            {
                                itemIndex = 0;
                            }

                            await Task.Run(async () =>
                            {
                                await ProcessItemLoginAcc(ProfileFolderPath, item, itemIndex, flowNum, selectProxy, x, y, dataGridView);
                                await Task.Delay(1000);
                            });

                        }
                        finally
                        {
                            semaphore.Release();
                        }
                    });

                    await Task.WhenAll(tasks);
                    foreach (var driver in _listDriver)
                    {
                        Console.WriteLine("--------Out Chrome------>");
                        driver.Quit();
                    }
                    foreach (var process in Process.GetProcessesByName("chromedriver"))
                    {
                        process.Kill();
                    }

                    _listDriver.Clear();
                }
                finally
                {
                    Console.WriteLine("-------DONE ALL TASK LOGIN!!!--------->");
                }
            }
        }

        /*
        * Process Login with item Account
        */
        public async Task ProcessItemLoginAcc(string ProfileFolderPath, account item, int itemIndex, NumericUpDown flowNum, bool selectProxy,int x, int y, DataGridView dataGridView)
        {

            ChromeDriver chromeDriver = _chromeDriverUtils.initChrome(ProfileFolderPath, item, itemIndex, flowNum, selectProxy, x, y);
            _listDriver.Add(chromeDriver);

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
                    ChromeDriverUtils.updateStatusChrome(dataGridView, item, "Sai password....");
                }
                else if (ChromeDriverUtils.FindTextInChrome(chromeDriver, "tạm thời bị khóa", "lock"))
                {
                    item.LIVE = "Checkpoint";
                    item.TRANGTHAI = "Tạm thời bị khóa !...";
                    ChromeDriverUtils.updateStatusAcc(dataGridView, item, "Checkpoint");
                    ChromeDriverUtils.updateStatusChrome(dataGridView, item, "Tạm thời bị khóa !...");

                }
                else if (ChromeDriverUtils.FindTextInChrome(chromeDriver, "chúng tôi đã đình chỉ tài khoản của bạn", "We suspend"))
                {
                    item.LIVE = "Checkpoint";
                    item.TRANGTHAI = "Đình chỉ tài khoản !...";
                    ChromeDriverUtils.updateStatusAcc(dataGridView, item, "Checkpoint");
                    ChromeDriverUtils.updateStatusChrome(dataGridView, item, "Đình chỉ tài khoản !...");

                }
                else if(ChromeDriverUtils.FindTextInChrome(chromeDriver, "chúng tôi cần xác nhận rằng tài khoản này thuộc về bạn", "We need to confirm"))
                {
                    item.LIVE = "Checkpoint";
                    item.TRANGTHAI = "Xác nhận tài khoản !...";
                    ChromeDriverUtils.updateStatusAcc(dataGridView, item, "Checkpoint");
                    ChromeDriverUtils.updateStatusChrome(dataGridView, item, "Xác nhận tài khoản !...");

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
                    ChromeDriverUtils.updateStatusAcc(dataGridView, item, "Live");
                    ChromeDriverUtils.updateStatusChrome(dataGridView, item, "Login Facebook thành công !...");

                }
                else
                {
                    item.TRANGTHAI = "Có lỗi xảy ra !...";
                    ChromeDriverUtils.updateStatusChrome(dataGridView, item, "Có lỗi xảy ra !...");

                }
            }
            catch
            {
                if (chromeDriver.FindElement(By.XPath("/html/body/div[1]/div[2]/div[1]/div/div[2]/div[2]/form/div[1]/div[1]")).Text.Contains("mật khẩu"))
                {

                    item.TRANGTHAI = "Sai Password!...";
                    ChromeDriverUtils.updateStatusChrome(dataGridView, item, "Sai Password!...");

                }
            }

            SQLiteUtils.updateByUID(item);
            Console.WriteLine($"------------Processing item: =========>");
        }


        /*
         * 
         * Feature Reg Page
         * 
         * 
         */

        string fullPathNamePage = string.Empty;

        /*
         * Select path File Name
         */
        public string selectFile()
        {
            var fullFilePath = string.Empty;
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text Files|*";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                fullFilePath = openFileDialog.FileName;
                fullPathNamePage = fullFilePath;
                return fullFilePath;
            }
            return fullFilePath;
        }

        /*
         *  Select Folder
         */
        public string selectFolder()
        {
            var selectedFolder = string.Empty;
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();

            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                selectedFolder = folderBrowserDialog.SelectedPath;
                fullPathNamePage = selectedFolder;
                return selectedFolder;
            }

            return selectedFolder;
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
                    Console.WriteLine("----------Tep tin trong--------->");
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

        public void regPage(string ProfileFolderPath, DataGridView dataGridView, NumericUpDown flowNum, bool selectProxy, List<string> apiKeyList)
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

        public async void ProcessRegPage(string ProfileFolderPath, DataGridView dataGridView, NumericUpDown flowNum, bool selectProxy, List<account> listAcccounts, List<string> apiKeyList)
        {
            int itemIndex = 0;
            ProxyUtils proxyUtils = new ProxyUtils();

            DateTime currentTime = DateTime.Now;

            if (currentTime - lastApiCallTime >= callInterval)
            {
                // Nếu đã đủ thời gian, thực hiện gọi API
                if (apiKeyList.Count > 0)
                {
                    for (int i = 0; i < apiKeyList.Count; i++)
                    {
                        proxyUtils.getNewProxy(Constants.Constants.GetNewProxyShopLike(apiKeyList[i]));
                    }
                }

                // Cập nhật thời gian gọi cuối cùng
                lastApiCallTime = currentTime;
            }
            else
            {
                // Nếu chưa đủ thời gian, không thực hiện gọi lại API
                Console.WriteLine("------------>Waitng For 1 minute " + (callInterval - (currentTime - lastApiCallTime)));
            }

            int batchSize = Convert.ToInt32(flowNum.Value); // Số lượng item mỗi lần xử lý
            int maxConcurrency = Convert.ToInt32(flowNum.Value); // Số lượng luồng tối đa
            int screenWidth = Screen.PrimaryScreen.Bounds.Width;
            int screenHeight = Screen.PrimaryScreen.Bounds.Height;
            if (screenWidth > 1920)
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
                    var tasks = batch.Select(async item =>
                    {
                        await semaphore.WaitAsync();
                        try
                        {
                            Random random = new Random();
                            int index = random.Next(apiKeyList.Count);
                            string randomKey = apiKeyList[index];
                            string proxy = proxyUtils.getCurrentProxy(Constants.Constants.GetCurrentProxyShopLike(randomKey, "hd"));
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
                            if (itemIndex == flowNum.Value)
                            {
                                itemIndex = 0;
                            }
                            await Task.Run(async () =>
                            {
                                await processItemRegPageAcc(ProfileFolderPath, item, itemIndex, flowNum, selectProxy, dataGridView, x, y);
                            });
                           

                        }
                        finally
                        {
                            semaphore.Release();
                        }
                    });
                    await Task.WhenAll(tasks);
                    foreach (var driver in _listDriver)
                    {
                        Console.WriteLine("----------Out Chrome--------->");
                        driver.Quit();
                    }
                    foreach (var process in Process.GetProcessesByName("chromedriver"))
                    {
                        process.Kill();
                    }

                    _listDriver.Clear();
                }
                finally
                {
                    Console.WriteLine("--------DONE ALL TASK REGPAGE!!!-------->");
                }
            }

        }

        /*
         * Process Reg Page for Item Acc
         */
        public async Task processItemRegPageAcc(string ProfileFolderPath, account item, int itemIndex, NumericUpDown flowNum, bool selectProxy,DataGridView dataGridView, int x, int y)
        {
            ChromeDriver chromeDriver = _chromeDriverUtils.initChrome(ProfileFolderPath, item, itemIndex, flowNum, selectProxy, x, y);
            _listDriver.Add(chromeDriver);
            Thread.Sleep(1000);
            RegPage regPage = new RegPage();
            regPage.RegPageWithUID(chromeDriver, fullPathNamePage,dataGridView,item, _listDriver);

            SQLiteUtils.updateByUID(item);
            Console.WriteLine($"--------------Processing item: =========>");
        }


        /*
         * 
         * Feature Seeding Page
         * 
         */

        bool stopLikePage = false;

        public void setStopLikePageTrue()
        {
            stopLikePage = true;
        }

        public void setStopLikePageFalse()
        {
            stopLikePage = false;
        }

        public void likePost(string ProfileFolderPath, DataGridView dataGridView, NumericUpDown flowNum, bool selectProxy, List<string> apiKeyList, CheckBox type2CheckBox, TextBox keyText, NumericUpDown timeGetValue)
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
            
            ProcessLikePost(ProfileFolderPath, dataGridView, flowNum, selectProxy, danhSach, apiKeyList, type2CheckBox, keyText, timeGetValue);
        }

        /*
         * Process Reg Page
         */

        public async void ProcessLikePost(string ProfileFolderPath, DataGridView dataGridView, NumericUpDown flowNum, bool selectProxy, List<account> listAcccounts, List<string> apiKeyList, CheckBox type2CheckBox, TextBox keyText, NumericUpDown timeGetValue)
        {
           
            ProxyUtils proxyUtils = new ProxyUtils();

            DateTime currentTime = DateTime.Now;

            if (currentTime - lastApiCallTime >= callInterval)
            {
                // Nếu đã đủ thời gian, thực hiện gọi API
                if (apiKeyList.Count > 0)
                {
                    for (int i = 0; i < apiKeyList.Count; i++)
                    {
                        proxyUtils.getNewProxy(Constants.Constants.GetNewProxyShopLike(apiKeyList[i]));
                    }
                }

                // Cập nhật thời gian gọi cuối cùng
                lastApiCallTime = currentTime;
            }
            else
            {
                // Nếu chưa đủ thời gian, không thực hiện gọi lại API
                Console.WriteLine("------------>Waitng For 1 minute " + (callInterval - (currentTime - lastApiCallTime)));
            }

            int batchSize = Convert.ToInt32(flowNum.Value); // Số lượng item mỗi lần xử lý
            int maxConcurrency = Convert.ToInt32(flowNum.Value); // Số lượng luồng tối đa
            int screenWidth = Screen.PrimaryScreen.Bounds.Width;
            int screenHeight = Screen.PrimaryScreen.Bounds.Height;
            if (screenWidth > 1920)
            {
                screenWidth = 1920;
            }
            int itemIndex = 0;
            int x = 0;
            int y = 0;
            SemaphoreSlim semaphore = new SemaphoreSlim(maxConcurrency);
            while (stopLikePage == false)
            {
                for (int k = 0; k < listAcccounts.Count; k++)
                {
                    if (listAcccounts[k].CHECKED == "Checkpoint" || listAcccounts[k].CHECKED == "Die")
                    {
                        ChromeDriverUtils.updateStatusAccAndUncheck(dataGridView, listAcccounts[k], listAcccounts[k].CHECKED);
                        listAcccounts.RemoveAt(k);
                    }
                }

                string uidPost = Post.getPostUid(type2CheckBox, keyText, timeGetValue);
                string[] listUidPost = uidPost.Replace("----", "|").Split('|');

                for (int i = 0; i < listAcccounts.Count; i += batchSize)
                {
                    List<account> batch = listAcccounts.GetRange(i, Math.Min(batchSize, listAcccounts.Count - i));


                    try
                    {
                        var tasks = batch.Select(async item =>
                        {
                            await semaphore.WaitAsync();
                            try
                            {
                                Random random = new Random();
                                int index = random.Next(apiKeyList.Count);
                                string randomKey = apiKeyList[index];
                                string proxy = proxyUtils.getCurrentProxy(Constants.Constants.GetCurrentProxyShopLike(randomKey, "hd"));

                                if (proxy == null || proxy == "")
                                {
                                    item.PROXY = "";
                                }
                                else
                                {
                                    item.PROXY = proxy;
                                }


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
                                if (itemIndex == flowNum.Value)
                                {
                                    itemIndex = 0;
                                }
                                await Task.Run(async () =>
                                {

                                    List<string> listPageString = SQLiteUtils.getPageListByUid(item);

                                    if (listPageString.Count > 0)
                                    {
                                        await processItemLikePost(ProfileFolderPath, item, itemIndex, flowNum, selectProxy, dataGridView, x, y, listPageString, type2CheckBox, keyText, timeGetValue, listUidPost);
                                    }
                                });
                            }
                            finally
                            {
                                semaphore.Release();
                            }
                        });

                        await Task.WhenAll(tasks);
                        foreach (var driver in _listDriver)
                        {
                            Console.WriteLine("---------Out Chrome-------->");
                            driver.Quit();
                        }
                        foreach (var process in Process.GetProcessesByName("chromedriver"))
                        {
                            process.Kill();
                        }

                        _listDriver.Clear();

                    }
                    finally
                    {
                        Console.WriteLine("----------DONE TASK Like POST!!!------------>");
                    }
                    if (stopLikePage == true)
                    {
                        Console.WriteLine("----------- 1 FLOW LIKE PAGE STOP!!!------------>");
                        break;
                    }

                }

                if (stopLikePage == true)
                {
                    foreach (var driver in _listDriver)
                    {
                        Console.WriteLine("---------LIKE PAGE IS STOPED------------>");
                        driver.Quit();
                    }
                    _listDriver.Clear();
                    break;
                }
            }

        }

        /*
         * Process Reg Page for Item Acc
         */
        public async Task processItemLikePost(string ProfileFolderPath, account item, int itemIndex, NumericUpDown flowNum, bool selectProxy, DataGridView dataGridView, int x, int y, List<string> listPageString, CheckBox type2CheckBox, TextBox keyText, NumericUpDown timeGetValue, string[] listUidPost)
        {
            ChromeDriver chromeDriver = _chromeDriverUtils.initChrome(ProfileFolderPath, item, itemIndex, flowNum, selectProxy, x, y);
            _listDriver.Add(chromeDriver);
          
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

            Post likePost = new Post();
            likePost.LikePost(chromeDriver, dataGridView, item, listUidPost, listPage,type2CheckBox, keyText, timeGetValue);

            SQLiteUtils.updateByUID(item);
            Console.WriteLine($"----------Processing item: =========>");
        }


        /*
         * 
         * Feature Move Page To UID
         * 
         */

        public void movePageToUid(string ProfileFolderPath, DataGridView dataGridView, NumericUpDown flowNum, bool selectProxy, List<string> apiKeyList)
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

            ProcessMovePageToUid(ProfileFolderPath, dataGridView, flowNum, selectProxy, danhSach, apiKeyList);
        }

        /*
         * Process Move Page To Uid
         */

        public async void ProcessMovePageToUid(string ProfileFolderPath, DataGridView dataGridView, NumericUpDown flowNum, bool selectProxy, List<account> listAcccounts, List<string> apiKeyList)
        {
            int itemIndex = 0;
            ProxyUtils proxyUtils = new ProxyUtils();

            DateTime currentTime = DateTime.Now;

            if (currentTime - lastApiCallTime >= callInterval)
            {
                // Nếu đã đủ thời gian, thực hiện gọi API
                if (apiKeyList.Count > 0)
                {
                    for (int i = 0; i < apiKeyList.Count; i++)
                    {
                        proxyUtils.getNewProxy(Constants.Constants.GetNewProxyShopLike(apiKeyList[i]));
                    }
                }

                // Cập nhật thời gian gọi cuối cùng
                lastApiCallTime = currentTime;
            }
            else
            {
                // Nếu chưa đủ thời gian, không thực hiện gọi lại API
                Console.WriteLine("------------>Waitng For 1 minute " + (callInterval - (currentTime - lastApiCallTime)));
            }

            int batchSize = Convert.ToInt32(flowNum.Value); // Số lượng item mỗi lần xử lý
            int maxConcurrency = Convert.ToInt32(flowNum.Value); // Số lượng luồng tối đa
            int screenWidth = Screen.PrimaryScreen.Bounds.Width;
            int screenHeight = Screen.PrimaryScreen.Bounds.Height;
            if (screenWidth > 1920)
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
                    var tasks = batch.Select(async item =>
                    {
                        await semaphore.WaitAsync();
                        try
                        {
                            Random random = new Random();
                            int index = random.Next(apiKeyList.Count);
                            string randomKey = apiKeyList[index];
                            string proxy = proxyUtils.getCurrentProxy(Constants.Constants.GetCurrentProxyShopLike(randomKey, "hd"));
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
                            if (itemIndex == flowNum.Value)
                            {
                                itemIndex = 0;
                            }
                         
                            await Task.Run(async () =>
                            {
                                List<string> listPageString = SQLiteUtils.getPageListByUid(item);

                                if (listPageString.Count > 0)
                                {
                                    await processItemMovePageToUid(ProfileFolderPath, item, itemIndex, flowNum, selectProxy, dataGridView, x, y, listPageString);
                                }
                            });


                        }
                        finally
                        {
                            semaphore.Release();
                        }
                    });
                    await Task.WhenAll(tasks);
                    foreach (var driver in _listDriver)
                    {
                        Console.WriteLine("----------Out Chrome---------->");
                        driver.Quit();
                    }
                    foreach (var process in Process.GetProcessesByName("chromedriver"))
                    {
                        process.Kill();
                    }

                    _listDriver.Clear();
                }
                finally
                {
                    Console.WriteLine("----------DONE Move Page To Uid!!!----------->");
                }
            }

        }

        /*
         * Process Move Page To Uid Item
         */
        public async Task processItemMovePageToUid(string ProfileFolderPath, account item, int itemIndex, NumericUpDown flowNum, bool selectProxy, DataGridView dataGridView, int x, int y, List<string> listPageString)
        {
            ChromeDriver chromeDriver = _chromeDriverUtils.initChrome(ProfileFolderPath, item, itemIndex, flowNum, selectProxy, x, y);
            _listDriver.Add(chromeDriver);

            chromeDriver.Navigate().GoToUrl("https://www.facebook.com/");
            Thread.Sleep(2000);
            try
            {
                chromeDriver.Manage().Cookies.DeleteCookieNamed("i_user");
            }
            catch
            {

            }
          
            SQLiteUtils.updateByUID(item);
            Console.WriteLine($"-------------Processing item: =========>");
        }
    }

}
