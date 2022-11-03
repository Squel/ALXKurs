using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALXCourseHomework.MaterialsAssignments
{
    public class Exercises1
    {
        public string name = "Michal";
        public string surname = "B";
        public int age = 41;
        public double hiegh = 1.8;
        public string sex = "M";
        public double pesel = 81092300561;
        

        public void Present()
        {
            Console.WriteLine($"Imię: {name}");
            Console.WriteLine($"Nazwisko: {surname}");
            Console.WriteLine($"Wiek: {age}");
            Console.WriteLine($"Wzrost: {hiegh} M");
            Console.WriteLine($"Płeć: {sex}");
            Console.WriteLine($"Pesel: {pesel}");
            int y = Convert.ToInt32(hiegh);
             Console.WriteLine($"Wzrost: {y} ");
        }

    }
}
