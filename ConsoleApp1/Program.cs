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
            int[,] array = { { -9, 10, 2 }, { 4, -8, 1 }, { 5, 3, -6 } };
            int rowSum = 0;

            for (int j = 0; j < array.GetLength(1);j++)
            {
                rowSum -= array[2, j];
                Console.WriteLine(array[2, j]);

            }
            File.WriteAllText("OutPutFileTask2.csv", rowSum.ToString());
            Console.WriteLine(rowSum);
            Console.ReadKey();
        }

    }
}
