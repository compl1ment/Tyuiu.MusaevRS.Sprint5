using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Tyuiu.MusaevRS.Sprint5.Task6.V27.Lib;

namespace Tyuiu.MusaevRS.Sprint5.Task6.V27
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            string path = @"C:\DataSprint5\InPutDataFileTask6V27.txt";
            Console.Title = "Спринт #5 | Выполнил Мусаев Р.Ш. | ПКТб-23-2";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Обработка текстовых файлов                                        *");
            Console.WriteLine("* Задание №6                                                              *");
            Console.WriteLine("* Вариант №27                                                             *");
            Console.WriteLine("* Выполнил: Мусаев Руслан Шамхалович | ПКТб-23-2                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Найти количество трехзначных чисел в заданной строке                    *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine(" Данные находятся в файле : " + path);
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Результат:                                                              *");
            double res = ds.LoadFromDataFile(path);
            Console.WriteLine(res);
            Console.WriteLine("***************************************************************************");                     
            Console.ReadKey();


        }
    }
}
