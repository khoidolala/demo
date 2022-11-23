using Microsoft.AspNetCore.Mvc;
using WebApplication2.Models;
using System.Linq;
using System.Collections.Generic;
using System.Web;


namespace WebApplication2.Controllers
{
    public class NhapDiemController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public ActionResult Save(SinhVien sv)
        {
            string path = Server.MathPath("~/StudenInfor.txt");
            string[] line = {sv.id, sv.name,sv.mark.ToString()};
            System.IO.File.WriteAllLines(path, line);
            ViewBag.HanhDong = "Đã ghi từ file";
            return View();
        }
    }
}
