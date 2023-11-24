using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.MusaevRS.Sprint5.Task7.V2.Lib;
using System.IO;

namespace Tyuiu.MusaevRS.Sprint5.Task7.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Users\rumu2\source\repos\Tyuiu.MusaevRS.Sprint5\Tyuiu.MusaevRS.Sprint5.Task7.V2\bin\Debug\OutPutDataFileTask7V2.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool FileExist = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, FileExist);

        }
    }
}
