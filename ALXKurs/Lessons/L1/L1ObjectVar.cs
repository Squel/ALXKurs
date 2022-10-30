using ALXKurs.Lessons.L1.Classes;

namespace ALXKurs.Lessons.L1
{
    public class L1ObjectVar
    {
        public static void Run()
        {

            Dog dog = new Dog();
            dog.jump();
            dog.Bark();
            dog.Name = "Burek";
            dog.Race = "Kundel";
            dog.Age = 2;
            Console.WriteLine("Attetion here is dog " + dog.Name);
            Console.WriteLine("Race " + dog.Race);
            Console.WriteLine("Age " + dog.Age);
            Dog.Eat();
        }

        public static void Run2()
        {
            Dog westieDog = new Dog();
            westieDog.Race = "kundelek1";
            westieDog.Age = 2;
            westieDog.Name = "Burek";
            westieDog.GoodBoy = true;
            westieDog.Present();
            DogOffspringStats stats = westieDog.Breed();
            Console.WriteLine("Number of feamle pups: " + stats.NumberOfFemalePups);
            Console.WriteLine("Number of male pups: " + stats.NumberOfMalePups);
            westieDog.Bark();
            westieDog.jump();
            Console.WriteLine(westieDog.Add(2, 3));

        }
        public void writersomting()
        {
            Console.WriteLine("Something");
        }
    }
}
