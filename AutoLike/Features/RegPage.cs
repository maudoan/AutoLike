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

namespace AutoLike.Features
{
    public class RegPage
    {
        public void RegPageWithUID(ChromeDriver driver, string pathNamePage, DataGridView dataGridView, account item, List<ChromeDriver> listChromeDrivers) 
        {
            try
            {
                int countpage = 1;
                for (int k = 0; k < 3; k++)
                {
                    Random random = new Random();
    
                    ChromeDriverUtils.updateStatusChrome(dataGridView, item, "Bắt đầu Reg Page thứ : " + countpage);
                    driver.Navigate().GoToUrl("https://www.facebook.com/pages/creation/?ref_type=launch_point");
                    while (true)
                    {
                        try
                        {
                            if (ChromeDriverUtils.FindTextInChrome(driver, "Tạo Trang", "Tạo Trang"))
                            {
                                string chuoiNgauNhien = string.Join("", Enumerable.Range(0, 4).Select(_ => random.Next(10)));
                                string namePage = getNamePage(pathNamePage) + chuoiNgauNhien;

                                ChromeDriverUtils.updateStatusChrome(dataGridView, item, "Nhập tên Page: " + namePage);

                                driver.FindElement(By.XPath("/html/body/div[1]/div/div[1]/div/div[3]/div/div/div/div[1]/div[1]/div[1]/div/div[2]/div[1]/div[2]/div/div/div/div[1]/div/label/div/div/input")).SendKeys(namePage);
                                Thread.Sleep(1000);
                                driver.FindElement(By.XPath("/html/body/div[1]/div/div[1]/div/div[3]/div/div/div/div[1]/div[1]/div[1]/div/div[2]/div[1]/div[2]/div/div/div/div[3]/div/div/div/div/label/div/div/div/input")).SendKeys("giải trí");
                                Thread.Sleep(1000);
                                driver.FindElement(By.XPath("/html/body/div[1]/div/div[1]/div/div[3]/div/div/div/div[2]/div/div/div[1]/div[1]/div/div[1]/div/ul/li[1]/div/div[1]/div/div/div/div/span")).Click();
                                Thread.Sleep(1000);
                                driver.FindElement(By.XPath("/html/body/div[1]/div/div[1]/div/div[3]/div/div/div/div[1]/div[1]/div[1]/div/div[3]/div[1]/div/div/div/div[1]/div/span/span")).Click();
                                Thread.Sleep(20000);
                                break;
                            }
                        }
                        catch
                        {
                            if (ChromeDriverUtils.FindTextInChrome(driver, "Tạo Trang", "Tạo Trang"))
                            {
                                int index = random.Next(4);
                                string chuoiNgauNhien = string.Join("", Enumerable.Range(0, 4).Select(_ => random.Next(10)));
                                string namePage = getNamePage(pathNamePage) + chuoiNgauNhien;

                                ChromeDriverUtils.updateStatusChrome(dataGridView,item, "Nhập tên Page: " + namePage);

                                driver.FindElement(By.XPath("/html/body/div[1]/div/div[1]/div/div[5]/div/div/div[3]/div/div/div[1]/div[1]/div[1]/div/div[2]/div[1]/div[2]/div/div/div/div[1]/div/label/div/div/input")).SendKeys(namePage);
                                Thread.Sleep(1000);
                                driver.FindElement(By.XPath("/html/body/div[1]/div/div[1]/div/div[5]/div/div/div[3]/div/div/div[1]/div[1]/div[1]/div/div[2]/div[1]/div[2]/div/div/div/div[3]/div/div/div/div/label/div/div/div/input")).SendKeys("giải trí");
                                Thread.Sleep(1000);
                                driver.FindElement(By.XPath("/html/body/div[1]/div/div[1]/div/div[5]/div/div/div[3]/div/div/div[2]/div/div/div[1]/div[1]/div/div[1]/div/ul/li[1]/div/div[1]/div/div/div/div/span")).Click();
                                Thread.Sleep(1000);
                                driver.FindElement(By.XPath("/html/body/div[1]/div/div[1]/div/div[5]/div/div/div[3]/div/div/div[1]/div[1]/div[1]/div/div[3]/div[1]/div/div/div/div[1]/div/span/span")).Click();
                                Thread.Sleep(20000);
                                break;
                            }
                        }
                        if (ChromeDriverUtils.FindTextInChrome(driver, "Bạn hiện không xem được nội dung này", "Bạn hiện không xem được nội dung này"))
                        {
                            ChromeDriverUtils.updateStatusChrome(dataGridView, item, "Chặn Reg");

                            //ChromeDriverUtils.updateStatusAcc(dataGridView, item, "Checkpoint");
                           
                            goto end2;
                        }
                        else if (ChromeDriverUtils.FindTextInChrome(driver, "Creat New Account", "Đăng nhập"))
                        {
                            ChromeDriverUtils.updateStatusChrome(dataGridView, item, "LOGOUT");
                          
                            goto end2;
                        }
                        else
                        {
                            driver.Navigate().GoToUrl("https://m.facebook.com/pages/creation_flow/?step=name&ref_type=bookmark");
                        }

                        Thread.Sleep(1000);
                    }
                    int num = 0;

                    while (true)
                    {
                        try
                        {
                            if (ChromeDriverUtils.FindTextInChrome(driver, "Hoàn tất quá trình thiết lập Trang", "Hoàn tất quá trình thiết lập Trang"))
                            {
                             
                                ChromeDriverUtils.updateStatusChrome(dataGridView, item, "Tạo Page Thành công");

                                Thread.Sleep(1000);
                                driver.FindElement(By.XPath("/html/body/div[1]/div/div[1]/div/div[5]/div/div/div[3]/div/div/div[1]/div[1]/div[1]/div/div[3]/div[2]/div[2]/div/div/div[1]/div/span/span")).Click();
                                Thread.Sleep(1000);
                                driver.FindElement(By.XPath("/html/body/div[1]/div/div[1]/div/div[5]/div/div/div[3]/div/div/div[1]/div[1]/div[1]/div/div[3]/div[2]/div[2]/div/div/div[1]/div/span/span")).Click();
                                Thread.Sleep(1000);
                                driver.FindElement(By.XPath("/html/body/div[1]/div/div[1]/div/div[5]/div/div/div[3]/div/div/div[1]/div[1]/div[1]/div/div[3]/div[2]/div[2]/div/div/div[1]/div/span/span")).Click();
                                Thread.Sleep(1000);
                                driver.FindElement(By.XPath("/html/body/div[1]/div/div[1]/div/div[5]/div/div/div[3]/div/div/div[1]/div[1]/div[1]/div/div[3]/div[2]/div[2]/div/div/div[1]/div/span/span")).Click();
                                Thread.Sleep(2000);
                                break;
                            }
                        }
                        catch
                        {
                            ChromeDriverUtils.updateStatusChrome(dataGridView, item, "Tạo Page Thành công");

                            Thread.Sleep(1000);
                            driver.FindElement(By.XPath("/html/body/div[1]/div/div[1]/div/div[3]/div/div/div/div[1]/div[1]/div[1]/div/div[3]/div[2]/div[2]/div/div/div[1]/div/span/span")).Click();
                            Thread.Sleep(1000);
                            driver.FindElement(By.XPath("/html/body/div[1]/div/div[1]/div/div[3]/div/div/div/div[1]/div[1]/div[1]/div/div[3]/div[2]/div[2]/div/div/div[1]/div/span/span")).Click();
                            Thread.Sleep(1000);
                            driver.FindElement(By.XPath("/html/body/div[1]/div/div[1]/div/div[3]/div/div/div/div[1]/div[1]/div[1]/div/div[3]/div[2]/div[2]/div/div/div[1]/div/span/span")).Click();
                            Thread.Sleep(1000);
                            driver.FindElement(By.XPath("/html/body/div[1]/div/div[1]/div/div[3]/div/div/div/div[1]/div[1]/div[1]/div/div[3]/div[2]/div[2]/div/div/div[1]/div/span/span")).Click();
                            Thread.Sleep(2000);
                            driver.FindElement(By.XPath("/html/body/div[1]/div/div[1]/div/div[3]/div/div/div/div[1]/div[1]/div[1]/div/div[3]/div[2]/div[2]/div/div/div[1]/div/span/span")).Click();
                            break;
                        }
                        try
                        {
                            if (ChromeDriverUtils.FindTextInChrome(driver, "Hoàn tất quá trình thiết lập Trang", "Hoàn tất quá trình thiết lập Trang"))
                            {
                                ChromeDriverUtils.updateStatusChrome(dataGridView, item, "Tạo Page Thành công");

                                break;
                            }
                        }
                        catch { }
                        if (num >= 15)
                        {
                    
                            ChromeDriverUtils.updateStatusChrome(dataGridView, item, "Bị chặn Reg Page");
                            goto end2;
                        }
                        if (ChromeDriverUtils.FindTextInChrome(driver, "tài khoản của bạn đã bị khóa", "has been lock"))
                        {
            
                            ChromeDriverUtils.updateStatusChrome(dataGridView, item, "Checkpoint");
                            ChromeDriverUtils.updateStatusAcc(dataGridView, item, "Checkpoint");
                            goto end2;
                        }
                        else if (ChromeDriverUtils.FindTextInChrome(driver, "Creat New Account", "Đăng nhập"))
                        {
                        
                            ChromeDriverUtils.updateStatusChrome(dataGridView, item, "LOGOUT");
                            
                            goto end2;
                        }
                        num++;
                        Thread.Sleep(1000);
                    }
                    //string uidpage = driver.Url.Replace("https://www.facebook.com/profile.php?id=", "").Replace("/", "");
                    //uidpage = uidpage.Split('-')[uidpage.Split('-').Length - 1];
                    driver.Navigate().GoToUrl("https://www.facebook.com/settings/?tab=profile_access");
                    //while (true)
                    //{
                    //    try
                    //    {
                    //        if (ChromeDriverUtils.FindTextInChrome(driver, "Chào mừng bạn đến với Trang mới!", "Chào mừng bạn đến với Trang mới!"))
                    //        {
                    //            driver.FindElement(By.XPath("/html/body/div[4]/div[1]/div/div[2]/div/div/div/div[1]/div/div")).Click();
                    //            Thread.Sleep(1000);
                    //            driver.Navigate().GoToUrl("https://www.facebook.com/settings/?tab=profile_access");
                    //            break;
                    //        }
                    //    }
                    //    catch
                    //    {
                    //        if (ChromeDriverUtils.FindTextInChrome(driver, "Chào mừng bạn đến với Trang mới!", "Chào mừng bạn đến với Trang mới!"))
                    //        {
                    //            driver.FindElement(By.XPath("/html/body/div[2]/div[1]/div/div[2]/div/div/div/div[1]/div/i")).Click();
                    //            Thread.Sleep(1000);
                    //            driver.Navigate().GoToUrl("https://www.facebook.com/settings/?tab=profile_access");
                    //            break;
                    //        }
                    //    }
                    //}
                    while (true)

                    {
                        try
                        {
                            driver.FindElement(By.XPath("/html/body/div[1]/div[1]/div[1]/div/div[3]/div/div/div/div[1]/div[1]/div[2]/div/div/div/div/div/div/div/div/div[2]/div/div/div[1]/div[2]/div/div/div[1]/div/span/span")).Click();
                            Thread.Sleep(1000);
                            driver.FindElement(By.XPath("/html/body/div[1]/div[1]/div[1]/div/div[4]/div/div/div[1]/div/div[2]/div/div/div/div/div[1]/div[4]/div/div/div/div[1]/div/span/span")).Click();
                            Thread.Sleep(1000);


                        }
                        catch
                        {

                            driver.FindElement(By.XPath("/html/body/div[1]/div/div[1]/div/div[5]/div/div/div[3]/div/div/div[1]/div[1]/div[2]/div/div/div/div/div/div/div/div/div[2]/div/div/div[1]/div[2]/div/div/div[1]/div/span/span")).Click();
                            Thread.Sleep(1000);
                            driver.FindElement(By.XPath("/html/body/div[1]/div/div[1]/div/div[6]/div/div/div[1]/div/div[2]/div/div/div/div/div[1]/div[4]/div/div/div/div[1]/div/span/span")).Click();
                            Thread.Sleep(1000);

                        }
                        if (ChromeDriverUtils.FindTextInChrome(driver, "Chúng tôi đã tạm thời khóa", "Chúng tôi đã tạm thời khóa"))
                        {
                            ChromeDriverUtils.updateStatusChrome(dataGridView, item, "Bị khóa chức năng");
                          
                            goto end2;
                        }
            
                        try
                        {
                            if (ChromeDriverUtils.FindTextInChrome(driver, "Thêm mới", "Thêm mới"))
                            {
                          
                                ChromeDriverUtils.updateStatusChrome(dataGridView, item, "Nhập link Admin");
                                while (true)
                                {
                                    try
                                    {
                                        driver.FindElement(By.XPath("/html/body/div[1]/div[1]/div[1]/div/div[4]/div/div/div[1]/div/div[2]/div/div/div/div/div[2]/div/div[4]/div[2]/div[1]/div/div/label/input")).SendKeys("");
                                        Thread.Sleep(2200);
                                        driver.FindElement(By.XPath("/html/body/div[1]/div[1]/div[1]/div/div[4]/div/div/div[1]/div/div[2]/div/div/div/div/div[2]/div/div[4]/div[2]/div[2]/div/div[1]/div/ul/li/div/div[1]/div/div[2]/div/div/span/span")).Click();
                                        break;

                                    }
                                    catch
                                    {

                                        driver.FindElement(By.XPath("/html/body/div[1]/div/div[1]/div/div[6]/div/div/div[1]/div/div[2]/div/div/div/div/div[2]/div/div[4]/div[2]/div[1]/div/div/label/input")).SendKeys("");
                                        Thread.Sleep(2200);
                                        driver.FindElement(By.XPath("/html/body/div[1]/div/div[1]/div/div[6]/div/div/div[1]/div/div[2]/div/div/div/div/div[2]/div/div[4]/div[2]/div[2]/div/div[1]/div/ul/li/div/div[1]/div/div[2]/div/div/span/span")).Click();
                                        break;

                                    }
                
                                }
                                while (true)
                                {
                                    try
                                    {
                                        driver.FindElement(By.XPath("/html/body/div[1]/div/div[1]/div/div[6]/div/div/div[1]/div/div[2]/div/div/div/div/div[3]/div/div[4]/div[1]/div/div[1]/div[3]/div/div/div[1]/div[2]/div[2]")).Click();
                                        if (driver.FindElement(By.XPath("/html/body/div[1]/div/div[1]/div/div[6]/div/div/div[1]/div/div[2]/div/div/div/div/div[3]/div/div[4]/div[2]/div/div/div/div[1]/div/span/span")).Displayed)
                                        {
                                            driver.FindElement(By.XPath("/html/body/div[1]/div/div[1]/div/div[6]/div/div/div[1]/div/div[2]/div/div/div/div/div[3]/div/div[4]/div[2]/div/div/div/div[1]/div/span/span")).Click();
                                            break;
                                        }
                                    }
                                    catch { }
                                    if (ChromeDriverUtils.FindTextInChrome(driver, "tài khoản của bạn đã bị khóa", "has been lock"))
                                    {

                                        ChromeDriverUtils.updateStatusChrome(dataGridView, item, "Checkpoint");
                                        ChromeDriverUtils.updateStatusAcc(dataGridView, item, "Checkpoint");
                                        goto end2;
                                    }
                                    Thread.Sleep(100);
                                }
                                while (true)
                                {
                                    if (ChromeDriverUtils.FindTextInChrome(driver, "Cấp quyền truy cập", "Cấp quyền truy cập"))
                                    {
                                        driver.FindElement(By.XPath("/html/body/div[1]/div/div[1]/div/div[6]/div/div/div[1]/div/div[2]/div/div/div/div/div[4]/div/div[4]/div/div/div[2]/div/label/div/div/input")).SendKeys("");
                                        driver.FindElement(By.XPath("/html/body/div[1]/div/div[1]/div/div[6]/div/div/div[1]/div/div[2]/div/div/div/div/div[4]/div/div[4]/div/div/div[3]/div/div/div/div[1]/div/span/span")).Click();
                                        Thread.Sleep(1000);
                                        break;
                                    }
                                }
                                if (ChromeDriverUtils.FindTextInChrome(driver, "tài khoản của bạn đã bị khóa", "has been lock"))
                                {
                                   
                                    ChromeDriverUtils.updateStatusChrome(dataGridView, item, "Checkpoint");
                                    ChromeDriverUtils.updateStatusAcc(dataGridView, item, "Checkpoint");
                                    goto end2;
                                }
                                Thread.Sleep(100);
                            }
                            break;
                        }
                        catch { }
                        if (ChromeDriverUtils.FindTextInChrome(driver, "tài khoản của bạn đã bị khóa", "has been lock"))
                        {
                            ChromeDriverUtils.updateStatusChrome(dataGridView, item, "Checkpoint");

                            ChromeDriverUtils.updateStatusAcc(dataGridView, item, "Checkpoint");
                            goto end2;
                        }
                        Thread.Sleep(100);
                    }
                    countpage++;
                }
                ChromeDriverUtils.updateStatusChrome(dataGridView, item, "Tạo Page thành công");
            }
            catch { }
        end2:
            Thread.Sleep(10);
            try
            {
                ChromeDriverUtils.ChromeDetroy(driver, listChromeDrivers);
            }
            catch { }
        }

        public string getNamePage(string fullPathNamePage)
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
    }
}
