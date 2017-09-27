using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dotNet_lab3
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();

            listBoxStudents.DataSource = Program.students;
            listBoxStudents.DisplayMember = "lastName";
            //listBoxStudents.ValueMember = "Id";
        }

        private void GetStudentList()
        {
            //listBoxStudents.Items.Clear();
            //foreach (Student st in Program.students)
            //{
            //    listBoxStudents.Items.Add(st.LastName + " " + st.MiddleName + " " + st.FirstName);
            //}
            listBoxStudents.DataSource = null;
            listBoxStudents.DataSource = (Program.students.Count > 0) ? new BindingSource(Program.students, null) : null;
            listBoxStudents.DisplayMember = "DisplayStr";
            //listBoxStudents.ValueMember = "Id";
            listBoxStudents.Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Program.students.Add(new Student(textBoxFN.Text, textBoxMN.Text, textBoxLN.Text, textBoxAddr.Text, maskedTextBoxPhone.Text));
            GetStudentList();
        }

        private void listBoxStudents_SelectedIndexChanged(object sender, EventArgs e)
        {
            Student SelectedStudent = (Student)listBoxStudents.SelectedItem;
            if (SelectedStudent != null) {
                lblStudentInfo.Text = SelectedStudent.FirstName.Substring(1, 1) + ". " + SelectedStudent.MiddleName.Substring(1,1) + 
                    ". " + SelectedStudent.LastName + " (" + SelectedStudent.Address + ")";
            }
        }
    }
}
