using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication3.Models;
namespace WebApplication3.Controllers
{
    public class QuanLyController : Controller
    {
        // GET: QuanLy
        public ActionResult Index()
        {
            return View();
        }
        List<NhanVien> danhsach = new List<NhanVien>();
        
    }
}