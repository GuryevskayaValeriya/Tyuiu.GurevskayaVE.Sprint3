﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.GurevskayaVE.Sprint3.Task5.V29.Lib
{
    public class DataService : ISprint3Task5V29
    {
        public double GetSumSumSeries(int x, int startValue1, int startValue2, int stopValue1, int stopValue2)
        {
            double sum = 0;
            int i, k;
            for (i = startValue1; i <= stopValue1; i++) 
            {
                for (k = startValue2; k <= stopValue2; k++)
                {
                    sum = sum + (((x / k) + Math.Sin(x)));
                }
            }
            return Math.Round(sum, 3);
        }
    }
}
