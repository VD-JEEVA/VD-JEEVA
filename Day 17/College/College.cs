using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace College
{
    class College
    {
        static int globalStudentId = 0;


        List<Student> studentsList;

        List<Staff> staffList;

        List<Department> departmentsList;

        public College()
        {
            studentsList = new List<Student>();
            staffList = new List<Staff>();
            departmentsList = new List<Department>();
        }

        public void addDepartment(string name, string[] subjects) 
        {
            departmentsList.Add(new Department(name, subjects));
        }

        public Department? getDepartment(string name)
        {
            foreach (Department department in departmentsList)
            {
                if(department.Name.Equals(name))
                    return department;
            }
            return null;
        }

        public void admitStudent(string name, Department department)
        {
            studentsList.Add(new Student(++globalStudentId, name, department));
        }

        public void readStudents()
        {
            foreach (Student student in studentsList)
            {
                Console.WriteLine(student.Id + " " + student.Name + " " + student.Department.Name);
            }
        }
    }
}
