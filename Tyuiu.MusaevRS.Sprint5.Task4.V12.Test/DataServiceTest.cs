using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.MusaevRS.Sprint5.Task4.V12.Lib;

namespace Tyuiu.MusaevRS.Sprint5.Task4.V12.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Users\rumu2\source\repos\Tyuiu.MusaevRS.Sprint5\Tyuiu.MusaevRS.Sprint5.Task4.V12\bin\Debug\InPutDataFileTask4V12.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool FileExist = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, FileExist);
        }
    }
}
