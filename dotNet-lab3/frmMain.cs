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
            listBoxStudents.DisplayMember = "DisplayStr";
            //listBoxStudents.ValueMember = "Id";
            listBoxCourses.DataSource = Program.courses;
            listBoxCourses.DisplayMember = "DisplayStr";
        }

        private void GetStudentList()
        {
            listBoxStudents.DataSource = null;
            listBoxStudents.DataSource = (Program.students.Count > 0) ? new BindingSource(Program.students, null) : null;
            listBoxStudents.DisplayMember = "DisplayStr";
            //listBoxStudents.ValueMember = "Id";
            listBoxStudents.Refresh();
        }

        private void GetCoursesList()
        {
            listBoxCourses.DataSource = null;
            listBoxCourses.DataSource = (Program.courses.Count > 0) ? new BindingSource(Program.courses, null) : null;
            listBoxCourses.DisplayMember = "DisplayStr";
            //listBoxCourses.ValueMember = "Id";
            listBoxCourses.Refresh();
        }

        private void GetStudentCourseInfo(Student student, Course course)
        {
            //if (Program.studyPlan.rating.Contains(new dotNet_lab3.StudentCourse(student, course));
            (Program.studyPlan.rating.ContainsKey(new StudentCourse(student, course))
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Program.students.Add(new Student(textBoxFN.Text, textBoxMN.Text, textBoxLN.Text, textBoxAddr.Text, maskedTextBoxPhone.Text));
            GetStudentList();
        }

        private void listBoxStudents_SelectedIndexChanged(object sender, EventArgs e)
        {
            Student SelectedStudent = (Student)listBoxStudents.SelectedItem;
            Course SelectedCourse = (Course)listBoxCourses.SelectedItem;
            if (SelectedStudent != null) {
                lblStudentInfo.Text = SelectedStudent.FirstName.Substring(0, 1) + ". " + SelectedStudent.MiddleName.Substring(0,1) + 
                    ". " + SelectedStudent.LastName + " (" + SelectedStudent.Address + ")";
                if (SelectedCourse != null)
                    GetStudentCourseInfo(SelectedStudent, SelectedCourse);
            }
        }

        private void btnAddCourse_Click(object sender, EventArgs e)
        {
            Program.courses.Add(new Course(textBoxCourseName.Text, (int)edCourseLCount.Value, (int)edCoursePCount.Value, (int)edCourseLabCount.Value));
            GetCoursesList();
        }

        private void listBoxCourses_SelectedIndexChanged(object sender, EventArgs e)
        {
            Course SelectedCourse = (Course)listBoxCourses.SelectedItem;
            Student SelectedStudent = (Student)listBoxStudents.SelectedItem;
            if (SelectedCourse != null && SelectedStudent != null)
                GetStudentCourseInfo(SelectedStudent, SelectedCourse);

        }
    }
}
