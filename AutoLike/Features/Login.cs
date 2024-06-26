﻿using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using OtpNet;
using System.Threading.Tasks;
using AutoLike.Model;
using AutoLike.Utils;
using System.Threading;

namespace AutoLike.Features
{
    public class Login
    {

        public static void  LoginWithUID(ChromeDriver driver, account acc)
        {
            string UID = acc.UID;
            string pass = acc.PASS;
            string ma2fa = acc.M2FA;
            ma2fa = ma2fa.Replace(" ", "");
        lai:
            if (ChromeDriverUtils.FindTextInChrome(driver, "gần đây!!", "Recent logins!!"))

            {
                try
                {
                    driver.FindElement(By.XPath("/html/body/div[1]/div[2]/div[1]/div/div/div/div[1]/div[4]/div[1]/div/div/a[1]/img")).Click();
                    //Thread.Sleep(3000);
                    int ckk = 1;
                    while (ckk > 0)
                    {
                        if (ChromeDriverUtils.FindTextInChrome(driver, "Vui lòng xác nhận danh tính của bạn", "Please confirm your identity")) // CP 
                        {
                            goto ok;
                        }
                        if (ChromeDriverUtils.FindTextInChrome(driver, "Thêm số di động", "Add a mobile number"))
                        {
                            goto ok;
                        }
                        if (ChromeDriverUtils.FindTextInChrome(driver, "Mật khẩu", "Password")) // CP 
                        {
                            break;
                        }
                        if (ChromeDriverUtils.FindTextInChrome(driver, "phiên bản", "Welcome"))
                        {
                            goto ok;
                        }
                        if (ChromeDriverUtils.FindTextInChrome(driver, "Tìm kiếm trên Facebook", "Search Facebook") || ChromeDriverUtils.FindTextInChrome(driver, "Xong", "Xong"))
                        {
                            goto ok;
                        }
                        ckk--;
                    }
                    try
                    {
                        driver.FindElement(By.XPath("/html/body/div[3]/div[2]/div/div/div/div/form/div[2]/input")).SendKeys(pass);
                    }
                    catch
                    {
                        try
                        {
                            driver.FindElement(By.XPath("/html/body/div[3]/div[2]/div/div/div/div/form/div[2]/div/input")).SendKeys(pass);
                        }
                        catch
                        {

                            for (int k = 1; k > 0; k++)
                            {
                                try
                                {
                                    driver.FindElement(By.XPath("/html/body/div[" + k + "]/div[2]/div[1]/div/div[2]/div[2]/form/div/div[1]/div/div/input")).SendKeys(pass);
                                }
                                catch
                                {
                                    try
                                    {
                                        driver.FindElement(By.XPath("/html/body/div[1]/div[2]/div[1]/div/div[2]/div[2]/form/div/div[2]/button")).Click();
                                        //Thread.Sleep(1500);
                                        goto ok;
                                    }
                                    catch
                                    {
                                        //Trangthaichrome(i, "Lỗi Element Pass " + k);
                                        //driver.Navigate().Refresh();
                                        driver.Navigate().GoToUrl("https://www.facebook.com/");
                                        //Thread.Sleep(3000);
                                        goto lai;
                                    }


                                }
                            }
                        }

                    }
                    //driver.FindElement(By.Id("pass")).SendKeys(pass);
                    //Thread.Sleep(3000);
                    ChromeDriverUtils.FindClickElementInChrome(driver, "Nhớ mật khẩu", "Remember password", true);
                    //Thread.Sleep(3000);
                    try
                    {
                        driver.FindElement(By.XPath("/html/body/div[3]/div[2]/div/div/div/div/form/div[4]/button")).Click();
                    }
                    catch
                    {
                        try
                        {
                            driver.FindElement(By.XPath("/html/body/div[3]/div[2]/div/div/div/div/form/div[4]/button")).Click();
                        }
                        catch { }

                    }

                    //await ChromeDriverUtils.FindClickElementInChrome(driver, "Đăng nhập", "Log in", true);
                    //Thread.Sleep(3000);
                }
                catch
                {
                    driver.Navigate().Refresh();
                    //driver.Navigate().GoToUrl("https://www.facebook.com/");
                    while (true)
                    {
                        if (ChromeDriverUtils.FindTextInChrome(driver, "Đăng nhập", "Log in"))
                        {
                            break;
                        }
                        //Thread.Sleep(1000);
                    }
                    try
                    {
                        driver.FindElement(By.Id("m_login_email")).SendKeys(UID);
                        Thread.Sleep(1000);
                        driver.FindElement(By.Id("m_login_password")).SendKeys(pass);
                        Thread.Sleep(1000);
                        driver.FindElement(By.Name("login")).Click();
                        //Thread.Sleep(6000);
                    }
                    catch
                    {
                        driver.FindElement(By.Id("email")).SendKeys(UID);
                        Thread.Sleep(1000);
                        driver.FindElement(By.Id("pass")).SendKeys(pass);
                        Thread.Sleep(1000);
                        driver.FindElement(By.Name("login")).Click();
                        //Thread.Sleep(6000);
                    }

                }
            }
            else
            {
                try
                {
                    driver.FindElement(By.Id("m_login_email")).SendKeys(UID);
                    Thread.Sleep(1000);
                    driver.FindElement(By.Id("m_login_password")).SendKeys(pass);
                    Thread.Sleep(1000);
                    driver.FindElement(By.Name("login")).Click();
                    //Thread.Sleep(6000);
                }
                catch
                {
                    driver.FindElement(By.Id("email")).SendKeys(UID);
                    Thread.Sleep(1000);
                    driver.FindElement(By.Id("pass")).SendKeys(pass);
                    Thread.Sleep(1000);
                    driver.FindElement(By.Name("login")).Click();
                    //Thread.Sleep(6000);
                }

            }

        ok:
            int d = 0;
            while (d <= 3)
            {
                try
                {

                    var a = driver.FindElement(By.Name("approvals_code"));
                    if (a.Displayed)
                    {
                        string facode = "";
                        if (ma2fa != "")
                        {
                            var otpkey = Base32Encoding.ToBytes(ma2fa.Replace(" ", ""));
                            var totp = new Totp(otpkey);
                            facode = totp.ComputeTotp();
                        }
                        else
                        {
                            //updatehanhdong(i, "Không có 2FA");
                            goto end;

                        }
                        driver.FindElement(By.Name("approvals_code")).SendKeys(facode);
                        //Thread.Sleep(3000);

                        try
                        {
                            driver.FindElement(By.Id("checkpointSubmitButton")).Click();
                            //Thread.Sleep(4000);
                        }
                        catch
                        {
                            driver.FindElement(By.Name("submit[Submit Code]")).Click();
                            //Thread.Sleep(4000);
                        }
                        try
                        {
                            driver.FindElement(By.Id("checkpointSubmitButton")).Click();

                        }
                        catch { }
                        //Thread.Sleep(5000);
                        try
                        {
                            if (driver.FindElement(By.Name("approvals_code")).Displayed)
                            {
                                //updatehanhdong(i, "Sai 2FA CODE");
                                goto end;
                            }
                        }
                        catch { }
                        Thread.Sleep(1000);
                        break;
                    }
                }
                catch
                {
                    if (ChromeDriverUtils.FindTextInChrome(driver, "Vui lòng xác", "Choose"))
                    {
                        goto end;
                    }
                    if (ChromeDriverUtils.FindTextInChrome(driver, "Xem lại", "ssssssss"))
                    {
                        ChromeDriverUtils.FindClickElementInChrome(driver, "Tiếp tục", "Continue", true);
                        ChromeDriverUtils.FindClickElementInChrome(driver, "Tiếp", "Next", true);
                        //Thread.Sleep(2000);
                        while (true)
                        {
                            if (ChromeDriverUtils.FindTextInChrome(driver, "Đây là tôi", "ssssssss"))
                            {
                                ChromeDriverUtils.FindClickElementInChrome(driver, "Đây là tôi", "Continue", true);
                                break;
                            }
                            else if (ChromeDriverUtils.FindTextInChrome(driver, "Đây có phải bạn không?", "Đây có phải bạn không?") | ChromeDriverUtils.FindTextInChrome(driver, "Đây có phải bạn không?", "Đây có phải bạn không?"))
                            {
                                ChromeDriverUtils.FindClickElementInChrome(driver, "Có", "Yes", true);
                                break;
                            }
                            Thread.Sleep(1000);
                        }
                    }
                    try
                    {
                        if (driver.FindElement(By.Name("login")).Displayed)
                        {
                            goto end;
                        }
                    }
                    catch
                    {
                        if (d == 5)
                        { break; }
                        d++;
                        Thread.Sleep(1000);
                    }

                }
                if (driver.Url.Contains("checkpoint/"))
                {
                    goto end;
                }
                if (ChromeDriverUtils.FindTextInChrome(driver, "tài khoản của bạn đã bị khóa", "been locked")) //nayftrc ma
                {
                    goto end;
                }
                if (ChromeDriverUtils.FindTextInChrome(driver, "Tài khoản của bạn tạm thời bị khóa", "Your account has been temporarily locked")) // Tạm khóa
                {
                    goto end;
                }
                if (ChromeDriverUtils.FindTextInChrome(driver, "Vui lòng xác nhận danh tính của bạn", "Please confirm your identity")) // CP 
                {
                    goto end;
                }

                if (ChromeDriverUtils.FindTextInChrome(driver, "Bảo vệ tài khoản của bạn", "Keep your account secure"))
                {
                    goto end;
                }
                if (ChromeDriverUtils.FindTextInChrome(driver, "vô hiệu hóa", "Choose"))
                {
                    goto end;
                }
                if (ChromeDriverUtils.FindTextInChrome(driver, "Chúng tôi đã đình chỉ tài khoản của bạn", "We suspend"))
                {
                    goto end;
                }
                if (ChromeDriverUtils.FindTextInChrome(driver, "Thêm số di động", "Add a mobile number"))
                {
                    goto end;
                }


                if (ChromeDriverUtils.FindTextInChrome(driver, "phiên bản", "welcome"))
                {
                    ChromeDriverUtils.FindClickElementInChrome(driver, "Tiếp", "Next", true);
                    //Thread.Sleep(2000);
                    ChromeDriverUtils.FindClickElementInChrome(driver, "Bắt đầu", "Get Started", true);
                    goto end;
                }
                if (ChromeDriverUtils.FindTextInChrome(driver, "Tìm kiếm trên Facebook", "Search Facebook") || ChromeDriverUtils.FindTextInChrome(driver, "Xong", "Xong"))
                {
                    goto end;
                }
                if (ChromeDriverUtils.FindTextInChrome(driver, "có người", "Choose"))
                {
                    goto end;
                }
                if (ChromeDriverUtils.FindTextInChrome(driver, "xác nhận đó là bạn", "Help us confirm that it's you"))
                {
                    goto end;
                }
                if (ChromeDriverUtils.FindTextInChrome(driver, "Chúng tôi đã đình chỉ tài khoản của bạn", "We suspend"))
                {
                    //Trangthaichrome(i, "ĐÃ ĐÌNH CHỈ");
                    //updatehanhdong(i, "ĐÃ ĐÌNH CHỈ");
                    goto end;
                }
                //Thread.Sleep(5000);

                if (!driver.Url.Contains("/checkpoint"))
                {
                    goto end;
                }

            }
            if (ChromeDriverUtils.FindTextInChrome(driver, "thời bị khóa", "locked"))//Your account is temporarily locked

            {
                ChromeDriverUtils.FindClickElementInChrome(driver, "Có", "Yes", true);
                goto end;
            }

            try
            {
                driver.FindElement(By.Name("submit[Continue]")).Click();
            }
            catch
            {
                try
                {
                    driver.FindElement(By.Name("checkpointSubmitButton")).Click();
                }
                catch
                {
                    try
                    {
                        driver.FindElement(By.Name("checkpointSubmitButton")).Click();
                    }
                    catch
                    {

                    }
                }

            }

            try
            {
                if (driver.FindElement(By.Id("checkpointSubmitButton")).Displayed)
                {
                    goto end;
                }
            }
            catch
            {

            }
            try
            {
                acc.COOKIE = ChromeDriverUtils.getcookie(driver);

            }
            catch { }
        //if (cbgetinfo.Checked)
        //{
        //    //getinfochrome(driver, dataGridView1.Rows[i].Cells["cookie1"].Value.ToString(), i);
        //}

        end:
            Thread.Sleep(100);

        }
    }
}
