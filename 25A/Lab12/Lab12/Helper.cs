using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12
{
   public class Helper
    {
        public bool CheckPassword(string pass,string cpass)
        {
            if (pass == cpass)
                return true;
            else
                return false;
        }
        public bool CheckEmail(string email)
        {
            if (email.Contains("@"))
                return true;
            else
                return false;
        }
    }
}
