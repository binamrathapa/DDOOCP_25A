using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7
{
    public class Person
    {
        public string Name
        {
            get; set;
        }
        public string Address
        {
            get; set;
        }
        public string Mobile
        {
            get; set;
        }
        int Id
        {
            get; set;
        }
        public string Eat(string foodType)
        {
            return "Eats " + foodType;
        }
    }
}
