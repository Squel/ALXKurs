using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALXKurs.Assignments.Classes
{
    public class Car
    {
        public string Color;
        public string Model;
        public int Engine;

        public void ThisNewCar()
        {

            Console.WriteLine("This is your car");
        }
        public void Present()
        {
            Console.WriteLine($"New car ");
            Console.WriteLine($"Model: {Model}");
            Console.WriteLine($"Color: {Color}");
            Console.WriteLine($"Engine: {Engine}");
        }

    }

    
}
