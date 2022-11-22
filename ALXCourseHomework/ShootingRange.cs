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
            bool read_mark= true;
            List<GunWithBullets> guns= new();
            List<TrackReservation> reservations = new();

            while (read_mark)
            {
                Show_menu();
                var x = Console.ReadLine();

                switch (x)
                {
                    case "1":
                        guns = ChooseWeapons();
                        PrintRecipt(guns);
                        break;
                    case "2":
                        reservations = ChooseTrack();
                        PrintRecipe1(reservations);
                        break;
                    case "3":
                        PrintRecipt2(guns, reservations);
                        guns.Clear();
                        reservations.Clear();
                        break;
                    case "4":
                        read_mark = false;
                        break;
                    default:
                        break;
                }   
            }   
        }

        private static void Show_menu()
        {
            Console.Clear();
            Console.WriteLine("Welcome to new Shooting Range in Warsaw");
            Console.WriteLine("Choose option form menu:");
            Console.WriteLine("1. Choose Weapon");
            Console.WriteLine("2. Choose track");
            Console.WriteLine("3. Summary");
            Console.WriteLine("4. Quit");
        }

        static List<Guns> weapons = new List<Guns>()
        {
            new Guns("Shootgun", 12.25m ),
            new Guns("UZI", 8.34m ),
            new Guns("Beretta", 5.50m ),
            new Guns("Colt", 9.64m ),
            new Guns("H&K", 10.65m ),

        };

        static List<Tracks> tracks = new List<Tracks>()
        {
            new Tracks("Track 1 - Short range", 25.50m),
            new Tracks("Track 2 - Long range", 40.50m),
            new Tracks("Track 3 - Regular", 20.00m),
            new Tracks("Track 4 - Regular", 20.00m),
            new Tracks("Track 5 - Regular", 20.00m),
            new Tracks("Track 6 - Regular", 20.00m),
            new Tracks("Track 7 - Urban city", 85.00m),
        };

        private static TrackReservation ChooseSingleTrack()
        {
            Console.WriteLine("Choose from avalibility tracks");
            for (int i = 0; i < tracks.Count; i++)
            {
                var it = tracks[i];
                Console.WriteLine($"{i}. {it.Track} track price {it.PriceOfTrack} PLN/30 Min.");
            }
            Tracks selectedTrack;
            while (true)
            {
                Console.Write("Choose from avalibility track: ");
                var line = Console.ReadLine();
                if (int.TryParse(line, out int track) && track >= 0 && track < tracks.Count)
                {
                    selectedTrack = tracks[track];
                    break;
                }
            }
            int timeTrack;
            while (true)
            {
                Console.WriteLine("The maximum track booking time is 12 hours (24 units)");
                Console.WriteLine("One unit corresponds to 30 minutes, when booking for 1 hour, enter 2 units.");
                Console.WriteLine("Please type how many units ?");
                var line = Console.ReadLine();
                if (int.TryParse(line, out timeTrack) && timeTrack >= 0 && timeTrack < 24)
                {  
                    break;
                }
                else
                {
                    Console.WriteLine("Incorrect unit");
                }
            }
            var selectedTime = new TrackReservation(selectedTrack, timeTrack);
            Console.WriteLine($"Cost of all tracks {selectedTime.GetPriceT()}");
            return selectedTime;
        }
    
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
            int bullets;
            while (true)
            {
                Console.Write("How many bullets: ");
                var line = Console.ReadLine();
                if (int.TryParse(line, out bullets) && bullets >= 0)
                {
                   break;
                }
                else
                {
                    Console.WriteLine("Incorrect number of bullets");
                }
            }
            var selectedItem = new GunWithBullets(selectedWeapon, bullets);
            Console.WriteLine($"Cost of all ammunitions {selectedItem.GetPrice()}");
            return selectedItem;
        }
       private static void PrintRecipt(List<GunWithBullets> items)
        {
           Console.WriteLine("");
            Console.WriteLine("Shooting Range in Warsaw");
            Console.WriteLine("========================");
            Console.WriteLine("Selected guns:");
            decimal total = 0;
            foreach(var gun in items)
            {
                total += gun.GetPrice();
                Console.WriteLine($"{gun.Gun.Name} no of bullets {gun.NoOfBullets} [{gun.Gun.BulletPrice}] price: {gun.GetPrice()}");
            }
            Console.WriteLine("========================");
            Console.WriteLine($"Total price: {total}");
            Console.ReadKey();   
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
        private static List<TrackReservation> ChooseTrack()
        {
            List<TrackReservation> tracks = new List<TrackReservation>();
            tracks.Add(ChooseSingleTrack());
            while (true)
            {
                Console.WriteLine("Do you wont to choose another track (Y/N)?: ");
                var a = Console.ReadLine();
                if (a.Equals("N", StringComparison.CurrentCultureIgnoreCase))
                {
                    break;
                }
                tracks.Add(ChooseSingleTrack());
            }
            decimal total = 0;
            foreach (var track in tracks)
            {
                total += track.GetPriceT();
            }
            Console.WriteLine($"Total price {total}");
            Console.ReadKey();
            return tracks;
        }
        private static void PrintRecipe1(List<TrackReservation> items1)
        {
            Console.WriteLine("");
            Console.WriteLine("Shooting Range in Warsaw");
            Console.WriteLine("========================");
            Console.WriteLine("Selected tracks:");
            decimal total1 = 0;
            foreach (var track in items1)
            {
                int z = track.NoOfHouersTrack * 30;
                TimeSpan t = TimeSpan.FromMinutes(z); 
                total1 += track.GetPriceT();
                Console.WriteLine($"{track.Track.Track}, reservating for {t} [{track.Track.PriceOfTrack}] price: {track.GetPriceT()}");
            }
            Console.WriteLine("========================");
            Console.WriteLine($"Total price: {total1}");
            Console.ReadKey();
        }
        private static void PrintRecipt2(List<GunWithBullets> items, List<TrackReservation> items1)
        {
            String path = @"C:\ShootRange";
            DirectoryInfo fl = new DirectoryInfo(path);
            fl.Create();
            string fileName = @"C:\\ShootRange\\repice.txt";
            StreamWriter wrtier = new StreamWriter(fileName);
            wrtier.WriteLine();
            Console.WriteLine();
            wrtier.WriteLine("Shooting Range in Warsaw");
            Console.WriteLine("Shooting Range in Warsaw");
            wrtier.WriteLine("========================");
            Console.WriteLine("========================");
            decimal total = 0;

            if (items.Count() > 0)
            {
                wrtier.WriteLine("Selected guns:");
                Console.WriteLine("Selected guns:");
                foreach (var gun in items)
                {
                    total += gun.GetPrice();
                    wrtier.WriteLine($"{gun.Gun.Name} no of bullets {gun.NoOfBullets} [{gun.Gun.BulletPrice}] price: {gun.GetPrice()}");
                    Console.WriteLine($"{gun.Gun.Name} no of bullets {gun.NoOfBullets} [{gun.Gun.BulletPrice}] price: {gun.GetPrice()}");
                }
            }

            if (items1.Count() > 0)
            {
                wrtier.WriteLine("Selected tracks:");
                Console.WriteLine("Selected tracks:");
                foreach (var track in items1)
                {
                    int z = track.NoOfHouersTrack * 30;
                    TimeSpan t = TimeSpan.FromMinutes(z);
                    total += track.GetPriceT();
                    wrtier.WriteLine($"{track.Track.Track}, reservating for {t} [{track.Track.PriceOfTrack}] price: {track.GetPriceT()}");
                    Console.WriteLine($"{track.Track.Track}, reservating for {t} [{track.Track.PriceOfTrack}] price: {track.GetPriceT()}");
                }
            }
            wrtier.WriteLine("========================");
            Console.WriteLine("========================");
            wrtier.WriteLine($"Total price: {total}");
            Console.WriteLine($"Total price: {total}");
            wrtier.Close();
            Console.ReadKey();
        }
    }
}
