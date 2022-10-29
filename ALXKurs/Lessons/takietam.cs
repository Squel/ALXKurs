using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALXKurs.Lessons
{
    public class takietam
    {
        public static void takie()
        {
            string a, b;
            Console.WriteLine("Podaj imię:");
            a = Console.ReadLine();
            Console.WriteLine("Podaj nazwisko:");
            b = Console.ReadLine();
            Console.WriteLine("Witaj " + a + " " + b);
            Console.ReadKey();
        }
    }
}
