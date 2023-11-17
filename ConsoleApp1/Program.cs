using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string outputFile = "OutPutFileTask3.bin";
            double x10 = -2;
            double result10 = 2 * Math.Pow(x10, 2) + 3*x10 - 4; ;
            using (BinaryWriter writer = new BinaryWriter(File.Open(outputFile, FileMode.Append)))
            {
                Console.WriteLine(result10);
            }
            Console.ReadKey();
        }

    }
}
