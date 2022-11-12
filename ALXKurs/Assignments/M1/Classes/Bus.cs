using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALXKurs.Assignments.M1.Classes
{
    public class Bus
    {
        public string Color;
        public string Model;
        public int Engine;

        public Bus(string color)
        {
            Color = color;
            Model = "Mercedes";
            Engine = 3200;
        }

        public Bus()
        {
            Color = "Blue";
            Model = "Renault";
            Engine = 5000;
        }

        public void ThisNewBus()
        {
            Console.WriteLine("Turist");
        }
        public void Present()
        {
            Console.WriteLine($"Model: {Model}");
            Console.WriteLine($"Color: {Color}");
            Console.WriteLine($"Engine: {Engine} ccm");
        }
    }
}
