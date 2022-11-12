using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALXKurs.Lessons.M2.L1
{
    public class L1Lists
    {
        public static void Run()
        {
            List<string> shopinglist = new List<string>();
            shopinglist.Add("milk");
            ShowList(shopinglist);
            shopinglist.Add("breed");
            ShowList(shopinglist);
            shopinglist.Add("butter");
            ShowList(shopinglist);
            shopinglist.Add("orange");
            ShowList(shopinglist);
            shopinglist.Add("apple");
            ShowList(shopinglist);
            shopinglist.Add("lime");
            ShowList(shopinglist);

            shopinglist.Remove("milk");
            ShowList(shopinglist);

        }
        public static void ShowList(List<string> list)
        {
            Console.WriteLine($"Number of elements: {list.Count}");
            foreach (string item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}
