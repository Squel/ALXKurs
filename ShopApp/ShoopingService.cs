using ShopApp.Models;
using System.ComponentModel;

namespace ShopApp
{
    public class ShoopingService
    {
        public ShoopingService()
        {
        }
        public static void Run()
        {
            List<ShopingCart> basket = new();
            bool read_mark = true;

            while (read_mark)
            {
                Products.Show_Menu();
                var x = Console.ReadLine();

                switch (x)
                {
                    case "1":
                        basket = ChooseItems();
                        break;
                    case "2":
                        PrintRecipt(basket);
                        basket.Clear();
                        break;
                    case "3":
                        read_mark = false;
                        break;
                    default:
                        break;
                }
            }
        }
    

    static List<Products> product = new List<Products>()
        {
            new Products("Apple", 12.25m),
            new Products("Banana", 8.34m),
            new Products("Milk", 5.50m),
            new Products("Breed", 9.64m),
            new Products("Butter", 10.65m),
        };

    private static ShopingCart ChooseSingleItem()
    {
        Console.WriteLine("Choose from avalibility products");
        for (int i = 0; i < product.Count; i++)
        {
            var it = product[i];
            Console.WriteLine($"{i}. {it.ProductName} price {it.Price} PLN");
        }
        Products selectedItem;
        while (true)
        {
            Console.Write("Choose weapon: ");
            var line = Console.ReadLine();
            if (int.TryParse(line, out int products) && products >= 0 && products < product.Count)
            {
                selectedItem = product[products];
                break;
            }
        }
        int numberItems;
        while (true)
        {
            Console.Write("How many: ");
            var line = Console.ReadLine();
            if (int.TryParse(line, out numberItems) && numberItems >= 0)
            {
                break;
            }
            else
            {
                Console.WriteLine("Incorrect number");
            }
        }
        var selectedItems = new ShopingCart(selectedItem, numberItems);
        Console.WriteLine($"Cost of all items in basket {selectedItems.GetPrice()}");
        return selectedItems;
    }

    private static List<ShopingCart> ChooseItems()
        {
            List<ShopingCart> basket = new List<ShopingCart>();
            basket.Add(ChooseSingleItem());
            while (true)
            {
                Console.WriteLine("Do you wont to choose another item (Y/N)?: ");
                var a = Console.ReadLine();
                if (a.Equals("N", StringComparison.CurrentCultureIgnoreCase))
                {
                    break;
                }
                basket.Add(ChooseSingleItem());
            }
            decimal total = 0;
            foreach (var bask in basket)
            {
                total += bask.GetPrice();
            }
            Console.WriteLine($"Total price {total}");
            Console.ReadKey();
            return basket;
        }

        private static void PrintRecipt(List<ShopingCart> items)
        {
            Console.WriteLine();
            Console.WriteLine("Shoping list");
            Console.WriteLine("========================");
            decimal total = 0;

            if (items.Count() > 0)
            {
                Console.WriteLine("Selected items:");
                foreach (var bask in items)
                {
                    total += bask.GetPrice();
                    Console.WriteLine($"{bask.Products.ProductName} no of item {bask.NoOfProducts} [{bask.Products.Price}] price: {bask.GetPrice()}");
                }
            }
            Console.WriteLine("========================");
            Console.WriteLine($"Total price netto: {total}");
            decimal Brutto = total;
            decimal Vat = 1.23m;
            Brutto = Decimal.Multiply(total, Vat);
            Console.WriteLine($"Total price brutto: {Math.Round(Brutto, 2)}");
            Console.ReadKey();
        }
    }
}
