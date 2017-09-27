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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void GetStudentList()
        {
            listBoxStudents.Items.Clear();
            foreach (Student st in Program.students)
            {
                listBoxStudents.Items.Add(st.LastName + " " + st.MiddleName + " " + st.FirstName);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Student NewStudent = new Student(textBoxFN.Text, textBoxMN.Text, textBoxLN.Text, textBoxAddr.Text, maskedTextBoxPhone.Text);
            Program.students.Add(NewStudent);
            GetStudentList();
        }
    }
}
