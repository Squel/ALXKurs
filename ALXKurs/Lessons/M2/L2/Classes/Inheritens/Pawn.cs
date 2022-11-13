using ALXKurs.Lessons.M1.L2.Enums;


namespace ALXKurs.Lessons.M2.L2.Classes.Inheritens
{
    public class Pawn : ChessPiece
    {
        public Pawn() : base()
        {
            Type = ChessFiguresTypes.PAWN;
        }
        public void Move()
        {
            Console.WriteLine("Pawn is moving...");
        }
    }
}
