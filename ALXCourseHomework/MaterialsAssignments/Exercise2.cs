using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALXCourseHomework.MaterialsAssignments
{
    public class Exercise2
    {
        public int Id;
        public double Netto;
        public double Brutto;
        public int Vat;
        public int Ilosc;
        public int Pudelko;


        public void Present()
        {
            Console.WriteLine($"Towar: Id: {Id}, Cenna netto: {Netto}zł, Vat: {Vat}, Ilość w opakowaniu: {Ilosc}, Ilość pudełek na magazynie: {Pudelko}");
        }
    }

    
}
