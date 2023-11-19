using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;

namespace Tyuiu.BeketovVN.Sprint5.Task2.V21.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"D:\Project\С#\sprint\Tyuiu.BeketovVN.Sprint5\Tyuiu.BeketovVN.Sprint5.Task2.V21\bin\Debug\OutPutFileTask2.csv";

            FileInfo fileinfo = new FileInfo(path);
            bool fileexists = fileinfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileexists);
        }
    }
}