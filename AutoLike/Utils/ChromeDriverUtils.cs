using AutoLike.Model;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OtpNet;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoLike.Utils
{
    public class ChromeDriverUtils
    {
        int screenWidth = Screen.PrimaryScreen.Bounds.Width;
        int screenHeight = Screen.PrimaryScreen.Bounds.Height;

        public ChromeDriver initChrome(string ProfileFolderPath,account account,int index, NumericUpDown flowNum, ComboBox selectProxy, int x, int y)
        {

          
            if (screenWidth > 1920)
            {
                screenWidth = 1920;
            }
            ChromeOptions co = new ChromeOptions(); //khaibao option chrome
            ChromeDriverService chromeDriverService = ChromeDriverService.CreateDefaultService();
            chromeDriverService.HideCommandPromptWindow = true; //ẩn CMD điều khiển chrome
                                                                //
            if (account.PROXY != "")
            {
                co.AddArguments("--proxy-server=" + account.PROXY);
                co.Proxy = null;
            }


            co.AddArgument("--disable-background-networking");
            co.AddArgument("--disable-client-side-phishing-detection");
            co.AddArgument("--disable-default-apps");
            co.AddArgument("--disable-hang-monitor");
            co.AddArgument("--disable-popup-blocking");
            co.AddArgument("--disable-prompt-on-repost");
            co.AddArgument("--disable-sync");
            co.AddArgument("--enable-automation");
            co.AddArgument("--enable-blink-features=ShadowDOMV05");
            co.AddArgument("--enable-logging");
            co.AddArgument("--log-level=0");
            co.AddArgument("--no-first-run");
            co.AddArgument("--no-service-autorun");
            co.AddArgument("--password-store=basic");
            co.AddArgument("--remote-debugging-port=0");
            co.AddArgument("--test-type=webdriver");
            co.AddArgument("--use-mock-keychain");
            co.AddArgument("--disable-notifications");
            co.AddArgument("mute-audio");

            //int X = 0;
            //int Y = 0;


            //X = screenWidth / Convert.ToInt32(5);
            //Y = screenHeight;
            co.AddArgument("--window-size=" + 500 + "," + 500);

            ////int X1 = Convert.ToInt32((index - 1) % 2) * X;
            ////int Y1 = Convert.ToInt32((index - 1) / 2) * (screenHeight / ((Convert.ToInt32(5) / 2) + 1));
            //int row = index / 5;
            //int col = index % 5;
            //int xOffset = col * (screenWidth / 5);
            //int yOffset = row * (screenHeight / 2);
            co.AddArgument("--window-position=" + x + "," + y);



            string nameCount = account.UID;
  
            try
            {
                co.AddArguments("user-data-dir=" + ProfileFolderPath + "\\" + nameCount);
            }
            catch
            {
              
            }

            return new ChromeDriver(chromeDriverService, co);
        }

        public static void ChromeDetroy(ChromeDriver driver, List<ChromeDriver> listChromeDriver)
        {
           driver.Close();
           driver.Quit();
           //listChromeDriver.Remove(driver);
           //sxepChrome(listChromeDriver);
        }

        public static bool FindTextInChrome(ChromeDriver driver, string textVN, string textEN)
        {
            bool result = false;
            try
            {

                int dem = 0;
                while (true)
                {
                    string find = driver.FindElement(By.TagName("body")).Text;
                    if (find.ToLower().Contains(textVN.ToLower()) || find.ToLower().Contains(textEN.ToLower()))
                    {
                        if (find.ToLower().Contains(textVN.ToLower()))
                        {
                            //Trangthaichrome(i, "OK: " + text1);
                        }
                        else
                        {
                            //Trangthaichrome(i, "OK: " + text2);
                        }
                        result = true;
                        break;
                    }
                    else
                    {
                        //dataGridView1.Rows[i].Cells["Trangthai"].Value = "NOT: " + text2;

                    }
                    if (dem == 1)
                    {
                        break;
                    }
                    dem++;
                    Thread.Sleep(100);
                }

            }
            catch { }
            return result;
        }

        public static bool FindClickElementInChrome(ChromeDriver driver, string textVN, string textEN, bool click)
        {
            bool result = false;
            int dem = 0;
            while (true)
            {
                string find = driver.FindElement(By.TagName("body")).Text;
                try
                {
                    var a = driver.FindElement(By.XPath("//*[text()='" + textVN + "']"));
                    if (a.Displayed)
                    {
                        if (click)
                        {
                            //Trangthaichrome(i, "Click: " + text1);
                            a.Click();
                        }
                        result = true;
                        break;
                    }
                }
                catch
                {
                    try
                    {
                        var a = driver.FindElement(By.XPath("//*[text()='" + textEN + "']"));
                        if (a.Displayed)
                        {
                            if (click)
                            {
                                //Trangthaichrome(i, "Click: " + text2);

                                a.Click();
                            }
                            result = true;
                            break;
                        }
                    }
                    catch
                    {

                    }
                }
                if (dem == 2)
                {
                    break;
                }
                Thread.Sleep(100);
                dem++;
            }
            return result;
        }

        public static string getcookie(ChromeDriver driver)
        {
            string cookie = "";
            int dem = 0;
        l:
            string lines = "";

            for (int t1 = 0; t1 < 8; t1++)
            {
                try
                {
                    var cookiees = driver.Manage().Cookies.AllCookies;
                    lines = cookiees[t1].ToString() + ";" + lines;
                }
                catch { }
            }
            string c_user = Regex.Match(lines, "c_user=[0-9]{0,}").ToString();
            string wd = Regex.Match(lines, "wd=[0-9a-zA-Z_.%-]{0,}").ToString();
            string datr = Regex.Match(lines, "datr=[a-zA-Z0-]{0,}").ToString();
            string sub = Regex.Match(lines, "sb=[0-9a-zA-Z_.%-]{0,}").ToString();
            string fr = Regex.Match(lines, "fr=[0-9a-zA-Z_.%-]{0,}").ToString();
            string xs = Regex.Match(lines, "xs=[0-9a-zA-Z_.%-]{0,}").ToString();
            string cookieget;
            cookieget = c_user + ";" + datr + ";" + sub + ";" + fr + ";" + xs + ";" + wd;
            if (cookieget.Contains("c_user"))
            {
                cookie = cookieget;
            }
            else
            {
                if (ChromeDriverUtils.FindTextInChrome(driver, "Bạn phải đăng nhập", "Bạn phải đăng nhập"))
                {
                    cookie = "";
                    goto end;
                }
                if (dem == 2)
                {
                    cookie = "";
                    goto end;
                }
                dem++;

                goto l;
            }
        end:
            return cookie;

        }

        public static void updateStatusChrome(DataGridView dataGridView,account item, string text)
        {
            for(int i = 0; i < dataGridView.Rows.Count; i++)
            {
                if(item.UID == dataGridView.Rows[i].Cells["uidAccount"].Value.ToString())
                {
                    dataGridView.Rows[i].Cells["trangthaiAccount"].Value = "--> " + text;
                    item.TRANGTHAI = dataGridView.Rows[i].Cells["trangthaiAccount"].Value.ToString();
                }
            }
            
        }

        public static void updateStatusAcc(DataGridView dataGridView, account item, string text)
        {
            for (int i = 0; i < dataGridView.Rows.Count; i++)
            {
                if (item.UID == dataGridView.Rows[i].Cells["uidAccount"].Value.ToString())
                {
                    dataGridView.Rows[i].Cells["tinhtrangAccount"].Value = text;
                    dataGridView.Rows[i].DefaultCellStyle.ForeColor = Color.DarkRed;
                    item.LIVE = dataGridView.Rows[i].Cells["tinhtrangAccount"].Value.ToString();
                }
            }

        }

        public static void updateNumPage(DataGridView dataGridView, account item)
        {
            for (int i = 0; i < dataGridView.Rows.Count; i++)
            {
                if (item.UID == dataGridView.Rows[i].Cells["uidAccount"].Value.ToString())
                {
                    dataGridView.Rows[i].Cells["pageNumberAccount"].Value = item.SOPAGE;
                    dataGridView.Rows[i].DefaultCellStyle.ForeColor = Color.DarkRed;
                }

            }

        }

        public static void sxepChrome(List<ChromeDriver> listChromeDrivers)
        {
            int screenHeight = SystemInformation.VirtualScreen.Height;
            int screenWidth = SystemInformation.VirtualScreen.Width;
            if (screenWidth > 1920)
            {
                screenWidth = 1920;
            }
            int x = 0;
            int y = 0;
            try
            {
                if (listChromeDrivers.Count > 0)
                {

                    for (int i = 0; i < listChromeDrivers.Count; i++)
                    {
                        if (i == 0 || i == 10 || i == 20 || i == 30)
                        {
                            y = 0;
                            x = 0;
                        }
                        else if ((i > 0 && i < 5) || (i > 10 && i < 15) || (i > 20 && i < 25) || (i > 30 && i < 35))
                        {
                            y = 0;
                            x += screenWidth / 5;
                        }
                        else if (i == 5 || i == 15 || i == 25 || i == 35)
                        {
                            y = screenHeight / 2;
                            x = 0;
                        }
                        else if ((i > 5 && i < 10) || (i > 15 && i <= 20) || (i > 25 && i < 30) || (i > 35 && i < 40))
                        {
                            y = screenHeight / 2;
                            x += screenWidth / 5;
                        }
                        else { }
                        var newpos = listChromeDrivers[i];
                        newpos.Manage().Window.Position = new Point(x, y);
                    }
                }

            }
            catch { }
        }

    }
}
