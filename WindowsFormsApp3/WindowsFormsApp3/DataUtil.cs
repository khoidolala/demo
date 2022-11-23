using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.IO;
namespace WindowsFormsApp3
{
    internal class DataUtil
    {
        XmlDocument doc;
        XmlElement root;
        string filename;
        public DataUtil()
        {
            filename = "nganhang.xml";
            doc = new XmlDocument();
            if (!File.Exists(filename))
            {
                XmlElement nganhang = doc.CreateElement("nganhang");
                doc.AppendChild(nganhang);
                doc.Save(filename);
            }
            doc.Load(filename);
            root = doc.DocumentElement;
        }
        public void addTaiKhoan(taikhoan t)
        {
            XmlElement tk = doc.CreateElement("taikhoan");
            XmlElement tentaikhoan = doc.CreateElement("tentaikhoan");
            XmlElement sotaikhoan = doc.CreateElement("sotaikhoan");
            XmlElement diachi = doc.CreateElement("diachi");
            XmlElement dienthoai = doc.CreateElement("dienthoai");
            XmlElement sotien = doc.CreateElement("sotien");
            sotaikhoan.InnerText = t.sotaikhoan;
            tentaikhoan.InnerText = t.tentaikhoan;
            diachi.InnerText = t.diachi;
            dienthoai.InnerText = t.dienthoai;
            sotien.InnerText = t.sotien;
            tk.AppendChild(sotaikhoan);
            tk.AppendChild(tentaikhoan);
            tk.AppendChild(diachi);
            tk.AppendChild(dienthoai);
            tk.AppendChild(sotien);
            root.AppendChild(tk);
            doc.Save(filename);
        }
        public List<taikhoan> GetAllTaikhoans()
        {
            XmlNodeList nodes = root.SelectNodes("taikhoan");
            List<taikhoan> li = new List<taikhoan>();
            foreach(XmlNode item in nodes)
            {
                taikhoan t = new taikhoan();
                t.tentaikhoan = item.SelectSingleNode("tentaikhoan").InnerText;
                t.sotaikhoan = item.SelectSingleNode("sotaikhoan").InnerText;
                t.diachi = item.SelectSingleNode("diachi").InnerText;
                t.dienthoai = item.SelectSingleNode("dienthoai").InnerText;
                t.sotien = item.SelectSingleNode("sotien").InnerText;
                li.Add(t);
            }
            return li;
        }
    }
}
