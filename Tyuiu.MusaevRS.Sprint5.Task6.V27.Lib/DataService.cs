using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;

namespace Tyuiu.MusaevRS.Sprint5.Task6.V27.Lib
{
    public class DataService : ISprint5Task6V27
    {
        public int LoadFromDataFile(string path)
        {
            using (StreamReader reader = new StreamReader(path))
            {
                List<string> chisla = new List<string>();
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string content = "";
                    foreach (char c in line)
                    {
                        if (char.IsDigit(c))
                        {
                            content += c;
                        }
                        if (char.IsLetter(c))
                        {
                            continue;
                        }
                        if (char.IsWhiteSpace(c))
                        {
                            chisla.Add(content);
                            content = "";
                        }           
                    }
                }
                int cout = 0;
                for (int i = 0;i < chisla.Count; i++)
                {
                    if (chisla[i].Length == 3)
                    {
                        cout++;
                    }
                }
                return cout;
            }            
        }
        
    }
}
