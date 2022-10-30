using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALXCalculator
{
    public class Calculator1
    {
        public void Run1()
        {
            Console.WriteLine("Running calculator.....");
            
            
            Console.Write("Podaj pierwsza liczbe: ");
            var x = double.Parse(Console.ReadLine());
            Console.Write("Podaj druga liczbe: ");
            var y = double.Parse(Console.ReadLine());
            Console.WriteLine("Wybierz dzialanie: ");
            Console.WriteLine("1. Dodawanie ");
            Console.WriteLine("2. Mnozenie ");
            Console.WriteLine("3. Odejmowanie ");
            Console.WriteLine("4. dzielenie ");
            var z = Int32.Parse (Console.ReadLine());
            if  {
                Console.WriteLine($"{x} + {y} = {Add(x, y)}");
            }
            if  {

            }
                   
            Console.WriteLine($"{x} * {y} = {Multiply(x,y)}");        
            Console.WriteLine($"{x} - {y} = {Substract(x,y)}");        
            Console.WriteLine($"{x} / {y} = {Divide(x,y)}");        
        }
        private double Add(double x, double y)
        {
            return x + y;
        }

        private double Multiply(double x, double y)
        {
            return x * y;
        }

        private double Substract (double x, double y)
        {
            return x - y;
        }
        private double Divide(double x, double y)
        {
            return x / y;
        }
    }
}
