using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALXCourseHomework
{
    public class Homework4Test
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
            Console.WriteLine($"Suma zakupionych towarów: {x + y}");
            if (z >= 100)
            {
                Console.WriteLine("Udzielono 15% rabatu");
                z = (z * (1-0.15));
                Console.WriteLine($"Kwota do zapłaty: {z}");
            }
            else if (z <100 && z >= 60)
            {
                Console.WriteLine("Udzielono 5% rabatu");
                z = (z * (1 - 0.05));
                Console.WriteLine($"Kwota do zapłaty: {z}");
            }
            else
            {
                Console.WriteLine("Kwota nie podlega rabatowi");
                Console.WriteLine($"Kwota do zapłaty: {z}");
            }
        }
    }
}
