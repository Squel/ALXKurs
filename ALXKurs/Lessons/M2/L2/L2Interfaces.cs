using ALXKurs.Lessons.M2.L2.Classes;
using ALXKurs.Lessons.M2.L2.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALXKurs.Lessons.M2.L2
{
    public class L2Interfaces
    {
        public static void Run()
        {
            IHello helloService = new PolishHello();
            helloService.SayGoodMorning("Michal");
            helloService.SayGoodMorning();
            helloService.SayHello("Michal");
            helloService.SayHello();

            helloService = new Hello();
            helloService.SayGoodMorning("Michal");
            helloService.SayGoodMorning();
            helloService.SayHello("Michal");
            helloService.SayHello();
        }
    }
}
