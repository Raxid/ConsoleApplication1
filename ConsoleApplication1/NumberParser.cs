using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class NumberParser
    {
        public void ParseNumbers(string[] split, List<int> numberList)
        {
            foreach (var item in split)//foreach C#
            {
                numberList.Add(Int32.Parse(item));
            }
        }
    }
}
