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

    public class Student
    {
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string DisplayStr {
            get {
                return LastName + " " + FirstName + " " + MiddleName;
            }
            set { }
        }
        public Dictionary<Course, int> CourseRating;

        public Student(string firstName, string middleName, string lastName, string address, string phone) {
            FirstName = firstName;
            MiddleName = middleName;
            LastName = lastName;
            Address = address;
            Phone = phone;
            CourseRating = new Dictionary<Course, int>();
        }
    }

    public class Course
    {
        public string Name { get; set; }
        public int LecturesCount { get; set; }
        public int PracticalCount { get; set; }
        public int LaborCount { get; set; }
        public Course(string name, int lecturesCount, int practicalCount, int laborCount)
        {
            Name = name;
            LecturesCount = lecturesCount;
            PracticalCount = practicalCount;
            LaborCount = laborCount;
        }
        public string DisplayStr
        {
            get
            {
                return Name + " (" + LecturesCount + ", " + PracticalCount + ", " + LaborCount + ")";
            }
            set { }
        }
    }

    public class StudyElective
    {

    }



    static class Program
    {
        public static List<Student> students;
        public static List<Course> courses;
 

        [STAThread]
        static void Main()
        {
            students = new List<Student>();
            courses = new List<Course>();

            Course C = new Course("Информатика", 9, 3, 2);
            courses.Add(C);
            Student S = new Student("Иван", "Иванович", "Иванов", "Дефаулт-сити", "3322322");
            S.CourseRating[C] = 3;
            students.Add(S);
            
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmMain());
        }
    }
}
