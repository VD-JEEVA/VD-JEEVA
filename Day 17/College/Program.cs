using System;

namespace College
{
    class MainClass 
    {
        static void Main(string[] args)
        {
            College college = new College();
            college.addDepartment("ECE", new string[] { "C", "Python", "CAO", "EC", "MPMC"});
            college.addDepartment("CSE", new string[] { "C", "Python", "CAO", "EC", "MPMC" });
            college.addDepartment("EEE", new string[] { "C", "Python", "CAO", "EC", "MPMC" });

            college.admitStudent("jeeva", college.getDepartment("ECE"));
            college.admitStudent("a", college.getDepartment("CSE"));
            college.admitStudent("b", college.getDepartment("ECE"));
            college.admitStudent("c", college.getDepartment("EEE"));
            college.admitStudent("d", college.getDepartment("CSE"));
            college.admitStudent("e", college.getDepartment("ECE"));
            college.readStudents();
        }
    }
}