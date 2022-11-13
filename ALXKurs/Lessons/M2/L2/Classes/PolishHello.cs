using ALXKurs.Lessons.M2.L2.Interface;

namespace ALXKurs.Lessons.M2.L2.Classes
{
    public class PolishHello: IHello
    {
        public void SayGoodMorning()
        {
            Console.WriteLine("Dzien dobry");
        }

        public void SayGoodMorning(string name)
        {
            Console.WriteLine($"Dzien dobry {name}");
        }

        public void SayHello()
        {
            Console.WriteLine("Czesc");
        }

        public void SayHello(string name)
        {
            Console.WriteLine($"Czesc {name}");
        }
    }
}
