﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.GurevskayaVE.Sprint3.Task2.V25.Lib;

namespace Tyuiu.GurevskayaVE.Sprint3.Task2.V25.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod2()
        {
            DataService ds = new DataService();

            double value = 5;
            int startValue = 1;
            int stopValue = 13;

            double res = ds.GetSumSeries(value, startValue, stopValue);

            double wait = 16.016;

            Assert.AreEqual(wait, res);
        }
    }
}
