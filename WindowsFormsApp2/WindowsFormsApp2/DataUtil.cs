using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.IO;
namespace WindowsFormsApp2
{
    internal class DataUtil
    {
        XmlDocument doc;
        XmlElement root;
        string filename;
        public DataUtil()
        {
            filename = "Course.xml";
            doc = new XmlDocument();
            if (!File.Exists(filename)){
                XmlElement course = doc.CreateElement("course");
                doc.AppendChild(course);
                doc.Save(filename);
            }
            doc.Load(filename);
            root = doc.DocumentElement;
        }
        public void AddStudent(Student s)
        {
            XmlElement st = doc.CreateElement("student");
            st.SetAttribute("id", s.id);
            XmlElement name = doc.CreateElement("name");
            name.InnerText = s.name;
            st.AppendChild(name);
            XmlElement age = doc.CreateElement("age");
            age.InnerText = s.age;
            st.AppendChild(age);
            XmlElement city = doc.CreateElement("city");
            city.InnerText = s.city;
            st.AppendChild(city);
            root.AppendChild(st);
            doc.Save(filename);
        }
        public bool UpdateStudents(Student s)
        {
            XmlNode stfind = root.SelectSingleNode("student[@id='"+s.id+"']");
            if (stfind != null)
            {
                XmlElement st = doc.CreateElement("student");
                st.SetAttribute("id", s.id);
                XmlElement name = doc.CreateElement("name");
                name.InnerText = s.name;
                st.AppendChild(name);
                XmlElement age = doc.CreateElement("age");
                age.InnerText = s.age;
                st.AppendChild(age);
                XmlElement city = doc.CreateElement("city");
                city.InnerText = s.city;
                st.AppendChild(city);
                root.ReplaceChild(st, stfind);
                doc.Save(filename);
                return true;
            }
            return false;
        }
        public List<Student> GetAllStudents()
        {
            XmlNodeList nodes = root.SelectNodes("student");
            List<Student> li = new List<Student>();  
            foreach(XmlNode item in nodes)
            {
                Student s = new Student();
                s.id = item.Attributes["id"].InnerText;
                s.name = item.SelectSingleNode("name").InnerText;
                s.age = item.SelectSingleNode("age").InnerText;
                s.city = item.SelectSingleNode("city").InnerText;
                li.Add(s);
            }
            return li;
        }
    }
}
