using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALXKurs.Lessons.M2.L1
{
    public class L1Loops
    {
        public static void RunForeach()
        {
            List<string> names = new List<string>();
            names.Add("Adrian");
            names.Add("Michal");
            names.Add("Tomasz");
            names.Add("Zbychu");
            names.Add("Zdzichu");

            foreach (string name in names)
            {
                name.ToLower();
                Console.WriteLine(name.ToLower() + " kursant");
                Console.WriteLine(name);
            }
        }
        public static void RunFor()
        {
            int[] numbers = new int[12] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0, 13, 55 };

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write(numbers[i] + " ");
            }
            Console.WriteLine();

            for (int i = 0; i < numbers.Length; i+=2)
            {
                Console.Write(numbers[i] + " ");
            }
            Console.WriteLine();

            for (int i  = numbers.Length - 1; i >= 0; i--)
            {
                Console.Write(numbers[i] + " ");
            }
            Console.WriteLine();

            for (int i = numbers.Length - 1; i >= 0; i--)
            {
                numbers[i] = numbers[i] % 2;
                Console.Write(numbers[i] + " ");
            }
            Console.WriteLine();
        }

        public static void RunWhile()
        {
            char c = 'q';
            while (c != 'n')
            {
                Console.WriteLine("Still in loop");
                Console.WriteLine("Write Character: ");
                c = Console.ReadKey().KeyChar;
            }
            Console.WriteLine("Outside the loop");

            string numberFromKeyboard = "0";
            while (Int32.Parse(numberFromKeyboard) < 100000)
            {
                Console.WriteLine("Still in loop");
                Console.WriteLine("Write number: ");
                numberFromKeyboard = Console.ReadLine();
                Console.WriteLine();
            }
            Console.WriteLine("Outside the loop");
        }

        public static void RunWhileDo()
        {
            char c = 'q';
            {
                Console.WriteLine("Still in loop");
                Console.WriteLine("Write Character: ");
                c = Console.ReadKey().KeyChar;
                Console.WriteLine();
            } while (c != 'n')
                Console.WriteLine("Outside the loop");
        }

        public static void RunWhile2()
        {
            //int[] numbers = new int[12] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0, 13, 55 };
            //int iterator = 0;
            while (true)
            {
                var rnd = new Random();
                var number = rnd.Next(0, 9);
                var number1 = rnd.Next(0, 9);


                Console.Write(number1.ToString() + number.ToString());
               
            }
            
        }
    }
}
