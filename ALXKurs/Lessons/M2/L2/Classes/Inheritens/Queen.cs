using ALXKurs.Lessons.M1.L2.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALXKurs.Lessons.M2.L2.Classes.Inheritens
{
    public class Queen : ChessPiece
    {
        public Queen() : base()
        {
            Type = ChessFiguresTypes.QUEEN;
        }
        public void Move()
        {
            Console.WriteLine("The Queen is moving...");
        }

        public void Present()
        {
            Console.WriteLine($"Queen");
            Console.WriteLine($"Color {Color}");
            Console.WriteLine($"X Position {XPosition}");
            Console.WriteLine($"Y Position {YPosition}");
        }

    }
}
