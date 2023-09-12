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

        public void LoginChromeWithCookieToken(string ProfileFolderPath, DataGridView dataGridView, NumericUpDown flowNum, ComboBox selectProxy, TextBox apiKeyTextBox)
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

            ProcessLoginChromeCookieToken(ProfileFolderPath, dataGridView, flowNum, selectProxy, danhSach, apiKeyTextBox);
        }

        public async void ProcessLoginChromeCookieToken(string ProfileFolderPath, DataGridView dataGridView, NumericUpDown flowNum, ComboBox selectProxy, List<account> listAcccounts, TextBox apiKeyTextBox)
        {


            int batchSize = 5; // Số lượng item mỗi lần xử lý
            int maxThreads = 5; // Số lượng luồng tối đa

            int itemindex = 0;
            ProxyUtils proxyUtils = new ProxyUtils();

            if (apiKeyTextBox.Text != null && apiKeyTextBox.Text != "")
            {
                await proxyUtils.getNewProxy(Constants.Constants.GetNewProxyShopLike(apiKeyTextBox.Text));

            }

            ParallelOptions options = new ParallelOptions
            {
                MaxDegreeOfParallelism = maxThreads
            };

            // Chia danh sách thành các phần (batch)
            var batches = PartitionList(listAcccounts, batchSize);

            Parallel.ForEach(batches, options, async batch =>
            {
                foreach (var item in batch)
                {
                    string proxy = "";
                    itemindex++;
                    proxy = await proxyUtils.getCurrentProxy(Constants.Constants.GetCurrentProxyShopLike(apiKeyTextBox.Text, "hd"));
                    ProcessItem(ProfileFolderPath,item, itemindex, flowNum, selectProxy, proxy);
                }
            });
        }
        public void ProcessItem(string ProfileFolderPath, account item, int itemindex, NumericUpDown flowNum, ComboBox selectProxy, string proxy)
        {
            // Đây là nơi bạn thực hiện công việc xử lý trên mỗi item

            item.PROXY = proxy;
            // Thực hiện công việc của bạn trên item ở đây
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

            Thread.Sleep(1000); // Ví dụ: Giả định công việc mất 1 giây để hoàn thành.

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
                    item.TRANGTHAI = "Checkpoint !...";
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

        public static IEnumerable<List<T>> PartitionList<T>(List<T> source, int batchSize)
        {
            for (int i = 0; i < source.Count; i += batchSize)
            {
                yield return source.GetRange(i, Math.Min(batchSize, source.Count - i));
            }
        }
    }
}
