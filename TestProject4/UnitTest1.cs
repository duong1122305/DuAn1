using _1_DAL.IRepon;
using _1_DAL.Models;
using _1_DAL.Repon;
using _2_BUS.IService;
using _2_BUS.Service;
using _2_BUS.Validate;
using DuAn1;
using DuAn1.Views;
using GUI;
using GUI.Views;
using System.Security.Principal;
using System.Windows.Forms;

namespace TestProject4
{
    public class Tests
    {
        BookingAirlineContext _bookingAirlineContext;
        IChucVuServices chucVuServices;
        INhanVienRepon _nhanvienRepo;
        StaffRepo _taffRepo;
                Validate vl ;
        CheckAccountType checkAccountType;

        [SetUp]
        public void Setup()
        {
            chucVuServices = new ChucVuServices();
            _bookingAirlineContext = new BookingAirlineContext();
         vl = new Validate();
            _nhanvienRepo = new NhanVienRepon(_bookingAirlineContext);
            checkAccountType = new CheckAccountType();
            _taffRepo = new StaffRepo();
            //Form1 form1 = new Form1();
            //form1.Show(null);
        }


        //kiểm tra hàm checktyp xem loại tài khoản nào
        [Test]
        public void Test1()
        {

            string email = "cus1@gmail.com";

            string pass = "7:3597@:?=<>A??FCBDMFOKILLTQMPXQT[SSXV78124193631341163019195242951291391040";

            Assert.AreEqual(3, checkAccountType.CheckType(email,pass));

        }
        //kiểm tra hàm reverrse mật khẩu,"bảo mật"
        [Test]
        public void Test2()
        {

            string pass2 = "2";
            string pass = "7:3597@:?=<>A??FCBDMFOKILLTQMPXQT[SSXV78124193631341163019195242951291391040";
            vl.ReversePass(pass2);

            Assert.AreEqual(pass, vl.ReversePass(pass2));
        }

        //Dang_Nhap_DN1 check tài khoản có trong csdl chưa đăng nhập thành công
        [Test]
        public void Test3()
        {
            Form1 f = new Form1();

            string email = "halv@gmail.com";
            string pass = "7:3597@:?=<>A??FCBDMFOKILLTQMPXQT[SSXV78124193631341163019195242951291391040";
            f.tb_user.Text = email;
            f.tb_pass.Text = pass;
            bool check = _bookingAirlineContext.staff.Where(x => x.Email == email && x.Password == pass).FirstOrDefault() == null ? false : true;
            Assert.IsTrue(check, "Tài khoản có trong hệ thống");



        }
        //LOG_02 
        [Test]
        public void Test4()
        {
            string email = "halv@gmailcom";
            string pass = "1";
            string pass2 = vl.ReversePass(pass);
            bool check;
                /*_bookingAirlineContext.staff.Select(x => x.Email == email && x.Password == pass) == null ? false : true;*/
            if (_bookingAirlineContext.staff.Where(x=>x.Email == email && x.Password == pass).Count()==0)
            {
                check = false;
            }
            else
            {
                check = true;
            }
            Assert.IsTrue(check,"Tài khoản không có trong hệ thống");
        }

        //đăng nhập thất bại khi tài khoản không có trong hệ thống
        [Test]
        public void Test5()
        {
            string email = "admin";
            string pass = "admin";
            bool check = _bookingAirlineContext.staff.Select(x => x.Email == email && x.Password == pass) == null ? false : true;
            Assert.IsFalse(check, "Tài khoản không có trong hệ thống");
        }

        //đăng nhập thất bại khi tài khoản không có trong hệ thống
        [Test]
        public void Test6()
        {
            string email = "halv@gmail.com";
            string pass = "4";
            string pass2 = vl.ReversePass(pass);   
            bool check;
            /*_bookingAirlineContext.staff.Select(x => x.Email == email && x.Password == pass) == null ? false : true;*/
            if (_bookingAirlineContext.staff.Where(x => x.Email == email && x.Password == pass).Count() == 0)
            {
                check = false;
            }
            else
            {
                check = true;
            }
            Assert.IsFalse(check, "Tài khoản không có trong hệ thống");
        }

        //LOG_03 check hàm kiểm tra định dạng email
        [Test]
        public void Test7()
        {
            string email = "!@#$%^&*()@gmail.com";
            bool check = vl.checkEmail(email);
            Assert.IsTrue(check);
        }

        //tesst thêm nhân viên
        [TestCase]
        public void Test8()
        {
            staff staff = new staff();
            staff.DisplayName = "Nguyễn Đức Việt";
            staff.RoleId = 1;
            staff.Email = "test";
            staff.Status = 1;
            staff.Phone = "012345689";
            staff.Password = vl.ReversePass("1"); 

            var result = _bookingAirlineContext.staff.Add(staff);
            _bookingAirlineContext.SaveChanges();
            //Assert.AreEqual(true, result.IsKeySet);
            Assert.That(result, Is.Not.Null);
        }

        //cập nhập nhân viên
        [TestCase]
        public void Test9()
        {
            //staff staff = new staff();
            //staff.DisplayName = "HIHI";
            //staff.RoleId = 1;
            //staff.Email = "HIHI";
            //staff.Status = 1;
            //staff.Phone = "012345689";
            //staff.Password = "1";

            int id = 11;
            _bookingAirlineContext.staff.FirstOrDefault(x => x.Id == id);
            staff staff = _bookingAirlineContext.staff.FirstOrDefault(x => x.Id == id);
            staff.DisplayName = "Nguyễn Đức Việt";
            staff.RoleId = 1;
            staff.Email = "Emkhongbigay@gmail.com";
            staff.Status = 1;
            staff.Phone = "012345689";
            staff.Password = "1";

            bool check = _taffRepo.Update(staff);
            Assert.IsTrue(check);
            //var result = _bookingAirlineContext.staff.Update(staff);
            //_bookingAirlineContext.SaveChanges();
            //Assert.AreEqual(true, result.IsKeySet);
        }

        [TestCase]
        public void Test10()
        {
            var list = _bookingAirlineContext.Flights.ToList().Count();
            Assert.AreEqual(42,list);
        }



    }
}