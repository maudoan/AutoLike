using AutoLike.Model;
using AutoLike.Utils;
using Newtonsoft.Json.Linq;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.DevTools.V115.Debugger;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Net;
using System.Net.Http;
using System.Reflection.Emit;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using Cookie = OpenQA.Selenium.Cookie;
using Label = System.Windows.Forms.Label;

namespace AutoLike.Features
{
    public class Post
    {
        public static string getPostUid(CheckBox type2CheckBox, TextBox keyText, NumericUpDown timeGetValue, Label statusGetUID)
        {
            string uid = "";
            string key = keyText.Text.Trim();

            string type = string.Empty;
            if (type2CheckBox.Checked) 
            { 
                type = "2"; 
            }
            else 
            { 
                type = "2"; 
            }
            while (true)
            {

                try
                {                  
                    statusGetUID.Invoke(new Action(() => statusGetUID.Text = "Đang GET UID Like..."));
                    WebRequest requestmave = WebRequest.Create(Constants.Constants.GetPostUidShopLike(key, type));
                    using (WebResponse response3 = requestmave.GetResponse())
                    using (StreamReader stream3 = new StreamReader(response3.GetResponseStream()))
                    {
                        uid = stream3.ReadToEnd();
                    }
                    if (uid.Contains("error"))
                    {
                        statusGetUID.Invoke(new Action(() => statusGetUID.Text = "HẾT UID Like..."));                 
                        int timeGet = Convert.ToInt32(timeGetValue.Value);
                        while (timeGet > 0)
                        {
                            statusGetUID.Invoke(new Action(() => statusGetUID.Text = "HẾT UID Like...Delay " + timeGet + " giây"));                         
                            timeGet--;
                            Thread.Sleep(1000);
                        }
                    }
                    else
                    {
                        statusGetUID.Invoke(new Action(() => statusGetUID.Text = "ĐÃ CÓ UID Like..."));
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

        public void LikePost(ChromeDriver driver, DataGridView dataGridView, account acc, string[] uidPost,List<page> listPage, CheckBox type2CheckBox, TextBox keyText, NumericUpDown timeGetValue, Label statusGetUID)
        {
            try
            {
                ChromeDriverUtils.updateColorStatus(dataGridView, acc);
                List<string> count = new List<string>();

                Random rd = new Random();
                int demloi = 0;

                for(int i = 0; i < listPage.Count; i++)
                {
                    for (int k1 = 0; k1 < uidPost.Length; k1++)
                    {
                        if (SQLiteUtils.checkPostLikedByPage(listPage[i].PAGEID, uidPost[k1])) 
                        {
                            Console.WriteLine("-----Post này đã Like ---->");
                            break;
                        }
                    a:
                        int dem = 0;
                        ChromeDriverUtils.updateStatusChrome(dataGridView, acc, "Vào Post: " + uidPost[k1]);
                    lai:
                        driver.Navigate().GoToUrl("https://www.facebook.com/");

                        if (driver.Url.Contains("checkpoint/"))
                        {
                            acc.CHECKED = "Checkpoint";
                            ChromeDriverUtils.updateStatusChrome(dataGridView, acc, "Like Post Lỗi - Checkpoint " + uidPost[k1]);
                            ChromeDriverUtils.updateStatusAcc(dataGridView, acc, "Checkpoint");
                            outChrome(driver);
                            goto ne;
                        }

                        try
                        {
                            driver.Manage().Cookies.DeleteCookieNamed("i_user");
                            Cookie cookie = new Cookie("i_user", listPage[i].PAGEID);
                            driver.Manage().Cookies.AddCookie(cookie);
                        }
                        catch
                        {

                        }
  

                        driver.Navigate().GoToUrl("https://www.facebook.com/" + uidPost[k1]);

                        if (ChromeDriverUtils.FindClickElementInChrome(driver, "Đăng nhập", "Log In", false) || ChromeDriverUtils.FindClickElementInChrome(driver, "Đăng nhập", "Choose your account", false))
                        {
                            ChromeDriverUtils.updateStatusChrome(dataGridView, acc, "Like Post Lỗi - Acc Logout " + uidPost[k1]);
                            ChromeDriverUtils.updateStatusAcc(dataGridView, acc, "Die");
                            acc.CHECKED = "Die";
                            outChrome(driver);
                            goto ne;
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
                                        count.Add(uidPost[k1] + "|" + listPage[i].PAGEID);
                                        break;
                                    }
                                    catch
                                    {
                                        try
                                        {
                                            if (driver.Url.Contains("/watch"))
                                            {
                                                ChromeDriverUtils.updateStatusChrome(dataGridView, acc, "Lỗi : dạng wath livetream k like  đc " + uidPost[k1]);
                                                upShopLike(uidPost[k1], 9999, keyText, statusGetUID);
                                                outChrome(driver);
                                                goto ne;
                                            }
                                            else if(driver.Url.Contains("/reel"))
                                            {
                                                ChromeDriverUtils.updateStatusChrome(dataGridView, acc, "Lỗi : dạng wath reel k like  đc " + uidPost[k1]);
                                                upShopLike(uidPost[k1], 9999, keyText, statusGetUID);
                                                outChrome(driver);
                                                goto ne;
                                            }
                                            else if (ChromeDriverUtils.FindClickElementInChrome(driver, "Thích", "Like", true))
                                            {
                                                ChromeDriverUtils.updateStatusChrome(dataGridView, acc, "Like Thành công Post " + uidPost[k1]);
                                                post post = new post();
                                                post.POSTID = uidPost[k1];
                                                post.PAGEID = listPage[i].PAGEID;
                                                SQLiteUtils.insertPost(post);
                                                count.Add(uidPost[k1] + "|" + listPage[i].PAGEID);

                                            }
                                            else if (ChromeDriverUtils.FindTextInChrome(driver, "Chúc bạn sinh nhật vui vẻ", "Chúc bạn sinh nhật vui vẻ"))
                                            {
                                                demloi++;
                                                if (demloi == 2)
                                                {
                                                    ChromeDriverUtils.updateStatusChrome(dataGridView, acc, "Like Post Lỗi - Acc CHECKPOINT " + uidPost[k1]);
                                                    ChromeDriverUtils.updateStatusAcc(dataGridView, acc, "Die");
                                                    acc.CHECKED = "Die";
                                                    outChrome(driver);
                                                    goto ne;
                                                }
                                                try
                                                {
                                                    driver.FindElement(By.XPath("/html/body/div[1]/div/div[4]/div/div[1]/div/div/div/div/div[3]/div/div[1]/div/span/span")).Click();
                                                }
                                                catch
                                                {
                                                    ChromeDriverUtils.FindClickElementInChrome(driver, "OK", "OK", true);

                                                }
                                                goto a;
                                            }
                                            else if (driver.Url.Contains("/actor_experience"))
                                            {
                                                ChromeDriverUtils.updateStatusChrome(dataGridView, acc, "Lỗi : dạng nick bị check cmt spam hoặc cp lạ " + uidPost[k1]);
                                                upShopLike(uidPost[k1], 9999, keyText, statusGetUID);

                                            }
                                            else if (ChromeDriverUtils.FindTextInChrome(driver, "Không tìm thấy nội dung", "Liên kết bạn truy cập") || ChromeDriverUtils.FindTextInChrome(driver, "Không tìm thấy nội dung", "Liên kết bạn truy cập"))
                                            {
                                                ChromeDriverUtils.updateStatusChrome(dataGridView, acc, "Không tìm thấy nội dung " + uidPost[k1]);
                                                upShopLike(uidPost[k1], 9999, keyText, statusGetUID);
                                            }
                                            else if (driver.Url.Contains("/checkpoint") || ChromeDriverUtils.FindClickElementInChrome(driver, "Cần phê duyệt đăng nhập", "Login approval needed", false)
                                            || ChromeDriverUtils.FindClickElementInChrome(driver, "Vui lòng xác nhận danh tính của bạn", "Please confirm your identity", false))
                                            {
                                                ChromeDriverUtils.updateStatusChrome(dataGridView, acc, "Like Post Lỗi - Acc CHECKPOINT " + uidPost[k1]);
                                                ChromeDriverUtils.updateStatusAcc(dataGridView, acc, "Die");
                                                acc.CHECKED = "Die";
                                                outChrome(driver);
                                                goto ne;

                                            }
                                            else if (ChromeDriverUtils.FindClickElementInChrome(driver, "Đăng nhập", "Login", false) || ChromeDriverUtils.FindClickElementInChrome(driver, "Đăng nhập", "Choose your account", false))
                                            {
                                                ChromeDriverUtils.updateStatusChrome(dataGridView, acc, "Like Post Lỗi - Acc Logout " + uidPost[k1]);
                                                ChromeDriverUtils.updateStatusAcc(dataGridView, acc, "Die");
                                                acc.CHECKED = "Die";
                                                outChrome(driver);
                                                goto ne;
                                            }
                                            else if (ChromeDriverUtils.FindTextInChrome(driver, "Chia sẻ", "Share"))
                                            {
                                                ChromeDriverUtils.updateStatusChrome(dataGridView, acc, "Không có nút LIKE" + uidPost[k1]);
                                                count.Add(uidPost[k1] + "|delete");
                                            }
                                            else if (ChromeDriverUtils.FindTextInChrome(driver, "của bạn đã bị khóa", "been locked"))
                                            {
                                                ChromeDriverUtils.updateStatusChrome(dataGridView, acc, "Tài khoản của bạn đã bị khóa : " + uidPost[k1]);
                                                ChromeDriverUtils.updateStatusAcc(dataGridView, acc, "Die");
                                                acc.CHECKED = "Die";
                                                outChrome(driver);
                                                goto ne;
                                            }
                                            else if (ChromeDriverUtils.FindTextInChrome(driver, "Bạn hiện không thể bày tỏ cảm xúc", "Bạn hiện không thể bày tỏ cảm xúc"))
                                            {
                                                ChromeDriverUtils.updateStatusChrome(dataGridView, acc, "Bạn hiện không thể bày tỏ cảm xúc : " + uidPost[k1]);
                                                ChromeDriverUtils.updateStatusAcc(dataGridView, acc, "Checkpoint");
                                                acc.CHECKED = "Checkpoint";
                                                outChrome(driver);
                                                goto ne;
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
                                        driver.FindElement(By.XPath("/html/body/div[1]/div/div[4]/div/div[1]/div/div/div/div/div[3]/div/div[1]/div/span/span/div")).Click();
                                    }
                                    catch
                                    {
                                        ChromeDriverUtils.FindClickElementInChrome(driver, "OK", "OK", true);
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
                            Task.Delay(1000);
                            delay--;
                        }

                    }       
                }
            ne:
                for (int k2 = 0; k2 < uidPost.Length; k2++)
                {
                    int dem = 0;
                    foreach (string s in count)
                    {
                        if (s.Split('|')[0] == uidPost[k2])
                        {
                            dem++;
                        }
                        else if (s == uidPost[k2] + "|delete")
                        {
                            try
                            {
                                upShopLike(uidPost[k2], 9999, keyText, statusGetUID);
                            }
                            catch
                            {
                            }

                            goto en;
                        }
                    }
                    foreach (string s in count)
                    {
                        if (s.Split('|')[0] == uidPost[k2])
                        {
                            File.AppendAllText(@"LOG\loglike.txt", s.Split('|')[1] + "|" + uidPost[k2] + "|" + dem + "\r\n");
                        }
                    }
                    try
                    {
                        upShopLike(uidPost[k2], dem, keyText, statusGetUID);
                    }
                    catch
                    {
                    }
                en:
                 Task.Delay(100);
                }

            }
            catch 
            {

            }


        }

        public async void upShopLike(string uid, int count, TextBox keyTxt, Label statusGetUID)
        {
            if (count > 0)
            {
                string key = keyTxt.Text;

                statusGetUID.Invoke(new Action( () => statusGetUID.Text = "Update API"));

                string Url = "http://shoplike.vn/Cron1123z/like_api.php?key=" + key + "&method=" + uid + "&count=" + count + "," + "key=" + key + "&method=update_count_success&id_stt=" + uid + "&count=" + count;
                while (true)
                {
                    using (var client = new HttpClient())
                    {
                        try
                        {
                            var content = new StringContent("", Encoding.UTF8, "application/json");
                            HttpResponseMessage result = await client.PostAsync(Url, content);

                            if (result.IsSuccessStatusCode)
                            {
                                Console.WriteLine("Up API Success");
                                statusGetUID.Invoke(new Action(() => statusGetUID.Text = "Update API SUCCESS"));
                                break;
                            }
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex);
                        }
                    }
                }

            }

        }


        public void outChrome(ChromeDriver driver)
        {
            try
            {
                Console.WriteLine("=========== NeNeNe=======>");
                driver.Close();
                driver.Quit();
            }
            catch (Exception)
            { }
        }

    }
    
}
