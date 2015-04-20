using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApplication1
{
   public class Calculator
    {
       public static int Main(string[] args)
       {
           return 0;
       }
        public static int Add(string Stream)
        {
            string stream = Stream;
            string num1,num2;
            string [] split = stream.Split(new Char[] { ' ', ' ' });            
            num1 = split[0];
            num2 = split[2];
            if (num1 == "" && num2 == "")
            {
                return 0;
            }
            return Int32.Parse(num1)+ Int32.Parse(num2);
        }
    }
}
