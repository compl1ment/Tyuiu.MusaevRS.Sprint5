using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Tyuiu.MusaevRS.Sprint5.Task1.V8.Lib;

namespace Tyuiu.MusaevRS.Sprint5.Task1.V8
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            int startValue = -5;
            int stopValue = 5;
            Console.Title = "Спринт #5 | Выполнил Мусаев Р.Ш. | ПКТб-23-2";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту                 *");
            Console.WriteLine("* Задание №1                                                              *");
            Console.WriteLine("* Вариант №8                                                              *");
            Console.WriteLine("* Выполнил: Мусаев Руслан Шамхалович | ПКТб-23-2                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Дана функция, произвести табулирование на заданном диапазоне            *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine(" startValue = " + startValue);
            Console.WriteLine(" stopValue = " + stopValue);
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Результат:                                                              *");
            string res = ds.SaveToFileTextData(startValue, stopValue);
            Console.WriteLine("Файл " + res);
            Console.WriteLine("Создан!");
            Console.WriteLine("***************************************************************************");
            Console.ReadKey();
        }
    }
}
