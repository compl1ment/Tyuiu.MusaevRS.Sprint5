using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Tyuiu.MusaevRS.Sprint5.Task3.V11.Lib;

namespace Tyuiu.MusaevRS.Sprint5.Task3.V11
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            int x = 3;
            Console.Title = "Спринт #5 | Выполнил Мусаев Р.Ш. | ПКТб-23-2";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Потоковый метод записи данных в бинарный файл                     *");
            Console.WriteLine("* Задание №3                                                              *");
            Console.WriteLine("* Вариант №11                                                             *");
            Console.WriteLine("* Выполнил: Мусаев Руслан Шамхалович | ПКТб-23-2                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Дано выражение, вычислить его значение при x = 3                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine(" x = " + x);
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Результат:                                                              *");
            string res = ds.SaveToFileTextData(x);
            Console.WriteLine("Файл " + res);
            Console.WriteLine("Создан!");
            Console.WriteLine("***************************************************************************");
            Console.ReadKey();
        }
    }
}
