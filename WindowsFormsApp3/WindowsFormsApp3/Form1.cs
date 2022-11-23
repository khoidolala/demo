using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DataUtil data = new DataUtil();
        private void Form1_Load(object sender, EventArgs e)
        {
            DisplayData();
        }
        private void DisplayData()
        {
            dataGridView1.DataSource = data.GetAllTaikhoans();
            dataGridView1.Columns[0].Width = 100;
            dataGridView1.Columns[1].Width = 100;
            dataGridView1.Columns[2].Width = 100;
            dataGridView1.Columns[3].Width = 100;
            dataGridView1.Columns[4].Width = 100;
        }
        private void btnthem_Click(object sender, EventArgs e)
        {
            taikhoan t = new taikhoan();
            t.sotaikhoan = txtsotaikhoan.Text;
            t.tentaikhoan = txttentaikhoan.Text;
            t.diachi = txtdiachi.Text;
            t.dienthoai = txtdienthoai.Text;
            t.sotien = txtsotien.Text;
            data.addTaiKhoan(t);
            xoaTextbox();
        }
        private void xoaTextbox()
        {
            txtsotaikhoan.Clear();
            txttentaikhoan.Clear();
            txtdiachi.Clear();
            txtdienthoai.Clear();
            txtsotien.Clear();
            ActiveControl = txtsotaikhoan;
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnloadfile_Click(object sender, EventArgs e)
        {
            DisplayData();
        }
    }
}
