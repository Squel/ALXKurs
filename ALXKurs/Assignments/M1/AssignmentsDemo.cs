using ALXKurs.Assignments.M1.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALXKurs.Assignments.M1
{
    public class AssignmentsDemo
    {
        public static void Run()
        {
            Car car = new Car();
            car.Color = "Red";
            car.Model = "Mazda";
            car.Engine = 1600;
            car.ThisNewCar();
            car.Present();
            Console.WriteLine(" ");

            var newbus = new Bus("red");
            newbus.Present();
            newbus.ThisNewBus();
            Console.WriteLine(" ");

            var newbus1 = new Bus();
            newbus1.Color = "Blue";
            newbus1.Model = "Renault";
            newbus1.Engine = 5000;
            newbus1.Present();
            newbus1.ThisNewBus();
        }



    }
}
