﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALXCourseHomework
{
    public class Homework3Test
    {
        public static void Run()
        {

            int a = 3;
            int b = 6;
            int c = 15;
            double d = ((double)(a ^ b) / 2) % c;
            Console.WriteLine("Wynik: " + d);
            d = d + 5;
            if (d > a)
            {
                Console.WriteLine("A jest mniejsze od wyniku");

            }
            else
            {
                Console.WriteLine("A jest większe od wyniku");
            }
        }
    }
    public class demorgan
    {
        public static void Run()
        {
            bool a = true;
            bool b = false;
            bool c = true;
            if (!a || !b || !c)
            {
                Console.WriteLine("Wszystkie parametry muszą być spełnione");
            }
            if (!(a && b && c))
            {
                Console.WriteLine("Wszystkie parametry są spełnione");
            }

        }
    }
}
