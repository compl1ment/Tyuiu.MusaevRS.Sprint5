using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.MusaevRS.Sprint5.Task3.V11.Lib;

namespace Tyuiu.MusaevRS.Sprint5.Task3.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Users\rumu2\source\repos\Tyuiu.MusaevRS.Sprint5\Tyuiu.MusaevRS.Sprint5.Task2.V11\bin\Debug\OutPutFileTask3.bin";
            FileInfo fileInfo = new FileInfo(path);
            bool FileExist = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, FileExist);

        }
    }
}
