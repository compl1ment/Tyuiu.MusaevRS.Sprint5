using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.MusaevRS.Sprint5.Task5.V16.Lib;

namespace Tyuiu.MusaevRS.Sprint5.Task5.V16.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1() 
        {
            string path = @"C:\DataSprint5\InPutDataFileTask5V16.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool wait = true;
            bool FileExist = fileInfo.Exists;
            Assert.AreEqual(wait, FileExist);
        }
    }
}
