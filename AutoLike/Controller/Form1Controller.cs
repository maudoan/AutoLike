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
using Cookie = OpenQA.Selenium.Cookie;
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

            DateTime currentTime = DateTime.Now;

            if (currentTime - lastApiCallTime >= callInterval)
            {
                // Nếu đã đủ thời gian, thực hiện gọi API
                if (apiKeyList.Count > 0)
                {
                    for (int i = 0; i < apiKeyList.Count; i++)
                    {
                        await proxyUtils.getNewProxy(Constants.Constants.GetNewProxyShopLike(apiKeyList[i]));
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
        public async Task ProcessItemLoginAcc(string ProfileFolderPath, account item, int itemIndex, NumericUpDown flowNum, ComboBox selectProxy,int x, int y, DataGridView dataGridView)
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

            DateTime currentTime = DateTime.Now;

            if (currentTime - lastApiCallTime >= callInterval)
            {
                // Nếu đã đủ thời gian, thực hiện gọi API
                if (apiKeyList.Count > 0)
                {
                    for (int i = 0; i < apiKeyList.Count; i++)
                    {
                        await proxyUtils.getNewProxy(Constants.Constants.GetNewProxyShopLike(apiKeyList[i]));
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
        public async Task processItemRegPageAcc(string ProfileFolderPath, account item, int itemIndex, NumericUpDown flowNum, ComboBox selectProxy,DataGridView dataGridView, int x, int y)
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

        int numFlowLikePost = 0;
        int threadCount = 0;
        public void likePost(string ProfileFolderPath, DataGridView dataGridView, NumericUpDown flowNum, ComboBox selectProxy, List<string> apiKeyList, CheckBox type2CheckBox, TextBox keyText, NumericUpDown timeGetValue)
        {

            //List<account> danhSach = new List<account>();

            //for (int i = 0; i < dataGridView.Rows.Count; i++)
            //{
            //    if (dataGridView.Rows[i].Cells["checkboxItemAccount"].Value.ToString() == "True")
            //    {
            //        account acc = new account();
            //        acc.UID = dataGridView.Rows[i].Cells["uidAccount"].Value.ToString();
            //        acc.COOKIE = dataGridView.Rows[i].Cells["cookieAccount"].Value.ToString();
            //        acc.TOKEN = dataGridView.Rows[i].Cells["tokenAccount"].Value.ToString();
            //        acc.PASS = dataGridView.Rows[i].Cells["passAccount"].Value.ToString();
            //        acc.M2FA = dataGridView.Rows[i].Cells["code2faAccount"].Value.ToString();
            //        acc.LIVE = dataGridView.Rows[i].Cells["tinhtrangAccount"].Value.ToString();
            //        acc.PROXY = dataGridView.Rows[i].Cells["proxyAccount"].Value.ToString();
            //        acc.TRANGTHAI = dataGridView.Rows[i].Cells["trangthaiAccount"].Value.ToString();
            //        acc.SOPAGE = dataGridView.Rows[i].Cells["pageNumberAccount"].Value.ToString();
            //        danhSach.Add(acc);
            //    }
            //}

            //ProcessLikePost(ProfileFolderPath, dataGridView, flowNum, selectProxy, danhSach, apiKeyList, type2CheckBox, keyText, timeGetValue);
            CancellationTokenSource taskStop = new CancellationTokenSource();
            taskStop = new CancellationTokenSource();

            CancellationToken ct = taskStop.Token;

            ProxyUtils proxyUtils = new ProxyUtils();

        endLess:

            int ii = 0;
            int b = 0;
            int reset = Convert.ToInt32(flowNum.Value);
            int reset1 = 0;
            int demluong = 0;
            string[] listUidPost;

            while (true)
            {
                List<string> count = new List<string>();
                int itemIndex = 0;
                int x = 0; int y = 0;
                int screenWidth = Screen.PrimaryScreen.Bounds.Width;
                int screenHeight = Screen.PrimaryScreen.Bounds.Height;
                if (screenWidth > 1920)
                {
                    screenWidth = 1920;
                }
            s:
                string uidPost = Post.getPostUid(type2CheckBox, keyText, timeGetValue);
                if (uidPost != "")
                {
                    listUidPost = uidPost.Replace("----", "|").Split('|');
                }
                else
                {
                    goto s;
                }

                for (int k = 0; k < Int32.Parse(flowNum.Value.ToString()); k++)
                {
                    if (ii == dataGridView.Rows.Count)
                    {
                        goto end;
                    }

                    if (dataGridView.Rows[ii].Cells["checkboxItemAccount"].Value.ToString() == "True")
                    {
                        account acc = new account();
                        acc.UID = dataGridView.Rows[ii].Cells["uidAccount"].Value.ToString();
                        acc.COOKIE = dataGridView.Rows[ii].Cells["cookieAccount"].Value.ToString();
                        acc.TOKEN = dataGridView.Rows[ii].Cells["tokenAccount"].Value.ToString();
                        acc.PASS = dataGridView.Rows[ii].Cells["passAccount"].Value.ToString();
                        acc.M2FA = dataGridView.Rows[ii].Cells["code2faAccount"].Value.ToString();
                        acc.LIVE = dataGridView.Rows[ii].Cells["tinhtrangAccount"].Value.ToString();
                        acc.PROXY = dataGridView.Rows[ii].Cells["proxyAccount"].Value.ToString();
                        acc.TRANGTHAI = dataGridView.Rows[ii].Cells["trangthaiAccount"].Value.ToString();
                        acc.SOPAGE = dataGridView.Rows[ii].Cells["pageNumberAccount"].Value.ToString();

                        List<string> listPageString = SQLiteUtils.getPageListByUid(acc);

                        List<page> listPage = new List<page>();
                        foreach (var list in listPageString)
                        {
                            string[] itemInfo = list.Split('|');

                            if (itemInfo.Length > 0)
                            {
                                page pageNew = new page();
                                pageNew.PAGEID = itemInfo[0];
                                pageNew.UID = itemInfo[1];
                                pageNew.NAME = itemInfo[2];
                                listPage.Add(pageNew);

                            }
                        }

                        int i = ii;
                        reset1++;

                        Thread t = new Thread(async () =>
                        {
                            DateTime currentTime = DateTime.Now;

                            if (currentTime - lastApiCallTime >= callInterval)
                            {
                                // Nếu đã đủ thời gian, thực hiện gọi API
                                if (apiKeyList.Count > 0)
                                {
                                    for (int m = 0; m < apiKeyList.Count; m++)
                                    {
                                        await proxyUtils.getNewProxy(Constants.Constants.GetNewProxyShopLike(apiKeyList[m]));
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

                            b++;
                            threadCount++;
                            numFlowLikePost++;
                            demluong++;

                            if (i > Int32.Parse(flowNum.Value.ToString()))
                            {
                                dataGridView.FirstDisplayedScrollingRowIndex = i - Int32.Parse(flowNum.Value.ToString());
                            }
                            ChromeDriver chromeDriver = null;
                            try
                            {
                                Random random = new Random();
                                int index = random.Next(apiKeyList.Count);
                                string randomKey = apiKeyList[index];
                                string proxy = await proxyUtils.getCurrentProxy(Constants.Constants.GetCurrentProxyShopLike(randomKey, "hd"));
                                acc.PROXY = proxy;

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

                                chromeDriver = _chromeDriverUtils.initChrome(ProfileFolderPath, acc, itemIndex, flowNum, selectProxy, x, y);
                            } catch
                            {

                            }
                            _listDriver.Add(chromeDriver);

                            //if (isStop) { goto end2; }

                            try
                            {
                                Random rd = new Random();
                                int demloi = 0;

                                for (int i2 = 0; i2 < listPage.Count; i2++)
                                {
                                    for (int k1 = 0; k1 < listUidPost.Length; k1++)
                                    {
                                        if (SQLiteUtils.checkPostLikedByPage(listPage[i2].PAGEID, listUidPost[k1]))
                                        {
                                            Console.WriteLine("-----Post này đã Like ---->");
                                            break;
                                        }
                                    a:
                                        int dem = 0;
                                        ChromeDriverUtils.updateStatusChrome(dataGridView, acc, "Vào Post: " + listUidPost[k1]);
                                    lai:
                                        chromeDriver.Navigate().GoToUrl("https://www.facebook.com/");
                                        if (ChromeDriverUtils.FindTextInChrome(chromeDriver, "Chào mừng bạn đến với Trang mới!", "Chào mừng bạn đến với Trang mới!"))
                                        {
                                            try
                                            {
                                                //*[@id="facebook"]/body/div[2]/div[1]/div/div[2]/div/div/div/div[1]
                                                chromeDriver.FindElement(By.XPath("//*[@id=\"facebook\"]/body/div[4]/div[1]/div/div[2]/div/div/div/div[1]/div")).Click();
                                            }
                                            catch
                                            {
                                                chromeDriver.FindElement(By.XPath("//*[@id=\"facebook\"]/body/div[5]/div[1]/div/div[2]/div/div/div/div[1]/div")).Click();

                                            }

                                            //if (chromeDriver.FindElement(By.XPath("//*[@id=\"facebook\"]/body/div[4]/div[1]/div/div[2]/div/div/div/div[1]/div")) != null)
                                            //{
                                            //    chromeDriver.FindElement(By.XPath("//*[@id=\"facebook\"]/body/div[4]/div[1]/div/div[2]/div/div/div/div[1]/div")).Click();
                                            //}

                                            //if (chromeDriver.FindElement(By.XPath("//*[@id=\"facebook\"]/body/div[5]/div[1]/div/div[2]/div/div/div/div[1]/div")) != null)
                                            //{
                                            //    chromeDriver.FindElement(By.XPath("//*[@id=\"facebook\"]/body/div[5]/div[1]/div/div[2]/div/div/div/div[1]/div")).Click();
                                            //}

                                            //chromeDriver.FindElement(By.XPath("//*[@id=\"facebook\"]/body/div[2]/div[1]/div/div[2]/div/div/div/div[1]")).Click();
                                        }

                                        try
                                        {
                                            chromeDriver.Manage().Cookies.DeleteCookieNamed("i_user");
                                            Cookie cookie = new Cookie("i_user", listPage[i2].PAGEID);
                                            chromeDriver.Manage().Cookies.AddCookie(cookie);
                                        }
                                        catch
                                        {

                                        }

                                        chromeDriver.Navigate().GoToUrl("https://www.facebook.com/");

                                        if (ChromeDriverUtils.FindTextInChrome(chromeDriver, "Chào mừng bạn đến với Trang mới!", "Chào mừng bạn đến với Trang mới!"))
                                        {
                                            try
                                            {
                                                chromeDriver.FindElement(By.XPath("//*[@id=\"facebook\"]/body/div[4]/div[1]/div/div[2]/div/div/div/div[1]/div")).Click();
                                            }
                                            catch
                                            {
                                                chromeDriver.FindElement(By.XPath("//*[@id=\"facebook\"]/body/div[5]/div[1]/div/div[2]/div/div/div/div[1]/div")).Click();

                                            }

                                        }

                                        chromeDriver.Navigate().GoToUrl("https://www.facebook.com/" + listUidPost[k1]);

                                        if (ChromeDriverUtils.FindClickElementInChrome(chromeDriver, "Đăng nhập", "Log In", false) || ChromeDriverUtils.FindClickElementInChrome(chromeDriver, "Đăng nhập", "Choose your account", false))
                                        {
                                            ChromeDriverUtils.updateStatusChrome(dataGridView, acc, "Like Post Lỗi - Acc Logout " + listUidPost[k1]);
                                            ChromeDriverUtils.updateStatusAcc(dataGridView, acc, "Die");
                                            //dataGridView1.Rows[i].Cells[1].Value = false;
                                            //dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(248, 198, 198);
                                            //LoadLog(DateTime.Now + ":  " + dataGridView1.Rows[i].Cells["Ten1"].Value.ToString() + " :Like Post Lỗi - Acc Logout! " + uidlike[k1], "red");
                                            //goto ne;
                                        }
                                        else
                                        {
                                            while (true)
                                            {

                                                try
                                                {
                                                    try
                                                    {
                                                        chromeDriver.FindElement(By.XPath("/html/body/div[1]/div/div[4]/div/div[1]/div/div/div[2]/footer/div/div/div[1]/a")).Click();
                                                        ChromeDriverUtils.updateStatusChrome(dataGridView, acc, "Like Post Lỗi - Acc Logout " + uidPost[k1]);
                                                        count.Add(uidPost[k1] + "|" + listPage[i].PAGEID);
                                                        break;
                                                    }
                                                    catch
                                                    {
                                                        try
                                                        {
                                                            if (chromeDriver.Url.Contains("/watch"))
                                                            {
                                                                ChromeDriverUtils.updateStatusChrome(dataGridView, acc, "Lỗi : dạng wath livetream k like  đc " + uidPost[k1]);
                                                                Post.upShopLike(listUidPost[k1], 9999, keyText);

                                                            }
                                                            else if (chromeDriver.Url.Contains("/reel"))
                                                            {
                                                                ChromeDriverUtils.updateStatusChrome(dataGridView, acc, "Lỗi : dạng wath reel k like  đc " + uidPost[k1]);
                                                                Post.upShopLike(listUidPost[k1], 9999, keyText);
                                                            }
                                                            else if (ChromeDriverUtils.FindClickElementInChrome(chromeDriver, "Thích", "Like", true))
                                                            {
                                                                ChromeDriverUtils.updateStatusChrome(dataGridView, acc, "Like Thành công Post " + uidPost[k1]);
                                                                post post = new post();
                                                                post.POSTID = listUidPost[k1];
                                                                post.PAGEID = listPage[i2].PAGEID;
                                                                SQLiteUtils.insertPost(post);
                                                                count.Add(listUidPost[k1] + "|" + listPage[i2].PAGEID);

                                                            }
                                                            else if (ChromeDriverUtils.FindTextInChrome(chromeDriver, "Chúc bạn sinh nhật vui vẻ", "Chúc bạn sinh nhật vui vẻ"))
                                                            {
                                                                demloi++;
                                                                if (demloi == 2)
                                                                {
                                                                    ChromeDriverUtils.updateStatusChrome(dataGridView, acc, "Like Post Lỗi - Acc CHECKPOINT " + uidPost[k1]);
                                                                    ChromeDriverUtils.updateStatusAcc(dataGridView, acc, "Die");
                                                                    //dataGridView1.Rows[i].Cells[1].Value = false;
                                                                    //dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(248, 198, 198);
                                                                    //LoadLog(DateTime.Now + ":  " + dataGridView1.Rows[i].Cells["Ten1"].Value.ToString() + " :Like Post Lỗi - Acc CHECKPOINT! " + uidlike[k1], "red");
                                                                    //goto ne;
                                                                }
                                                                try
                                                                {
                                                                    chromeDriver.FindElement(By.XPath("/html/body/div[1]/div/div[4]/div/div[1]/div/div/div/div/div[3]/div/div[1]/div/span/span")).Click();
                                                                }
                                                                catch
                                                                {
                                                                    ChromeDriverUtils.FindClickElementInChrome(chromeDriver, "OK", "OK", true);

                                                                }
                                                                goto a;
                                                            }
                                                            else if (chromeDriver.Url.Contains("/actor_experience"))
                                                            {
                                                                ChromeDriverUtils.updateStatusChrome(dataGridView, acc, "Lỗi : dạng nick bị check cmt spam hoặc cp lạ " + uidPost[k1]);
                                                                Post.upShopLike(listUidPost[k1], 9999, keyText);

                                                            }
                                                            else if (ChromeDriverUtils.FindTextInChrome(chromeDriver, "Không tìm thấy nội dung", "Liên kết bạn truy cập") || ChromeDriverUtils.FindTextInChrome(chromeDriver, "Không tìm thấy nội dung", "Liên kết bạn truy cập"))
                                                            {
                                                                ChromeDriverUtils.updateStatusChrome(dataGridView, acc, "Không tìm thấy nội dung " + listUidPost[k1]);
                                                                Post.upShopLike(listUidPost[k1], 9999, keyText);
                                                            }
                                                            else if (chromeDriver.Url.Contains("/checkpoint") || ChromeDriverUtils.FindClickElementInChrome(chromeDriver, "Cần phê duyệt đăng nhập", "Login approval needed", false)
                                                            || ChromeDriverUtils.FindClickElementInChrome(chromeDriver, "Vui lòng xác nhận danh tính của bạn", "Please confirm your identity", false))
                                                            {
                                                                ChromeDriverUtils.updateStatusChrome(dataGridView, acc, "Like Post Lỗi - Acc CHECKPOINT " + listUidPost[k1]);
                                                                ChromeDriverUtils.updateStatusAcc(dataGridView, acc, "Die");
                                                                //dataGridView1.Rows[i].Cells[1].Value = false;
                                                                //dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(248, 198, 198);
                                                                //LoadLog(DateTime.Now + ":  " + dataGridView1.Rows[i].Cells["Ten1"].Value.ToString() + " :Like Post Lỗi - Acc CHECKPOINT! " + uidlike[k1], "red");
                                                                //goto ne;

                                                            }
                                                            else if (ChromeDriverUtils.FindClickElementInChrome(chromeDriver, "Đăng nhập", "Login", false) || ChromeDriverUtils.FindClickElementInChrome(chromeDriver, "Đăng nhập", "Choose your account", false))
                                                            {
                                                                ChromeDriverUtils.updateStatusChrome(dataGridView, acc, "Like Post Lỗi - Acc Logout " + listUidPost[k1]);
                                                                ChromeDriverUtils.updateStatusAcc(dataGridView, acc, "Die");
                                                                //dataGridView1.Rows[i].Cells[1].Value = false;
                                                                //dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(248, 198, 198);
                                                                //LoadLog(DateTime.Now + ":  " + dataGridView1.Rows[i].Cells["Ten1"].Value.ToString() + " :Like Post Lỗi - Acc Logout! " + uidlike[k1], "red");
                                                                //goto ne;
                                                            }
                                                            else if (ChromeDriverUtils.FindTextInChrome(chromeDriver, "Chia sẻ", "Share"))
                                                            {
                                                                ChromeDriverUtils.updateStatusChrome(dataGridView, acc, "Không có nút LIKE" + listUidPost[k1]);
                                                                count.Add(uidPost[k1] + "|delete");
                                                            }
                                                            else if (ChromeDriverUtils.FindTextInChrome(chromeDriver, "của bạn đã bị khóa", "been locked"))
                                                            {
                                                                ChromeDriverUtils.updateStatusChrome(dataGridView, acc, "Tài khoản của bạn đã bị khóa : " + listUidPost[k1]);
                                                                ChromeDriverUtils.updateStatusAcc(dataGridView, acc, "Die");
                                                                //dataGridView1.Rows[i].Cells[1].Value = false;
                                                                //dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(248, 198, 198);
                                                                //goto ne;
                                                            }
                                                            else if (ChromeDriverUtils.FindTextInChrome(chromeDriver, "Bạn hiện không thể bày tỏ cảm xúc", "Bạn hiện không thể bày tỏ cảm xúc"))
                                                            {
                                                                ChromeDriverUtils.updateStatusChrome(dataGridView, acc, "Bạn hiện không thể bày tỏ cảm xúc : " + listUidPost[k1]);
                                                                ChromeDriverUtils.updateStatusAcc(dataGridView, acc, "Checkpoint");
                                                                //dataGridView1.Rows[i].Cells[1].Value = false;
                                                                //dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(248, 198, 198);
                                                                //goto ne;
                                                            }
                                                            else
                                                            {
                                                                if (dem < 1)
                                                                {
                                                                    dem++;

                                                                    goto lai;
                                                                }

                                                            }
                                                        }
                                                        catch
                                                        {
                                                            if (dem < 1)
                                                            {
                                                                dem++;

                                                                goto lai;
                                                            }
                                                        }
                                                    }
                                                    break;

                                                }
                                                catch
                                                {
                                                    try
                                                    {
                                                        chromeDriver.FindElement(By.XPath("/html/body/div[1]/div/div[4]/div/div[1]/div/div/div/div/div[3]/div/div[1]/div/span/span/div")).Click();
                                                    }
                                                    catch
                                                    {
                                                        ChromeDriverUtils.FindClickElementInChrome(chromeDriver, "OK", "OK", true);
                                                    }
                                                    if (dem < 1)
                                                    {
                                                        dem++;

                                                        goto lai;
                                                    }
                                                }
                                            }
                                        }
                                        int delay = rd.Next(Convert.ToInt32(5), Convert.ToInt32(5));
                                        while (delay > 0)
                                        {
                                            delay--;
                                        }
                                    }
                                }
                            }
                            catch
                            {

                            }

                        });
                        t.Start();
                        t.IsBackground = true;
                        Thread.Sleep(1000);
                    } else
                    {
                        k--;
                    }
                    ii++;
                }
            }
        end:
            while (true)
            {
                Thread.Sleep(1);
                if (threadCount == 0 || stopLikePage)
                {
                    if (stopLikePage)
                    {
                        break;
                    }
                    for (int kk = 0; kk < dataGridView.Rows.Count; kk++)
                    {
                        dataGridView.Rows[kk].DefaultCellStyle.BackColor = Color.FromArgb(203, 245, 203);
                    }


                    goto endLess;
                }
            }
        }

        /*
         * Process Reg Page
         */

        public async void ProcessLikePost(string ProfileFolderPath, DataGridView dataGridView, NumericUpDown flowNum, ComboBox selectProxy, List<account> listAcccounts, List<string> apiKeyList, CheckBox type2CheckBox, TextBox keyText, NumericUpDown timeGetValue)
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
                        await proxyUtils.getNewProxy(Constants.Constants.GetNewProxyShopLike(apiKeyList[i]));
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
            int x = 0; int y = 0;
            SemaphoreSlim semaphore = new SemaphoreSlim(maxConcurrency);
           while (stopLikePage == false)
           {

                string uidPost = Post.getPostUid(type2CheckBox, keyText, timeGetValue);
                string[] listUidPost = uidPost.Replace("----", "|").Split('|');

                for (int i = 0; i < listAcccounts.Count; i += batchSize)
                {
                    List<account> batch = listAcccounts.GetRange(i, Math.Min(batchSize, listAcccounts.Count - i));


                    try
                    {
                        foreach (var item in batch)
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
                        }

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
        public async Task processItemLikePost(string ProfileFolderPath, account item, int itemIndex, NumericUpDown flowNum, ComboBox selectProxy, DataGridView dataGridView, int x, int y, List<string> listPageString, CheckBox type2CheckBox, TextBox keyText, NumericUpDown timeGetValue, string[] listUidPost)
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

        public void movePageToUid(string ProfileFolderPath, DataGridView dataGridView, NumericUpDown flowNum, ComboBox selectProxy, List<string> apiKeyList)
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

        public async void ProcessMovePageToUid(string ProfileFolderPath, DataGridView dataGridView, NumericUpDown flowNum, ComboBox selectProxy, List<account> listAcccounts, List<string> apiKeyList)
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
                        await proxyUtils.getNewProxy(Constants.Constants.GetNewProxyShopLike(apiKeyList[i]));
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
        public async Task processItemMovePageToUid(string ProfileFolderPath, account item, int itemIndex, NumericUpDown flowNum, ComboBox selectProxy, DataGridView dataGridView, int x, int y, List<string> listPageString)
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
