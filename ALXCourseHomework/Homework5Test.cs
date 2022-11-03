using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALXCourseHomework
{
    internal class Homework5Test
    {
        public double x;
        public double y;
        public double z;
        public static void Run()
        {
            Console.WriteLine("Kwota pierwszego towaru: ");
            var x = double.Parse(Console.ReadLine());
            Console.WriteLine("Kwota drugiego towaru: ");
            var y = double.Parse(Console.ReadLine());
            var z = (x + y);
            Console.WriteLine($"Suma zakupionych towarów: {z}");
            
            
            switch (z)
            {
                case > 100:
                    Console.WriteLine("Udzielono 15% rabatu");
                    z = (z * (1 - 0.15));
                    Double dz = Math.Round((Double)z, 2);
                    Console.WriteLine($"Kwota do zapłaty: {dz}");
                    break;
                case <= 100 and >60:
                    Console.WriteLine("Udzielono 5% rabatu");
                    z = (z * (1 - 0.05));
                    Double cz = Math.Round((Double)z, 2);
                    Console.WriteLine($"Kwota do zapłaty: {cz}");
                    break;
               default:
                    Console.WriteLine("Kwota nie podlega rabatowi");
                    Console.WriteLine($"Kwota do zapłaty: {z}");
                    break;
            }
            
            
        }
    }
}
