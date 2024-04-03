using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace StudentManagement
{
    public partial class Form1 : Form
    {
        StudentManager studentManager;
        public Form1(StudentManager sm)
        {
            InitializeComponent();
            this.studentManager = sm;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtid.Text = studentManager.GetCount().ToString();
            txtid.Enabled = false;

        }



        private void btnSubmit_Click(object sender, EventArgs e)
        {

            studentManager.addStudent(new Student(
                    studentManager.GetCount(),
                    txtName.Text,
                    Convert.ToInt32(txtSem.Text),
                    txtAddress.Text,
                    txtPhone.Text
                ));

            MessageBox.Show("New Student Added");



        }

        private void btnShowAllStudents_Click(object sender, EventArgs e)
        {
            dataForm df = new dataForm(studentManager);
            df.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            editForm frm = new editForm(studentManager);
            frm.Show();
        }
    }
}
