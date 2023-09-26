using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace College
{
    class Department
    {
        public string Name;
        public string[] subject;

        public Department(string name, string[] subject)
        {
            this.Name = name;
            this.subject = subject;
        }
    }
}
