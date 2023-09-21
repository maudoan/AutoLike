using AutoLike.Model;
using AutoLike.Utils;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace AutoLike.Features
{
    public class Post
    {
        public static string getPostUid(CheckBox type2CheckBox, TextBox keyText, NumericUpDown timeGetValue)
        {
            string uid = "";
            string key = keyText.Text;

            string type = string.Empty;
            if (type2CheckBox.Checked) 
            { 
                type = "2"; 
            }
            else 
            { 
                type = "1"; 
            }
            while (true)
            {

                try
                {
                
                    WebRequest requestmave = WebRequest.Create(Constants.Constants.GetPostUidShopLike(key, type));
                    //thêm 1 checkbox nếu tích thì stype=2, không tích thì stype=1
                    using (WebResponse response3 = requestmave.GetResponse())
                    using (StreamReader stream3 = new StreamReader(response3.GetResponseStream()))
                    {
                        uid = stream3.ReadToEnd();
                    }
                    if (uid.Contains("error"))
                    {
                        int timeGet = Convert.ToInt32(timeGetValue.Value);
                        while (timeGet > 0)
                        {
                            timeGet--;
                            Thread.Sleep(1000);
                        }
                    }
                    else
                    {
                 
                        break;
                    }
                }
                catch
                {
                    Thread.Sleep(100);
                }
            }
            return uid;
        }

        public void LikePost(ChromeDriver driver, DataGridView dataGridView, account acc, string[] uidPost,List<page> listPage)
        {
            try
            {
                List<string> count = new List<string>();

                Random rd = new Random();
                int demloi = 0;

                for(int i = 0; i < listPage.Count; i++)
                {
                    for (int k1 = 0; k1 < uidPost.Length; k1++)
                    {
                    a:
                        int dem = 0;
                        ChromeDriverUtils.updateStatusChrome(dataGridView, acc, "Vào Post: " + uidPost[k1]);
                    lai:
                        driver.Navigate().GoToUrl("https://www.facebook.com/");
                        Thread.Sleep(1000);
                        if (ChromeDriverUtils.FindTextInChrome(driver, "Chào mừng bạn đến với Trang mới!", "Chào mừng bạn đến với Trang mới!"))
                        {
                            driver.FindElement(By.XPath("//*[@id=\"facebook\"]/body/div[4]/div[1]/div/div[2]/div/div/div/div[1]/div")).Click();
                        }
                        Thread.Sleep(3000);
                        driver.FindElement(By.XPath("/html/body/div[1]/div/div[1]/div/div[2]/div[5]/div[1]/span/div/div[1]/div")).Click();

                        Thread.Sleep(3000);
                        if (ChromeDriverUtils.FindTextInChrome(driver, "Xem tất cả trang cá nhân", "Xem tất cả trang cá nhân"))
                        {
                            IWebElement element = driver.FindElement(By.XPath($"//*[contains(text(), 'Xem tất cả trang cá nhân')]"));
                            element.Click();
                            Thread.Sleep(3000);
                        }
                        if (ChromeDriverUtils.FindTextInChrome(driver, "Trang & trang cá nhân của bạn", "Trang & trang cá nhân của bạn"))
                        {
                            try
                            {
                                switch (i)
                                {
                                    case 0:
                                        driver.FindElement(By.XPath("/html/body/div[4]/div[1]/div/div[2]/div/div/div/div/div/div/div[2]/div[2]/div[3]/div/div/div[2]/div/div[1]/div[1]/div/div/div[2]/div/div[1]/div[2]/div[2]/div/div")).Click();
                                        Thread.Sleep(3000);
                                        break;
                                    case 1:
                                        driver.FindElement(By.XPath("/html/body/div[4]/div[1]/div/div[2]/div/div/div/div/div/div/div[2]/div[2]/div[3]/div/div/div[2]/div/div[1]/div[1]/div/div/div[3]/div/div[1]/div[2]/div[2]/div/div")).Click();
                                        Thread.Sleep(3000);
                                        break;
                                    case 2:
                                        driver.FindElement(By.XPath("/html/body/div[4]/div[1]/div/div[2]/div/div/div/div/div/div/div[2]/div[2]/div[3]/div/div/div[2]/div/div[1]/div[1]/div/div/div[4]/div/div[1]/div[2]/div[2]/div/div")).Click();
                                        Thread.Sleep(3000);
                                        break;
                                    case 3:
                                        driver.FindElement(By.XPath("/html/body/div[4]/div[1]/div/div[2]/div/div/div/div/div/div/div[2]/div[2]/div[3]/div/div/div[2]/div/div[1]/div[1]/div/div/div[5]/div/div[1]/div[2]/div[2]/div/div")).Click();
                                        Thread.Sleep(3000);
                                        break;
                                    case 4:
                                        driver.FindElement(By.XPath("/html/body/div[4]/div[1]/div/div[2]/div/div/div/div/div/div/div[2]/div[2]/div[3]/div/div/div[2]/div/div[1]/div[1]/div/div/div[6]/div/div[1]/div[2]/div[2]/div/div")).Click();
                                        Thread.Sleep(3000);
                                        break;
                                    case 5:
                                        driver.FindElement(By.XPath("/html/body/div[4]/div[1]/div/div[2]/div/div/div/div/div/div/div[2]/div[2]/div[3]/div/div/div[2]/div/div[1]/div[1]/div/div/div[7]/div/div[1]/div[2]/div[2]/div/div")).Click();
                                        Thread.Sleep(3000);
                                        break;
                                    case 6:
                                        driver.FindElement(By.XPath("/html/body/div[4]/div[1]/div/div[2]/div/div/div/div/div/div/div[2]/div[2]/div[3]/div/div/div[2]/div/div[1]/div[1]/div/div/div[8]/div/div[1]/div[2]/div[2]/div/div")).Click();
                                        Thread.Sleep(3000);
                                        break;
                                    case 7:
                                        driver.FindElement(By.XPath("/html/body/div[4]/div[1]/div/div[2]/div/div/div/div/div/div/div[2]/div[2]/div[3]/div/div/div[2]/div/div[1]/div[1]/div/div/div[9]/div/div[1]/div[2]/div[2]/div/div")).Click();
                                        Thread.Sleep(3000);
                                        break;
                                    case 8:
                                        driver.FindElement(By.XPath("/html/body/div[4]/div[1]/div/div[2]/div/div/div/div/div/div/div[2]/div[2]/div[3]/div/div/div[2]/div/div[1]/div[1]/div/div/div[10]/div/div[1]/div[2]/div[2]/div/div")).Click();
                                        Thread.Sleep(3000);
                                        break;
                                    default:
                                        // code block
                                        break;
                                }

                               
                            }
                            catch
                            {
                                switch (i)
                                {
                                    case 0:
                                        driver.FindElement(By.XPath("/html/body/div[5]/div[1]/div/div[2]/div/div/div/div/div/div/div[2]/div[2]/div[3]/div/div/div[2]/div/div[1]/div[1]/div/div/div[2]/div/div[1]/div[2]/div[2]/div/div")).Click();
                                        Thread.Sleep(3000);
                                        break;
                                    case 1:
                                        driver.FindElement(By.XPath("/html/body/div[4]/div[1]/div/div[2]/div/div/div/div/div/div/div[2]/div[2]/div[3]/div/div/div[2]/div/div[1]/div[1]/div/div/div[3]/div/div[1]/div[2]/div[2]/div/div")).Click();
                                        Thread.Sleep(3000);
                                        break;
                                    case 2:
                                        driver.FindElement(By.XPath("/html/body/div[4]/div[1]/div/div[2]/div/div/div/div/div/div/div[2]/div[2]/div[3]/div/div/div[2]/div/div[1]/div[1]/div/div/div[4]/div/div[1]/div[2]/div[2]/div/div")).Click();
                                        Thread.Sleep(3000);
                                        break;
                                    case 3:
                                        driver.FindElement(By.XPath("/html/body/div[4]/div[1]/div/div[2]/div/div/div/div/div/div/div[2]/div[2]/div[3]/div/div/div[2]/div/div[1]/div[1]/div/div/div[5]/div/div[1]/div[2]/div[2]/div/div")).Click();
                                        Thread.Sleep(3000);
                                        break;
                                    case 4:
                                        driver.FindElement(By.XPath("/html/body/div[4]/div[1]/div/div[2]/div/div/div/div/div/div/div[2]/div[2]/div[3]/div/div/div[2]/div/div[1]/div[1]/div/div/div[6]/div/div[1]/div[2]/div[2]/div/div")).Click();
                                        Thread.Sleep(3000);
                                        break;
                                    case 5:
                                        driver.FindElement(By.XPath("/html/body/div[4]/div[1]/div/div[2]/div/div/div/div/div/div/div[2]/div[2]/div[3]/div/div/div[2]/div/div[1]/div[1]/div/div/div[7]/div/div[1]/div[2]/div[2]/div/div")).Click();
                                        Thread.Sleep(3000);
                                        break;
                                    case 6:
                                        driver.FindElement(By.XPath("/html/body/div[4]/div[1]/div/div[2]/div/div/div/div/div/div/div[2]/div[2]/div[3]/div/div/div[2]/div/div[1]/div[1]/div/div/div[8]/div/div[1]/div[2]/div[2]/div/div")).Click();
                                        Thread.Sleep(3000);
                                        break;
                                    case 7:
                                        driver.FindElement(By.XPath("/html/body/div[4]/div[1]/div/div[2]/div/div/div/div/div/div/div[2]/div[2]/div[3]/div/div/div[2]/div/div[1]/div[1]/div/div/div[9]/div/div[1]/div[2]/div[2]/div/div")).Click();
                                        Thread.Sleep(3000);
                                        break;
                                    case 8:
                                        driver.FindElement(By.XPath("/html/body/div[4]/div[1]/div/div[2]/div/div/div/div/div/div/div[2]/div[2]/div[3]/div/div/div[2]/div/div[1]/div[1]/div/div/div[10]/div/div[1]/div[2]/div[2]/div/div")).Click();
                                        Thread.Sleep(3000);
                                        break;
                                    default:
                                        // code block
                                        break;
                                }
                               
                            }

                        }

                        if (ChromeDriverUtils.FindTextInChrome(driver, "Chào mừng bạn đến với Trang mới!", "Chào mừng bạn đến với Trang mới!"))
                        {
                            try
                            {
                                driver.FindElement(By.XPath("//*[@id=\"facebook\"]/body/div[4]/div[1]/div/div[2]/div/div/div/div[1]/div")).Click();
                            }
                            catch 
                            {
                                driver.FindElement(By.XPath("//*[@id=\"facebook\"]/body/div[5]/div[1]/div/div[2]/div/div/div/div[1]/div")).Click();
                                
                            }
                            
                        }
                        driver.Navigate().GoToUrl("https://m.facebook.com/" + uidPost[k1]);
                        Thread.Sleep(3000);
                        //driver.Navigate().Refresh();
                        //Thread.Sleep(1000);

                        if (ChromeDriverUtils.FindClickElementInChrome(driver, "Đăng nhập", "Log In", false) || ChromeDriverUtils.FindClickElementInChrome(driver, "Đăng nhập", "Choose your account", false))
                        {
                            ChromeDriverUtils.updateStatusChrome(dataGridView, acc, "Like Post Lỗi - Acc Logout " + uidPost[k1]);
                            //dataGridView1.Rows[i].Cells["Tinhtrang1"].Value = "Die";
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
                                        driver.FindElement(By.XPath("/html/body/div[1]/div/div[4]/div/div[1]/div/div/div[2]/footer/div/div/div[1]/a")).Click();

                                        ChromeDriverUtils.updateStatusChrome(dataGridView, acc, "Like Post Lỗi - Acc Logout " + uidPost[k1]);
                                        //LoadLog(DateTime.Now + ":  " + dataGridView1.Rows[i].Cells["Ten1"].Value.ToString() + " :Like Post Thành công! " + uidlike[k1], "gr");
                                        //count.Add(uidPost[k1] + "|" + page.UID);
                                        Thread.Sleep(2000);
                                        break;
                                    }
                                    catch
                                    {
                                        try
                                        {
                                            if (driver.Url.Contains("/watch"))
                                            {
                                                ChromeDriverUtils.updateStatusChrome(dataGridView, acc, "Lỗi : dạng wath livetream k like  đc " + uidPost[k1]);
                                                //LoadLog(DateTime.Now + ":  " + dataGridView1.Rows[i].Cells["Ten1"].Value.ToString() + " :Lỗi : dạng wath livetream k like  đc !  " + uidlike[k1], "red");
                                                //upapi(uidlike[k1], 9999);

                                            }
                                            else if (ChromeDriverUtils.FindClickElementInChrome(driver, "Thích", "Like", true))
                                            {
                                                ChromeDriverUtils.updateStatusChrome(dataGridView, acc, "Like Thành công Post " + uidPost[k1]);
                                                //LoadLog(DateTime.Now + ":  " + dataGridView1.Rows[i].Cells["Ten1"].Value.ToString() + " :Like Post Thành công! " + uidlike[k1], "gr");
                                                //count.Add(uidPost[k1] + "|" + page.UID);
                                                //processdone++;
                                                //this.Invoke(new Action(() =>
                                                //{
                                                //    lbprocess.Text = "Process :  " + processdone + "/" + tongluong;
                                                //}));
                                                Thread.Sleep(2000);

                                            }
                                            else if (ChromeDriverUtils.FindTextInChrome(driver, "Chúc bạn sinh nhật vui vẻ", "Chúc bạn sinh nhật vui vẻ"))
                                            {
                                                demloi++;
                                                if (demloi == 2)
                                                {
                                                    ChromeDriverUtils.updateStatusChrome(dataGridView, acc, "Like Post Lỗi - Acc CHECKPOINT " + uidPost[k1]);
                                                    //dataGridView1.Rows[i].Cells["Tinhtrang1"].Value = "Die";
                                                    //dataGridView1.Rows[i].Cells[1].Value = false;
                                                    //dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(248, 198, 198);
                                                    //LoadLog(DateTime.Now + ":  " + dataGridView1.Rows[i].Cells["Ten1"].Value.ToString() + " :Like Post Lỗi - Acc CHECKPOINT! " + uidlike[k1], "red");
                                                    //goto ne;
                                                }
                                                try
                                                {
                                                    driver.FindElement(By.XPath("/html/body/div[1]/div/div[4]/div/div[1]/div/div/div/div/div[3]/div/div[1]/div/span/span")).Click();
                                                }
                                                catch
                                                {
                                                    ChromeDriverUtils.FindClickElementInChrome(driver, "OK", "OK", true);

                                                }
                                                Thread.Sleep(4000);
                                                goto a;
                                            }
                                            else if (driver.Url.Contains("/actor_experience"))
                                            {
                                                ChromeDriverUtils.updateStatusChrome(dataGridView, acc, "Lỗi : dạng nick bị check cmt spam hoặc cp lạ " + uidPost[k1]);
                                                //LoadLog(DateTime.Now + ":  " + dataGridView1.Rows[i].Cells["Ten1"].Value.ToString() + " :Lỗi : dạng wath livetream k like  đc !  " + uidlike[k1], "red");
                                                //upapi(uidlike[k1], 9999);

                                            }
                                            else if (ChromeDriverUtils.FindTextInChrome(driver, "Không tìm thấy nội dung", "Liên kết bạn truy cập") || ChromeDriverUtils.FindTextInChrome(driver, "Không tìm thấy nội dung", "Liên kết bạn truy cập"))
                                            {
                                                ChromeDriverUtils.updateStatusChrome(dataGridView, acc, "Không tìm thấy nội dung " + uidPost[k1]);
                                                //LoadLog(DateTime.Now + ":  " + dataGridView1.Rows[i].Cells["Ten1"].Value.ToString() + " : Không tìm thấy nội dung! " + uidlike[k1], "red");
                                                //upapi(uidlike[k1], 9999);
                                                //delete = true;
                                            }
                                            else if (driver.Url.Contains("/checkpoint") || ChromeDriverUtils.FindClickElementInChrome(driver, "Cần phê duyệt đăng nhập", "Login approval needed", false)
                                            || ChromeDriverUtils.FindClickElementInChrome(driver, "Vui lòng xác nhận danh tính của bạn", "Please confirm your identity", false))
                                            {
                                                ChromeDriverUtils.updateStatusChrome(dataGridView, acc, "Like Post Lỗi - Acc CHECKPOINT " + uidPost[k1]);
                                                //dataGridView1.Rows[i].Cells["Tinhtrang1"].Value = "Die";
                                                //dataGridView1.Rows[i].Cells[1].Value = false;
                                                //dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(248, 198, 198);
                                                //LoadLog(DateTime.Now + ":  " + dataGridView1.Rows[i].Cells["Ten1"].Value.ToString() + " :Like Post Lỗi - Acc CHECKPOINT! " + uidlike[k1], "red");
                                                //goto ne;

                                            }
                                            else if (ChromeDriverUtils.FindClickElementInChrome(driver, "Đăng nhập", "Login", false) || ChromeDriverUtils.FindClickElementInChrome(driver, "Đăng nhập", "Choose your account", false))
                                            {
                                                ChromeDriverUtils.updateStatusChrome(dataGridView, acc, "Like Post Lỗi - Acc Logout " + uidPost[k1]);
                                                //dataGridView1.Rows[i].Cells["Tinhtrang1"].Value = "Die";
                                                //dataGridView1.Rows[i].Cells[1].Value = false;
                                                //dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(248, 198, 198);
                                                //LoadLog(DateTime.Now + ":  " + dataGridView1.Rows[i].Cells["Ten1"].Value.ToString() + " :Like Post Lỗi - Acc Logout! " + uidlike[k1], "red");
                                                //goto ne;
                                            }
                                            else if (ChromeDriverUtils.FindTextInChrome(driver, "Chia sẻ", "Share"))
                                            {
                                                ChromeDriverUtils.updateStatusChrome(dataGridView, acc, "Không có nút LIKE" + uidPost[k1]);
                                                //LoadLog(DateTime.Now + ":  " + dataGridView1.Rows[i].Cells["Ten1"].Value.ToString() + " : Không có nút LIKE! " + uidlike[k1], "red");
                                                //count.Add(uidlike[k1] + "|delete");
                                                //delete = true;
                                            }
                                            else if (ChromeDriverUtils.FindTextInChrome(driver, "của bạn đã bị khóa", "been locked"))
                                            {
                                                ChromeDriverUtils.updateStatusChrome(dataGridView, acc, "Tài khoản của bạn đã bị khóa : " + uidPost[k1]);
                                                //dataGridView1.Rows[i].Cells["Tinhtrang1"].Value = "Die";
                                                //dataGridView1.Rows[i].Cells[1].Value = false;
                                                //dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(248, 198, 198);
                                                //goto ne;
                                            }
                                            else if (ChromeDriverUtils.FindTextInChrome(driver, "Bạn hiện không thể bày tỏ cảm xúc", "Bạn hiện không thể bày tỏ cảm xúc"))
                                            {
                                                ChromeDriverUtils.updateStatusChrome(dataGridView, acc, "Bạn hiện không thể bày tỏ cảm xúc : " + uidPost[k1]);
                                                //dataGridView1.Rows[i].Cells["Tinhtrang1"].Value = "Checkpoint";
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
                                            //Trangthaichrome(i, "Lỗi 1");
                                        }
                                    }
                                    break;

                                }
                                catch
                                {
                                    try
                                    {
                                        driver.FindElement(By.XPath("/html/body/div[1]/div/div[4]/div/div[1]/div/div/div/div/div[3]/div/div[1]/div/span/span/div")).Click();
                                    }
                                    catch
                                    {
                                        ChromeDriverUtils.FindClickElementInChrome(driver, "OK", "OK", true);
                                        Thread.Sleep(4000);
                                    }
                                    if (dem < 1)
                                    {
                                        dem++;

                                        goto lai;
                                    }
                                    //Trangthaichrome(i, "Lỗi ELement Like");
                                    //LoadLog(DateTime.Now + ":  " + dataGridView1.Rows[i].Cells["Ten1"].Value.ToString() + " : Lỗi ELement Like! " + uidlike[k1], "red");
                                }
                            }
                        }
                        int delay = rd.Next(Convert.ToInt32(5), Convert.ToInt32(5));
                        while (delay > 0)
                        {
                            //Trangthaichrome(i, "Delay : " + delay + " giây");
                            Thread.Sleep(1000);
                            delay--;
                        }
                    }
                }
              
            }
            catch 
            {

            }
        }
    }
    
}
