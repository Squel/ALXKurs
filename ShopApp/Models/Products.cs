namespace ShopApp.Models
{
    public class Products
    {
        public string ProductName { get; set; }
        public decimal Price { get; set; }


        public Products(string productName, decimal price)
        {
            ProductName = productName;
            Price = price;
        }

        public static void Show_Menu()
        {
            Console.Clear();
            Console.WriteLine("Welcome to store");
            Console.WriteLine("Choose option form menu:");
            Console.WriteLine("1. Add products");
            Console.WriteLine("2. Show Basket");
            Console.WriteLine("3. Quit");
        }
    }
    
}
