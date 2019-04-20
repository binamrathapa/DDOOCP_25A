using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    public class Student
    {
        private int id;
        private string name;
        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        public string Name
        {
            set { name=value; }
            get { return name; }
        }

    }
}
