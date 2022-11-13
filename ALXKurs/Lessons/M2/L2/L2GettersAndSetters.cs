using ALXKurs.Lessons.M2.L2.Classes;


namespace ALXKurs.Lessons.M2.L2
{
    public class L2GettersAndSetters
    {
        public static void Run()
        {
            var computer = new Computer();
            computer.Name = "Test";
            computer.Brand = "Dell";
            computer.ProcessorFrequency = 3.6;
            computer.NumbeFofCores = 3;
            PresentComputer(computer);
            Console.WriteLine("\n");
            var computer1 = new Computer();
            computer1.Name = "Test1";
            computer1.Brand = "HP";
            computer1.ProcessorFrequency = 8;
            computer1.NumbeFofCores = 4;
            PresentComputer(computer1);
        }
        private static void PresentComputer (Computer computer)
        {
            Console.WriteLine($"Name: {computer.Name}");
            Console.WriteLine($"Brand: {computer.Brand}");
            Console.WriteLine($"Clock: {computer.ProcessorFrequency}");
            Console.WriteLine($"Cores: {computer.NumbeFofCores}");
        }
    }
}
