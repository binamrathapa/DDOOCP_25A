using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    public class Laptop
    {
        string type;
        public Laptop(string type)
        {
           this.type = type;
        }
        public Laptop()
        {
        }
        public string GetLaptopType()
        {
            return type;
        }
    }
}
