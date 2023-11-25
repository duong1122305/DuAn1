﻿using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Windows;
using OpenQA.Selenium.Interactions;

namespace TestProject4
{
    [TestFixture]
    public class TC_Quan_Ly_Doanh_Thu
    {

        public WindowsElement taiKhoan => drive.FindElementByAccessibilityId("tb_user");
        public WindowsElement dangKy => drive.FindElementByName("Đăng ký");
        public WindowsElement quenMatKhau => drive.FindElementByName("Quên mật khẩu?");
        public WindowsElement ghiNhoLogin => drive.FindElementByAccessibilityId("cb_reme");
        public WindowsElement matKhau => drive.FindElementByAccessibilityId("tb_pass");
        public WindowsElement dangNhap => drive.FindElementByAccessibilityId("btn_login");
        public WindowsElement thongBao => drive.FindElementByAccessibilityId("2");

        public WindowsElement thoat => drive.FindElementByName("Close");
        public static AppiumOptions options = new AppiumOptions();
        string actual;
        WindowsDriver<WindowsElement> drive;

        [SetUp]
        public void Setup()
        {
            System.Diagnostics.Process.Start(@"C:\Program Files (x86)\Windows Application Driver\WinAppDriver.exe");//gọi winappdrive

            options.AddAdditionalCapability("app", @"C:\Users\ASUS\source\repos\DuAn1\bin\Debug\net6.0-windows\GUI.exe");//đường dẫn đến app cần test

            drive = new WindowsDriver<WindowsElement>(new Uri("http://127.0.0.1:4723"), options);

            System.Threading.Thread.Sleep(2000);
        }

        [TearDown]
        public void ExistTest()
        {
            drive.Quit();
        }

        void SendKey()
        {
            taiKhoan.SendKeys("halv@gmail.com");
            matKhau.SendKeys("1");
            dangNhap.Click();
            thongBao.Click();
        }



        //xuất file thành công
        [Test]
        public void TestCase_GDCCN_QLDT2()
        {

            SendKey();

            drive.SwitchTo().Window(drive.WindowHandles.Last());
            drive.FindElementByAccessibilityId("btn_dthu").Click();

            drive.FindElementByAccessibilityId("btn_Export").Click();

            Thread.Sleep(1000);
            //drive.FindElementByName("File name").SendKeys("Test");

            //WebDriverWait wait = new WebDriverWait(drive, TimeSpan.FromSeconds(1000));
            //drive.SwitchTo().Window(drive.WindowHandles.Last());


            drive.FindElementByAccessibilityId("1001").SendKeys("test");
            drive.FindElementByAccessibilityId("1").Click();

            Thread.Sleep(1000);
            WindowsElement thongBap = drive.FindElementByAccessibilityId("65535");
            actual = thongBap.Text;
            drive.FindElementByAccessibilityId("2").Click();
            Assert.AreEqual("Xuất file thành công!", actual);


        }
        //Chức năng lọc từ ngày 
        [Test]
        public void TestCase_GDCCN_QLDT3()
        {
            Actions actions = new Actions(drive);
            SendKey();

            drive.SwitchTo().Window(drive.WindowHandles.Last());
            drive.FindElementByAccessibilityId("btn_dthu").Click();

            //drive.FindElementByAccessibilityId("date_From").Click();

            WindowsElement dateTimepick = drive.FindElementByAccessibilityId("date_To");
            actions.MoveToElement(dateTimepick).SendKeys(Keys.LeftControl).Click().Perform();

            Thread.Sleep(2000);
            //WebDriverWait wait = new WebDriverWait(drive, TimeSpan.FromSeconds(1000));
            Thread.Sleep(1000);
            WindowsElement thongBap = drive.FindElementByAccessibilityId("65535");
            actual = thongBap.Text;
            drive.FindElementByAccessibilityId("2").Click();
            Assert.AreEqual("Ngày sau không thể nhỏ hơn ngày trước", actual);
        }

        [Test]
        public void TestCase_GDCCN_QLDT1()
        {
            Actions actions = new Actions(drive);
            SendKey();

            drive.SwitchTo().Window(drive.WindowHandles.Last());
            drive.FindElementByAccessibilityId("btn_dthu").Click();

            //drive.FindElementByAccessibilityId("date_From").Click();

            WindowsElement dateTimepick = drive.FindElementByAccessibilityId("date_From");
            actions.MoveToElement(dateTimepick).Click().Perform();
            actions.KeyDown(Keys.Command);
            Thread.Sleep(1000);
            drive.FindElementByAccessibilityId("btn_fill").Click();
            //WebDriverWait wait = new WebDriverWait(drive, TimeSpan.FromSeconds(1000));
            Thread.Sleep(1000);
            WindowsElement thongBap = drive.FindElementByAccessibilityId("65535");
            actual = thongBap.Text;
            drive.FindElementByAccessibilityId("2").Click();
            Assert.AreEqual("Ngày trước không được lớn hơn ngày sau", actual);
            drive.CloseApp();
        }

    }
}
