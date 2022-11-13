

namespace ALXKurs.Lessons.M2.L2.Classes
{
    public class Computer
    {
        private string _brand;
        
        public string Brand
        {
            get 
            {
                Console.WriteLine("Getting computer brand.");
                return _brand; 
            } 
            set 
            {
                Console.WriteLine($"Setting computer brand {value}");
                _brand = value; 
            }
        }

        public string Name { get; set; }

        private double? _processorFrequency;
        public double? ProcessorFrequency
        {
            get
            {
                Console.WriteLine("Getting processor clock frequency [GHz]...");
                return _processorFrequency;
            }
            set 
            {
                if (value > 0 && value < 4)
                {
                    Console.WriteLine($"Setting computer processor clock frquency as {value} [GHz]");
                    _processorFrequency = value;
                }
                else
                {
                    _processorFrequency = null;
                    Console.WriteLine("Invalid processor frequency value!");
                }
            }
       
        }
        public int NumbeFofCores { get; set; }
        public string Model;

        public int StorageSpace { get; }
        public readonly string GraphicalCardModel;
    }
}
