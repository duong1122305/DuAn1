using NUnit.Framework;
using TestStack.White.Factory;
using TestStack.White.UIItems.Finders;
using TestStack.White.UIItems;
using TestStack.White;
using System.Windows;
namespace TestProject3
{
    [TestFixture]
    public class LoginFormTests
    {
        [Test]
        public void TestLoginAndOpenOtherForm()
        {
            // Khởi tạo ứng dụng
            var application = Application.Launch("C:\\Users\\ASUS\\source\\repos\\DuAn1\\bin\\Debug\\net6.0-windows\\GUI.exe");

            // Đợi cho cửa sổ đăng nhập xuất hiện
            var loginWindow = application.GetWindow("Đăng nhập", InitializeOption.WithCache);
            // Simulate user input
            //var usernameTextBox = loginWindow.Get<TextBox>(SearchCriteria.ByAutomationId("tb_user"));
            //var passwordTextBox = loginWindow.Get<TextBox>(SearchCriteria.ByAutomationId("tb_pass"));
            var loginButton = loginWindow.Get<Button>(SearchCriteria.ByAutomationId("btn_login"));


            //usernameTextBox.Text = "halv@gmail.com";
            //passwordTextBox.Text = "1";

            // Bấm nút đăng nhập
            loginButton.Click();

            // Đợi cho cửa sổ đăng nhập đóng và forms khác xuất hiện
            loginWindow.WaitWhileBusy();

            // Kiểm tra forms khác đã mở
            var otherForm = application.GetWindow("Giao diện các chức năng", InitializeOption.NoCache);
            Assert.AreEqual("Giao diện các chức năng", otherForm.Title);

            // Đóng ứng dụng sau khi kiểm thử
            application.Close();
        }
    }

}