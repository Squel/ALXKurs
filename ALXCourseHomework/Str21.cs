using ALXCourseHomework.MaterialsAssignments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALXCourseHomework
{
    public class Str21
    {
        public static void Run()
        {
            Exercise2 towar1 = new Exercise2();
            towar1.Id = 1;
            towar1.Netto = 3.58;
            towar1.Vat = 5;
            towar1.Ilosc = 10;
            towar1.Pudelko = 2;
            towar1.Present();

            var towar2 = new Exercise2();
            towar2.Id = 2;
            towar2.Netto = 9.61;
            towar2.Vat = 5;
            towar2.Ilosc = 25;
            towar2.Pudelko = 5;
            towar2.Present();

            var towar3 = new Exercise2();
            towar3.Id = 3;
            towar3.Netto = 8.52;
            towar3.Vat = 8;
            towar3.Ilosc = 18;
            towar3.Pudelko = 3;
            towar3.Present();

            var towar4 = new Exercise2();
            towar4.Id = 4;
            towar4.Netto = 10.25;
            towar4.Vat = 8;
            towar4.Ilosc = 36;
            towar4.Pudelko = 6;
            towar4.Present();

            var towar5 = new Exercise2();
            towar5.Id = 5;
            towar5.Netto = 36.17;
            towar5.Vat = 23;
            towar5.Ilosc = 4;
            towar5.Pudelko = 1;
            towar5.Present();
            
            
        }

        private void cena_brutto()
        {

        }

        
    }
}
