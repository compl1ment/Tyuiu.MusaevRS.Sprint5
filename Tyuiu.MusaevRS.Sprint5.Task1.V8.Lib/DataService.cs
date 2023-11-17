using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.MusaevRS.Sprint5.Task1.V8.Lib
{
    public class DataService : ISprint5Task1V8
    {
        public string SaveToFileTextData(int startValue, int stopValue)
        {
            string path = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask1.txt";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExist = fileInfo.Exists;

            if (fileExist)
            {
                File.Delete(path);
            }

            double y;
            string strY;
            for (int x = startValue; x <= stopValue; x++)
            {
                y = Math.Round(4 - 2*x + ((2 + Math.Cos(x))/(2 * x - 2)), 2);
                strY = Convert.ToString(y);

                if (x != stopValue)
                {
                    if (x != 1)
                    {
                        File.AppendAllText(path, strY + Environment.NewLine);
                    }
                    else
                    {
                        File.AppendAllText(path, "0" + Environment.NewLine);
                    }
                }
                else
                {
                    File.AppendAllText(path, strY);
                }
            }
            return path;
        }
    }
}
