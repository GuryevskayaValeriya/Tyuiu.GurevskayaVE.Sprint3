﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.GurevskayaVE.Sprint3.Task6.V21.Lib;

namespace Tyuiu.GurevskayaVE.Sprint3.Task6.V21
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #3 | Выполнила: Гурьевская В.Е. | ПКТб-23-2";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Обработка целочисленной информации                                *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #21                                                             *");
            Console.WriteLine("* Выполнила: Гурьевская В.Е. | ПКТб-23-2                                  *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Напишите программу, которая ищет среди целых чисел,                     *");
            Console.WriteLine("* принадлежащих числовому отрезку [19, 30] сумму всех делителей           *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");

            DataService ds = new DataService();

            
            int startValue = 19;
            int stopValue = 30;
            


            
            Console.WriteLine("Начало отрезка = " + startValue);
            Console.WriteLine("Конец отрезка = " + stopValue);
            


            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");


            Console.WriteLine("Сумма делителей = " + ds.GetSumTheDivisors(startValue, stopValue));
                
            Console.ReadKey();
        }
    }
}
