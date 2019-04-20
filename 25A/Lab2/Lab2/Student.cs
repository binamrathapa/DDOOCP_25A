using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    public class Student
    {
        private string fname;
        private string lname;
        public string FirstName
        {
            get { return fname; }
            set { fname = value; }
        }
        public string LastName
        {
            get { return lname; }
            set { lname = value; }
        }
        public string GetFullName()
        {
            return FirstName + LastName;
        }
    }
}
