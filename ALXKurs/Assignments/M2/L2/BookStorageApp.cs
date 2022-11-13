using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using static ALXKurs.Assignments.M2.L2.BookStorageService;

namespace ALXKurs.Assignments.M2.L2
{
    public class BookStorageApp
    {
        List<char> ValidChars;
        public BookStorageApp()
        {
            ValidChars = new List<char>();
            ValidChars.Add('1');
            ValidChars.Add('2');
            ValidChars.Add('3');
            
        }
        public void Run()
        {
            
            Console.WriteLine("Magazyn ksiazek ");
            Console.WriteLine("1. Dodaj ksiazke");
            Console.WriteLine("2. klasyfikuj ksiazke");
            Console.WriteLine("3. Wyjdz z programu");
            var x = Console.ReadKey();
            while (ValidOperation(x.KeyChar))
            {
                ChoseMenu(x.KeyChar);
                Console.WriteLine("Magazyn ksiazek ");
                Console.WriteLine("1. Dodaj ksiazke");
                Console.WriteLine("2. klasyfikuj ksiazke");
                Console.WriteLine("3. Wyjdz z programu");
                x = Console.ReadKey();
            }   
        }

        private bool ValidOperation(char operationCharacter)
        {
            return ValidChars.Contains(operationCharacter);
        }
        private void ChoseMenu(char opertaionChar)
        {
            switch (opertaionChar)
            {
                case '1':
                    var bookStorageService = new BookStorageService();
                    var book = bookStorageService.AddBook();
                    break;
                case '2':
                    
                    break;
                default:
                    Console.WriteLine("Koniec.");
                    break;
            }
            }
    }
}
