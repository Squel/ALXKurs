using ALXKurs.Lessons.M1.L2.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALXKurs.Lessons.M2.L2.Classes.Inheritens
{
    public class ChessPiece
    {
        public ChessColor Color { get; set; }
        public ChessFiguresTypes Type { get; set; }
        public int XPosition { get; set; }
        public int YPosition { get; set; }

        public bool IsAlive { get; set; }

        public ChessPiece()
        {
            IsAlive = true;
        }

      
        public void Move()
        {
            Console.WriteLine("Chess Pice is moving....");
        }

        public void Present()
        {
            Console.WriteLine($"Color: {Color}");
            Console.WriteLine($"X position: {XPosition}");
            Console.WriteLine($"Y position: {YPosition}");
        }
    }
}
