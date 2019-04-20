using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8
{
    public class Laptop
    {
        int Id;
        public string Color
        {
            get; set;
        }
        public string MadeYear
        {
            get; set;
        }
        public Laptop(int Id)
        {
            this.Id = Id;
        }
        public string GetInfo()
        {
            return Color + MadeYear + Id.ToString();
        }
    }
}
