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
            string text = File.ReadAllText(@"C:\DataSprint5\Task0.txt");
            string[] strings = text.Split(',');
            List<string> oddNumbers = new List<string>();
            foreach(string str in strings)
            {
                if (int.TryParse(str.Trim(), out int number) && number % 3 == 0)
                {
                    oddNumbers.Add(str);
                }
            }
            File.WriteAllLines(@"C:\DataSprint5\Task0.txt", oddNumbers);
            Console.WriteLine(String.Join("\n", oddNumbers));
            Console.ReadKey();
        }

    }
}
