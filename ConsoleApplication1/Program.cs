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
        //Console.Write("Please,put some numbers like a [1,1]");
        //string date = Console.ReadLine();
        //Console.Write("Result: %1", Add(date));
        //Console.ReadKey();
        return 0;
    }
    public static int Add(string stream)
    {
        if (String.IsNullOrEmpty(stream)) return 0;
        string [] split = stream.Split(',');
        List<int> numberList = new List<int>();
        foreach (var item in split)//foreach C#
        {
            numberList.Add(Int32.Parse(item));
        }
        numberList.All(item => Int32.MinValue);
        return numberList.Sum(number => number);//LINQ
    }
}
}
