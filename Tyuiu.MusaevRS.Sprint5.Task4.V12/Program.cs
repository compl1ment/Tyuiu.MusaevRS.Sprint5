using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Tyuiu.MusaevRS.Sprint5.Task4.V12.Lib;

namespace Tyuiu.MusaevRS.Sprint5.Task4.V12
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            string path = $@"{Directory.GetCurrentDirectory()}\InPutDataFileTask4V12.txt";
            Console.Title = "Спринт #5 | Выполнил Мусаев Р.Ш. | ПКТб-23-2";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Потоковый метод записи данных в бинарный файл                     *");
            Console.WriteLine("* Задание №4                                                              *");
            Console.WriteLine("* Вариант №12                                                             *");
            Console.WriteLine("* Выполнил: Мусаев Руслан Шамхалович | ПКТб-23-2                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Вычислить значение по формуле                                           *");
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
