using ALXKurs.Lessons.M1.L2.Enums;


namespace ALXKurs.Lessons.M2.L2.Classes.Inheritens
{
    
    public class Rook : ChessPiece
    {
        public Rook() :base() 
        {
            Type = ChessFiguresTypes.ROOK;
        }
        public void Move()
        {
            Console.WriteLine("Rock is Moving...");
        }
    }
}
