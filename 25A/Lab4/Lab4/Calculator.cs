using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    public class Calculator
    {
        public int Operation(string opType,int a,int b)
        {
            int result = 0;
            /*switch(opType)
            {
                case "+":
                    result= a + b;
                    break;
                case "-":
                    result= a - b;
                    break;
                case "*":
                    result = a * b;
                    break;
                default:
                    break;
            }*/
            if(opType=="+")
            {
                result = a + b;
            }
            else if(opType=="-")
            {
                result = a - b;
            }
            else
            {
                result = a * b;
            }
            return result;
        }
    }
}
