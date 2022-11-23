using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
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
            dataGridView1.DataSource = data.GetAllStudents();
            dataGridView1.Columns[0].Width = 50;
            dataGridView1.Columns[1].Width = 250;
            dataGridView1.Columns[2].Width = 50;
            dataGridView1.Columns[3].Width = 200;
            lblCount.Text = dataGridView1.Rows.Count + "";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Student s = new Student();
            s.id = txtID.Text;
            s.name = txtName.Text;
            s.age = txtAge.Text;
            s.city = txtCity.Text;
            data.AddStudent(s);
            ClearTextbox();
            DisplayData();
        }
        private void ClearTextbox()
        {
            txtID.Clear();
            txtName.Clear();
            txtAge.Clear();
            txtCity.Clear();    
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLoadFile_Click(object sender, EventArgs e)
        {
            DisplayData();
        }

        private void GetAStudent(object sender, DataGridViewCellEventArgs e)
        {
            Student s = (Student)dataGridView1.CurrentRow.DataBoundItem;
            txtID.Text = s.id;
            txtName.Text = s.name;
            txtAge.Text = s.age;
            txtCity.Text = s.city;
        }
    }
}
