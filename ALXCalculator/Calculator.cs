using ALXCalculator.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALXCalculator
{
    public class Calculator : ICalculator
    {
        List<char> ValidChars;
        
        public Calculator()
        {
            ValidChars = new List<char>();
            ValidChars.Add('+');
            ValidChars.Add('-');
            ValidChars.Add('*');
            ValidChars.Add('/');
        }
        public void Run()
        {
            Console.WriteLine("Running calculator.....");
            Console.WriteLine("Wybierz operator: +, -, *, /");
            Console.Write("Podaj operację: \n");
            var operationCharacterInfo =  Console.ReadKey();
           
            while (ValidOperation(operationCharacterInfo.KeyChar))
            {
                
                Console.WriteLine(" ");
                Console.Write("Podaj pierwsza liczbe: ");
                var x = double.Parse(Console.ReadLine());
                Console.Write("Podaj druga liczbe: ");
                var y = double.Parse(Console.ReadLine());
                Console.Write("Podaj operację: \n");
                PerformOperation(operationCharacterInfo.KeyChar, x, y);
                Console.Write("Podaj operację: \n");
                operationCharacterInfo = Console.ReadKey();
            }
        }

        private bool ValidOperation(char operationCharacter)
        {
            return ValidChars.Contains(operationCharacter);

        }
        private void PerformOperation (char opertaionChar,double x, double y)
        {
            switch (opertaionChar)
            {
                case '+':
                    Console.WriteLine($"{x} + {y} = {Add(x, y)}");
                    break;
                    case '-':
                    Console.WriteLine($"{x} - {y} = {Substract(x, y)}");
                    break;
                case '*':
                    Console.WriteLine($"{x} * {y} = {Multiply(x, y)}");
                    break;
                case '/':
                    Console.WriteLine($"{x} / {y} = {Divide(x, y)}");
                    break;
                default:
                    Console.WriteLine("Invalid operation...");
                    break;
            }
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
