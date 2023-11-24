using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.MusaevRS.Sprint5.Task7.V2.Lib;
using System.IO;

namespace Tyuiu.MusaevRS.Sprint5.Task7.V2
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\DataSprint5\InPutDataFileTask7V2.txt";
            DataService ds = new DataService();
            string pathSaveFile = $@"{Directory.GetCurrentDirectory()}\OutPutDataFileTask7V2.txt";
            pathSaveFile = ds.LoadDataAndSave(path);
            Console.ReadKey();
        }
    }
}
