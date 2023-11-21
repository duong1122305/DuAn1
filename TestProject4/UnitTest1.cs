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
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Security.Principal;
using System.Windows.Forms;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

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
        }

        [Test]
        public void Log_in1()
        {
            Form1 form = new Form1();
            Fquanlynv f = new Fquanlynv();
           
            //form.Show();

            //form.llb_forgot_LinkClicked(null, null);
            //form.MouseClick(form.llb_forgot_LinkClicked(null,null));
        }



    }
}