using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.GurevskayaVE.Sprint3.Task1.V24.Lib;

namespace Tyuiu.GurevskayaVE.Sprint3.Task1.V24
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #3 | Выполнила: Гурьевская В.Е. | ПКТб-23-2";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Оператор while                                                    *");
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант #24                                                             *");
            Console.WriteLine("* Выполнила: Гурьевская В.Е. | ПКТб-23-2                                  *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу используя цикл while, которая вычисляет сумму        *");
            Console.WriteLine("* ряда по формуле, при х = 5                                              *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("*     12                                                                  *");
            Console.WriteLine("* p = ∑ (2/(6+x^i))^i                                                     *");
            Console.WriteLine("*   i = 1                                                                 *");
            Console.WriteLine("***************************************************************************");

            DataService ds = new DataService();

            double value = 5;
            int startValue = 1;
            int stopValue = 12;

            Console.WriteLine("Переменная = " + value);
            Console.WriteLine("Старт шага = " + startValue);
            Console.WriteLine("Конец шага = " + stopValue);

            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            double res = ds.GetMultiplySeries(value, startValue, stopValue);
            Console.WriteLine("Результат: " + res);

            Console.ReadKey();
        }
    }
}
