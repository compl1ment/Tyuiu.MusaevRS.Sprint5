using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            double x8 = -1;
            double result8 = 2 * Math.Pow(x8, 3) + 5 * Math.Pow(x8, 2) - 3 * x8 + 1;
            Console.WriteLine(result8);
            Console.ReadKey();
        }
    }
}
