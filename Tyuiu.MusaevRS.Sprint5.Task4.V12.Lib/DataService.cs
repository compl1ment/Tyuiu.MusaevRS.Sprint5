using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.MusaevRS.Sprint5.Task4.V12.Lib
{
    public class DataService : ISprint5Task4V12
    {
        public double LoadFromDataFile(string path)
        {
            string strX = File.ReadAllText(path);
            double ch = Convert.ToDouble(strX);
            double res = Math.Round(Math.Cos(Math.Pow(ch, 3)) + (ch / 2),3);
            return res;
        }
    }
}
