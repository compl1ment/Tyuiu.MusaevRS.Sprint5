using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.MusaevRS.Sprint5.Task7.V2.Lib
{
    public class DataService : ISprint5Task7V2
    {
        public string LoadDataAndSave(string path)
        {
            string pathSaveFile = $@"{Directory.GetCurrentDirectory()}\OutPutDataFileTask7V2.txt";

            List<int> chisla = new List<int> { '1', '2', '3','4','5','6','7','8','9','0'};

            FileInfo fileInfo = new FileInfo(pathSaveFile);
            bool FileExist = fileInfo.Exists;
            if (FileExist)
            {
                File.Delete(pathSaveFile);
            }
            string content = "";
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    foreach (char c in line)
                    {
                        if (char.IsDigit(c))
                        {
                            content += "#";
                        }
                        else
                        {
                            content += c;
                        }
                    }
                }
            }
            File.AppendAllText(pathSaveFile, content);
            return pathSaveFile;
        }
    }
}
