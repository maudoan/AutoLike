﻿using AutoLike.Model;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OtpNet;
using System;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoLike.Utils
{
    public class ChromeDriverUtils
    {
        int screenHeight = SystemInformation.VirtualScreen.Height;
        int screenWidth = SystemInformation.VirtualScreen.Width;

        public ChromeDriver initChrome(string ProfileFolderPath,account account,int index, NumericUpDown flowNum, ComboBox selectProxy)
        {

          
            if (screenHeight > 1920)
            {
                screenWidth = 1920;
            }
            ChromeOptions co = new ChromeOptions(); //khaibao option chrome
            ChromeDriverService chromeDriverService = ChromeDriverService.CreateDefaultService();
            chromeDriverService.HideCommandPromptWindow = true; //ẩn CMD điều khiển chrome
            if (selectProxy.Items.Equals("Use Proxy"))
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
            //if (checkBox8.Checked)
            //{
            //    co.AddArguments("--mute-audio", "--blink-settings=imagesEnabled=false", "--disable-notifications", "--ignore-certificate-errors", "--disable-gpu");
            //    co.AddExcludedArgument("enable-automation");
            //    co.AddAdditionalCapability("useAutomationExtension", false);
            //}
            //if (cbua.Checked)
            //{
            //    string ua = txtua.Text;
            //    if (ua != "")
            //    {
            //        co.AddArguments("--user-agent=" + ua);
            //    }

            //}

            //if (checkBox30.Checked == true)
            //{
            //    co.AddArguments("headless");
            //}

            //co.AddArgument("--app=https://facebook.com");
            int X = 0;
            int Y = 0;
            //if (cbseeding_chrome.Checked && cbsharegr_chrome.Checked)
            //{

            X = screenWidth / Convert.ToInt32(flowNum.Value);
            Y = screenHeight;
            //    co.AddArgument("--window-size=" + 1000 + "," + 1000);

            //}
            //else
            //{
            //    X = screenWidth / 2;
            //    Y = screenHeight / 1;
            //    co.AddArgument("--window-size=" + X + "," + Y);
            //}



            int X1 = Convert.ToInt32((index - 1) % 2) * X;
            int Y1 = Convert.ToInt32((index - 1) / 2) * (screenHeight / ((Convert.ToInt32(flowNum.Value) / 2) + 1));
            co.AddArgument("--window-position=" + X1 + "," + Y1);



            string nameCount = account.UID;
            //if (uid == "")
            //{
            //    nameCount = uidFromCookie;
            //}
            //else
            //{
            //}
            try
            {
                // drivers[uid].Quit();
            }
            catch { }
            try
            {
                co.AddArguments("user-data-dir=" + ProfileFolderPath + "\\" + nameCount);
            }
            catch
            {
              
            }

            return new ChromeDriver(chromeDriverService, co);
        }

        public static void ChromeDetroy(ChromeDriver driver)
        {
            driver.Close();
            driver.Quit();
        }

        public static async Task<bool> FindTextInChrome(ChromeDriver driver, string textVN, string textEN)
        {
            bool result = false;
            try
            {

                int dem = 0;
                while (true)
                {
                    String find = driver.FindElement(By.TagName("body")).Text;
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
                    await Task.Delay(200);
                }

            }
            catch { }
            return result;
        }

        public static async Task<bool> FindClickElementInChrome(ChromeDriver driver, string textVN, string textEN, bool click)
        {
            bool result = false;
            int dem = 0;
            while (true)
            {
                String find = driver.FindElement(By.TagName("body")).Text;
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
                await Task.Delay(1000);
                dem++;
            }
            return result;
        }

    }
}