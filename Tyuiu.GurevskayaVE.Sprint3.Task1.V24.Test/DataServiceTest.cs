using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.GurevskayaVE.Sprint3.Task1.V24.Lib;


namespace Tyuiu.GurevskayaVE.Sprint3.Task1.V24.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            double x = 5;
            
            double res = ds.GetMultiplySeries(x);
            double wait = 0.186;
            Assert.AreEqual(wait, res);
        }
    }
}
