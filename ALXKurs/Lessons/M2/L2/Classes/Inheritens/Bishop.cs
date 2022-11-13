using ALXKurs.Lessons.M1.L2.Enums;


namespace ALXKurs.Lessons.M2.L2.Classes.Inheritens
{
    public class Bishop : ChessPiece
    {
        public Bishop() : base()
        {
            Type = ChessFiguresTypes.BISHOP;
        }
        public void Move()
        {
            Console.WriteLine("Bishop is Moving...");
        }
    }
}
