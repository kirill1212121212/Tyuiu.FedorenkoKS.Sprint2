using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.FedorenkoKS.Sprint2.Task2.V27.Lib;

namespace Tyuiu.FedorenkoKS.Sprint2.Task2.V27.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService dataService = new DataService();
            int x = 12, y = 13;
            bool res = dataService.CheckDotInShadedArea(x, y);
            Assert.IsTrue(res);
        }
    }
}