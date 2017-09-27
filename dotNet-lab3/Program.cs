using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

// Вариант 9	
//1.	Студенты(фамилия, имя, отчество, адрес, телефон).
//2.	Предметы(название, объем лекций, объем практик, объем лабораторных работ).
//3.	Учебный план(студент, предмет, оценка).
//4.	Определение факультативов для студентов

namespace dotNet_lab3
{
    using StudentCourse = Tuple<Student, Course>;
    using StudentCourse2 = KeyValuePair<Student, Course>;

    public class Student
    {
        public string FirsName;
        public string MiddleName;
        public string LastName;
        public string Address;
        public string Phone;
    }

    public class Course
    {
        public string Name;
        public int LecturesCount;
        public int PracticalCount;
        public int LaborCount;
    }

    public class StudyPlan
    {
        Dictionary<StudentCourse, int> rating;
        Dictionary<StudentCourse2, int> rating2;
        void ddd()
        {
            Student st1 = new Student();
            Course c1 = new Course();
            rating.Add(new StudentCourse(st1, c1), 3);
        }
    }

    public class StudyElective
    {

    }



    static class Program
    {
        static List<Student> students;
        static List<Course> courses;

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
