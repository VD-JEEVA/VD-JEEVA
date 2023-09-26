using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace College
{
    class Student
    {
        public int Id;
        public string Name;
        public Department Department;

        public Student(int id, string name, Department department) {
            this.Id = id;
            this.Name = name;
            this.Department = department;
        }
    }
}
