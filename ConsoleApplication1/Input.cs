using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Input {       
        public string[] SplitInput(string input)
        {
            return input.Split(',', '\n');
        }
    }
}
