using System;
using System.IO;
using NUnit.Framework;
using TestStack.White;
using TestStack.White.UIItems;
using TestStack.White.UIItems.Finders;
using TestStack.White.UIItems.WindowItems;

using Application = System.Windows.Forms.Application;

namespace TestProject2
{
    [TestFixture]
    public class Tests
    {
        private Application application;
        private System.Windows.Forms.VisualStyles.VisualStyleElement.Window mainWindow;

        [SetUp]
        public void SetUp()
        {
            // Thay đổi đường dẫn đến ứng dụng của bạn
            //C: \Users\ASUS\source\repos\DuAn1\bin\Debug\net6.0 - windows\GUI.exe
            var appPath = Path.Combine("C:\\Users\\ASUS\\source\\repos\\DuAn1\\bin\\Debug\\net6.0-windows", "GUI.exe");
            application = Application.Launch(appPath);
            // Đợi cho ứng dụng khởi động hoàn tất
            mainWindow = application("Đăng nhập", InitializeOption.NoCache);
        }

        [Test]
        public void TestLogin()
        {
            // Lấy các đối tượng UI (element) cần kiểm thử
            var usernameTextBox = mainWindow.Get<TextBox>(SearchCriteria.ByAutomationId("tb_user"));
            var passwordTextBox = mainWindow.Get<TextBox>(SearchCriteria.ByAutomationId("tb_pass"));
            var loginButton = mainWindow.Get<Button>(SearchCriteria.ByAutomationId("btn_login"));

            // Nhập thông tin đăng nhập hợp lệ
            usernameTextBox.Text = "halv@gmail.com";
            passwordTextBox.Text = "1";

            // Bấm nút đăng nhập
            loginButton.Click();

            // Đợi cho ứng dụng xử lý và kiểm tra kết quả
            Assert.AreEqual("Thông báo", mainWindow.Title);
        }

        [TearDown]
        public void TearDown()
        {
            // Đóng ứng dụng sau khi kiểm thử
            application.Kill();
        }
    }
}