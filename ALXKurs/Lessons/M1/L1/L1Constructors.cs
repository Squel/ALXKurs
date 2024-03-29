﻿using ALXKurs.Lessons.M1.L1.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALXKurs.Lessons.M1.L1
{
    public class L1Constructors
    {
        public static void Run()
        {
            var spider = new Spider();
            spider.Color = "black";
            spider.Species = "Black Widow";
            spider.IsVenomous = true;
            spider.Sex = "female";


            var redspider = new Spider("red", "taratula", true, "male");

            var bluespider = new Spider("blue", "Goliath");

            var yellowSpider = new Spider("yellow", true);
        }
    }
}
