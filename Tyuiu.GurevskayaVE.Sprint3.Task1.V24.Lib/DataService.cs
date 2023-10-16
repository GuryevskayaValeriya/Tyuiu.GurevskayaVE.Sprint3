using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.GurevskayaVE.Sprint3.Task1.V24.Lib
{
    public class DataService : ISprint3Task1V24
    {
        public double GetMultiplySeries(double value)
        {
            
            int i = 1;
            
            double res = 0;
            while(i != 12)
            {
                res += Math.Pow(2 / (Math.Pow(value, i) + 6), i);
                
                i++;
            }
            return Math.Round(res, 3);
        }
    }
}
