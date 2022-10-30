

namespace ALXKurs.Lessons.L1.Classes
{
    public class Dog
    {
        public string Name;
        public int Age;
        public string Race;
        public bool GoodBoy = true;
        public void jump()
        {
            Console.WriteLine("Boing! Boing!");

        }

        public void Bark()
        {
            Console.WriteLine("Woof! Woof!");
        }

        public static void Eat()
        {
            Console.WriteLine("Eat! Eat!");
        }

        public int getOlderAge() 
        {
            return Age + 1; 
        }

        public void GrowOlder(int numerOfYears)
        {
            Age = Age+ numerOfYears;
        }

        public int Add(int x, int y)
        {
            return x + y;
        }

        public DogOffspringStats Breed()
        {
            DogOffspringStats stats = new DogOffspringStats();
            stats.NumberOfMalePups = 4;
            stats.NumberOfFemalePups = 6;
            return stats;
        }

        public void Present()
        {
            Console.WriteLine("Attetion here is dog " + Name);
            Console.WriteLine("Race: " + Race);
            Console.WriteLine("Age: " + Age);
            Console.WriteLine("Is he a god boy: " + GoodBoy);       
        }
    }

}
