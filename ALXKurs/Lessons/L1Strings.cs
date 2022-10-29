using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALXKurs.Lessons
{
     public class L1Strings
    {
        public static void test()
        {
            string name = "Mateusz";
            name = "Ala";
            Console.WriteLine(name);
            name = name + "Ala ma konta";
            Console.WriteLine(name);
            ExpandString(name, "hello");
            Console.WriteLine(name);
            ExpandString(name, "World");
            Console.WriteLine(name);
            ExpandString(name, "Something");
            Console.WriteLine(name);

            
        }

        public static void ExpandString (string word, string extension)
        {
            word = word + extension;
        }

        public static void ConcatenationTest()
        {
            string word1 = "Ala ma";
            string word2 = "koty dwa";

            string concat1 = word1 + word2;
            string concat2 = word1 + " " + word2;

            string concat3 = $"{word1} {word2} i dobrze się ma";
            Console.WriteLine(concat3);
        }
    }
}
