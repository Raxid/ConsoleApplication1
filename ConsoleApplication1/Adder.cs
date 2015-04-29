using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Adder
    {
       List<int> NumberList { get; set; }
        private readonly NumberParser Parser;
        private readonly Input SplitedNumbers;

        public Adder()
        {
            Parser = new NumberParser();
            NumberList = new List<int>();
            SplitedNumbers = new Input();
        }

        public int Add(string stream)
        {
           
            if (String.IsNullOrEmpty(stream)) return 0;

            string[] split = SplitedNumbers.SplitInput(stream);
            Parser.ParseNumbers(split, NumberList);
            return NumberList.Sum();//LINQ
        }
    }
}
