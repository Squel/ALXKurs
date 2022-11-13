
using ALXKurs.Lessons.M1.L2.Enums;

namespace ALXKurs.Lessons.M2.L2.Classes.Inheritens
{
    public class King :ChessPiece
    {
        public bool Checked { get; set; }

        public King() : base()
        {
            Checked = false;
            Type = ChessFiguresTypes.KING;
        }
        public void Move()
        {
            Console.WriteLine("The King is Moving...");
        }
    }
}
