using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication3.Models
{
    public class NhanVien
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string DonVi { get; set; }
        public double LuongNgay { get; set; }
        public int SoNgay { get; set; }
        public double ThuNhap()
        {
            if (SoNgay >= 25)
                return LuongNgay * SoNgay + 500000;
            else
                return LuongNgay * SoNgay;
        }
    }
}