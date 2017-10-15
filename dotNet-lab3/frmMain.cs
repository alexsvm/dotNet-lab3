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
            lblStudentRatingInfo.Text = "Оценка студента (" + student.DisplayStr + ") по курсу \"" + course.DisplayStr + "\":";
            if (student.CourseRating.ContainsKey(course))
            {
                edStudentCourseRating.Text = student.CourseRating[course].ToString();
            }
            else
                edStudentCourseRating.Text = "";
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

        private void btnSaveStudentRating_Click(object sender, EventArgs e)
        {
            Course SelectedCourse = (Course)listBoxCourses.SelectedItem;
            Student SelectedStudent = (Student)listBoxStudents.SelectedItem;
            int? vRating = Convert.ToInt16(edStudentCourseRating.Text);
            if (vRating != null && SelectedCourse != null && SelectedStudent != null)
                SelectedStudent.CourseRating[SelectedCourse] = (int)vRating;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //textBox1.Text += Environment.NewLine + "Sdas";
            int i = 1;
            try
            {
                i = Convert.ToInt32(maskedTextBox1.Text);
            }
            catch (FormatException E)
            {
                textBox1.Text += "Input string is not a sequence of digits." + Environment.NewLine;
            }
            catch (OverflowException E)
            {
                textBox1.Text += "The number cannot fit in an Int32." + Environment.NewLine;
            }
            for (int j = 1; j <= i; j++)
            {
                textBox1.Text += j.ToString() + Environment.NewLine;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int j = 1; j <= numericUpDown1.Value; j++)
            {
                textBox1.Text += j.ToString() + Environment.NewLine;
            }
        }

        private void frmMain_Shown(object sender, EventArgs e)
        {
            notifyIcon1.ShowBalloonTip(1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Add(textBox2.Text);
        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            textBox3.Text += comboBox1.Text + Environment.NewLine;
        }

        private void comboBox2_SelectionChangeCommitted(object sender, EventArgs e)
        {
            label10.Text = comboBox2.Text;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();
            int LinesCount = textBox4.Lines.Count();
            for (int i = 0; i < LinesCount; i++)
            {
                try
                {
                    int val = Convert.ToInt32(textBox4.Lines[i]);
                    comboBox2.Items.Add(textBox4.Lines[i]);
                }
                catch
                {

                }
            }
        }

        private void textBox5_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {// Парсим последнюю строку
                string[] ss;

                ss = textBox5.Lines[textBox5.Lines.Count() - 1].Split('*');
                if (ss.Count() > 1)
                {
                    try
                    {
                        double num1 = Convert.ToDouble(ss[0]);
                        double num2 = Convert.ToDouble(ss[1]);
                        textBox5.Text += Environment.NewLine;
                        textBox5.Text += Convert.ToString(num1 * num2);
                        textBox5.SelectionStart = textBox5.Text.Length;
                        return;
                    }
                    catch
                    {
                        textBox5.Text += Environment.NewLine + "Ошибка в выражении!" + Environment.NewLine;
                        textBox5.SelectionStart = textBox5.Text.Length;
                        return;
                    }
                } // if 

                ss = textBox5.Lines[textBox5.Lines.Count() - 1].Split('/');
                if (ss.Count() > 1)
                {
                    try
                    {
                        double num1 = Convert.ToDouble(ss[0]);
                        double num2 = Convert.ToDouble(ss[1]);
                        textBox5.Text += Environment.NewLine;
                        textBox5.Text += Convert.ToString(num1 / num2);
                        textBox5.SelectionStart = textBox5.Text.Length;
                        return;
                    }
                    catch
                    {
                        textBox5.Text += Environment.NewLine + "Ошибка в выражении!" + Environment.NewLine;
                        textBox5.SelectionStart = textBox5.Text.Length;
                        return;
                    }
                } // if

                ss = textBox5.Lines[textBox5.Lines.Count() - 1].Split('+');
                if (ss.Count() > 1)
                {
                    try
                    {
                        double num1 = Convert.ToDouble(ss[0]);
                        double num2 = Convert.ToDouble(ss[1]);
                        textBox5.Text += Environment.NewLine;
                        textBox5.Text += Convert.ToString(num1 + num2);
                        textBox5.SelectionStart = textBox5.Text.Length;
                        return;
                    }
                    catch {
                        textBox5.Text += Environment.NewLine + "Ошибка в выражении!" + Environment.NewLine;
                        textBox5.SelectionStart = textBox5.Text.Length;
                        return;
                    }
                } // if 

                ss = textBox5.Lines[textBox5.Lines.Count() - 1].Split('-');
                if (ss.Count() > 1)
                {
                    try
                    {
                        int a, b;
                        a = (ss[0] == "") ? 1 : 0;
                        b = (ss[a+1] == "") ? a + 2 : a + 1;
                        double num1 = (a == 1)? - Convert.ToDouble(ss[a]) : Convert.ToDouble(ss[a]);
                        double num2 = (b-a) > 1 ? - Convert.ToDouble(ss[b]) : Convert.ToDouble(ss[b]);
                        //double num1 = ss[0] == "" ? Convert.ToDouble(ss[1]) : Convert.ToDouble(ss[0]);
                        //double num2 = ss[0] == "" ? Convert.ToDouble(ss[2]) : Convert.ToDouble(ss[1]);
                        textBox5.Text += Environment.NewLine;
                        textBox5.Text += Convert.ToString(num1 - num2);
                        textBox5.SelectionStart = textBox5.Text.Length;
                        return;
                    }
                    catch
                    {
                        textBox5.Text += Environment.NewLine + "Ошибка в выражении!" + Environment.NewLine;
                        textBox5.SelectionStart = textBox5.Text.Length;
                        return;
                    }
                } // if 
            }
        }

        private void textBox5_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                if (textBox5.Lines[textBox5.Lines.Count() - 1] == "")
                {
                    textBox5.Text = textBox5.Text.Substring(0, textBox5.Text.Length - 2);
                    textBox5.SelectionStart = textBox5.Text.Length;
                }
            }
        }
        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            List<string> ls = new List<string>();
            //string ss = "";
            foreach (string s in textBox6.Lines)
            {
                try
                {
                    double d = Convert.ToDouble(s);
                    ls.Add(s);
                }
                catch
                {
                    char[] ca = s.ToCharArray();
                    Array.Reverse(ca);
                    ls.Add(new string(ca));
                }
            } // foreach
            textBox6.Text = String.Join(Environment.NewLine, ls.ToArray());
            //textBox6.Text = ss;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Rows.Add();
            dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[0].Value = "sdxasd";
            dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[1].Value = "fffffff";
        }

        private double Func(double X, int N)
        {
            return 1 / Math.Pow(X,N);
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            double summ = 0;
            double summ1 = 0;
            double accuracy = (double)numericUpDown3.Value;
            double X = (double)numericUpDown2.Value;

            dataGridView1.Rows.Clear();

            int n = 1;
            do
            {
                summ1 = summ;
                summ += Func(X, n);
                dataGridView1.Rows.Add();
                dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[0].Value = n;
                dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[1].Value = summ;

                n++;
            } while (summ - summ1 > accuracy);
        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {

        }

        private delegate void MyFunc(out double y, double x);

        private void btnTabulate_Click(object sender, EventArgs e)
        {
            double LLimit = (double)nudLowerLimit.Value;
            double ULimit = (double)nudUpperLimit.Value;
            double Step = (double)nudStep.Value;

            var func = CSCompiler.GetDelegate(typeof(MyFunc), tbStatement.Text) as MyFunc;

            double z;
            func(out z, 2);

            dataGridView2.Rows.Clear();

            double y;
            for (double x = LLimit; x <= ULimit; x += Step)
            {
                func(out y, x);
                dataGridView2.Rows.Add();
                dataGridView2.Rows[dataGridView2.Rows.Count - 1].Cells[0].Value = x;
                dataGridView2.Rows[dataGridView2.Rows.Count - 1].Cells[1].Value = y;
            }
        }
    }
}
