using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALXCourseHomework.Classes
{
    public class ShootingRangeServices
    { 
        public static void Show_menu()
        {
            Console.Clear();
            Console.WriteLine("Welcome to new Shooting Range in Warsaw");
            Console.WriteLine("Choose option form menu:");
            Console.WriteLine("1. Choose Weapon");
            Console.WriteLine("2. Choose track");
            Console.WriteLine("3. Summary");
            Console.WriteLine("4. Quit");
        }
       
        
    }
}
