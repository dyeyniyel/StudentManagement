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
    public partial class editForm : Form
    {
        StudentManager studentManager;
        Student EditStudent;
        public editForm(StudentManager studentManager)
        {
            InitializeComponent();
            this.studentManager = studentManager;
        }

        private void txtid_TextChanged(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtid.Text);
            EditStudent = studentManager.GetStudent(id);
            txtName.Text = EditStudent.Name1;
            txtAddress.Text = EditStudent.Address;
            txtPhone.Text = EditStudent.PhoneNumber;
            txtSem.Text = EditStudent.Sem1.ToString();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            EditStudent.Name1 = txtName.Text;
            EditStudent.Address = txtAddress.Text;
            EditStudent.PhoneNumber = txtPhone.Text;
            EditStudent.Sem1 = Convert.ToInt32(txtSem.Text);

            studentManager.UpdateStudent(EditStudent);

            MessageBox.Show("Data Updated");

            this.Close();
        }
    }
}
