using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10
{
    public class Calcutor
    {
        public static int Add(int a,int b)
        {
            try
            {
                throw new Exception("It is manual error");
                return a + b;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
