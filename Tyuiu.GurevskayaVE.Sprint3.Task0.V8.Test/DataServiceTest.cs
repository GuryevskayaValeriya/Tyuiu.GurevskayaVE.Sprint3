using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.GurevskayaVE.Sprint3.Task0.V8.Lib;

namespace Tyuiu.GurevskayaVE.Sprint3.Task0.V8.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double value = 0.25;
            double res = ds.GetSumSeries(value);
            double wait = -0.654;
            Assert.AreEqual(wait, res);
        }
    }
}
