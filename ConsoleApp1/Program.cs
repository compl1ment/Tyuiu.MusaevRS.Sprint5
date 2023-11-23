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
            string content = File.ReadAllText(@"C:\DataSprint5\InPutDataFileTask5V16.txt");
            string newContent = "";
            foreach (char c in content)
            {
                if (!char.IsUpper(c))
                {
                    newContent += c;
                }    
            }
            File.WriteAllText(@"C:\DataSprint5\InPutDataFileTask5V16.txt", newContent);
            Console.WriteLine(String.Join("\n", newContent));
            Console.ReadKey();
        }

    }
}
