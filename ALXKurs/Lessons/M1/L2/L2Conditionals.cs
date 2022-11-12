using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALXKurs.Lessons.M1.L2
{
    public class L2Conditionals
    {
        public static void Run()
        {
            Console.Write("Podaj liczbę: ");
            var number = int.Parse(Console.ReadLine());


            Console.Write("Podaj limit dolny: ");
            var limit1 = int.Parse(Console.ReadLine());


            Console.Write("Podaj limit górny: ");
            var limit2 = int.Parse(Console.ReadLine());
            CheckBetwene(number, limit1, limit2);
        }

        private static void CheckIfNumberIsEven(int number)
        {
            if (number % 2 == 0)
            {
                Console.WriteLine($"Liczba {number} jest parzysta");
            }
            else
            {
                Console.WriteLine($"Liczba {number} jest nieparzysta");
            }
        }

        private static void CheckBetwene(int number, int limit1, int limit2)
        {
            if (number < limit1)
            {
                Console.WriteLine($"Liczba mniejsza niż {limit1}");
            }
            else if (number > limit2)
            {
                Console.WriteLine($"liczba jest większa niż {limit2}");

            }
            else
            {
                Console.WriteLine($"Liczba jest równa {limit1} albo {limit2}\nbądź jest w przedziale między {limit1} a {limit2}");
            }
        }
    }
}
