using ALXKurs.Lessons.M1.L2.Enums;


namespace ALXKurs.Lessons.M2.L2.Classes.Inheritens
{
    public class Knight : ChessPiece
    {
        public Knight() : base() 
        {
            Type = ChessFiguresTypes.KNIGHT;
        }
        public void Move()
        {
            Console.WriteLine("Knight is moving.....");
        }
    }
}
