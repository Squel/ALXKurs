

namespace ALXKurs.Assignments.M2.L2
{
    public class BookStorageService
    {
        public Book AddBook()
        {
            Console.WriteLine("Podaj tytul: ");
            string TBook = Console.ReadLine();
            Console.WriteLine("Podaj autora: ");
            string Autor = Console.ReadLine();
            Console.WriteLine("Podaj rodzaj: Horror/SC-FI/Przygodowa/Historyczna ");
            string GBook = Console.ReadLine();
            Console.WriteLine("Podaj rok wydania: ");
            int YBook = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Oprawa: (T)Twarda/(M)Miekka");
            string HBook = Console.ReadLine();

            var book = new Book();
            return book;
        }

        public void PresentBook()
        {
            List<string> listbook = new List<string>();
        }
    }

}
