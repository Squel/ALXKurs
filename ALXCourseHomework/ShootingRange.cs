using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ALXCourseHomework.Classes;

namespace ALXCourseHomework
{
    public class ShootingRange
    {
        public ShootingRange()
        {

        }
        public static void Run()
        {
            Console.WriteLine("Welcome to new Shooting Range in Warsaw");
    
            bool czytaj_znak = true;
            List<GunWithBullets> guns;
            while (czytaj_znak)
            {
                Wyswietl_menu();
                var x = Console.ReadLine();

                switch (x)
                {
                    case "1":
                        guns = ChooseWeapons();
                        PrintRecipt(guns);
                        break;
                    case "2":
                        break;
                    case "3":
                        czytaj_znak = false;
                        break;
                    default:
                        break;
                }   
            }
            
        }

        private static void Wyswietl_menu()
        {
            Console.Clear();
            Console.WriteLine("Choose option form menu:");
            Console.WriteLine("1. Choose Weapon");
            Console.WriteLine("2. Choose day");
            Console.WriteLine("3. Koniec");
        }

        static List<Guns> weapons = new List<Guns>()
        {
            new Guns("Shootgun", 12.25m ),
            new Guns("UZI", 8.34m ),
            new Guns("Beretta", 5.50m ),
            new Guns("Colt", 9.64m ),
            new Guns("H&K", 10.65m ),

        };


        private static GunWithBullets ChooseSingleWeapon()
        {
            Console.WriteLine("Choose from avalibility weapons");

            for (int i = 0; i < weapons.Count; i++)
            {

                var it = weapons[i];
                Console.WriteLine($"{i}. {it.Name} bullet price {it.BulletPrice} PLN");
            }
            Guns selectedWeapon;
            while (true)
            {
                Console.Write("Choose weapon: ");
                var line = Console.ReadLine();
                if (int.TryParse(line, out int weapon) && weapon >= 0 && weapon < weapons.Count)
                {
                    selectedWeapon = weapons[weapon];
                    break;
                }

            }



            Console.WriteLine("How many bullets needs ?");
            int bullets;
            while (true)
            {
                Console.Write("How many bullets: ");
                var line = Console.ReadLine();
                if (int.TryParse(line, out bullets) && bullets >= 0)
                {
                   break;
                }

            }

            var selectedItem = new GunWithBullets(selectedWeapon, bullets);
            Console.WriteLine($"Łaczna cena amunicji {selectedItem.GetPrice()}");
            return selectedItem;
        }
        private static void PrintRecipt(List<GunWithBullets> items)
        {
            var streamWriter = new StreamWriter( Path.Combine( AppDomain.CurrentDomain.BaseDirectory , Path.DirectorySeparatorChar.ToString(),  "last-recipt.txt"));

            streamWriter.WriteLine("Shooting Range in Warsaw");
            streamWriter.WriteLine("========================");
            streamWriter.WriteLine("Selected guns:");
            decimal total = 0;
            foreach(var gun in items)
            {
                total += gun.GetPrice();
                streamWriter.WriteLine($"{gun.Gun.Name} no of bullets {gun.NoOfBullets} [{gun.Gun.BulletPrice}] price: {gun.GetPrice()}");
            }
            streamWriter.WriteLine("========================");

            streamWriter.WriteLine($"Total price: {total}");



        }
        private static List<GunWithBullets> ChooseWeapons()
        {
            List<GunWithBullets> guns = new List<GunWithBullets>();
            guns.Add(ChooseSingleWeapon());

            while (true)
            {
                Console.WriteLine("Do you wont to choose another weapons (Y/N)?: ");
                var a = Console.ReadLine();
                if (a.Equals("N", StringComparison.CurrentCultureIgnoreCase))
                {
                    break;
                }
                guns.Add(ChooseSingleWeapon());

            }

            decimal total = 0;

            foreach(var gun in guns)
            {

                total += gun.GetPrice();
            }
            Console.WriteLine($"Total price {total}");
            Console.ReadKey();

            return guns;
        }

        
    }
}
