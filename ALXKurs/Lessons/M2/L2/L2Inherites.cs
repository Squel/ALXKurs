
using ALXKurs.Lessons.M2.L2.Classes.Inheritens;
using ALXKurs.Lessons.M1.L2.Enums;
using System.Security.Cryptography.X509Certificates;

namespace ALXKurs.Lessons.M2.L2
{
    public class L2Inherites
    {
        public static void Run()
        {
           ChessPiece chessPiece = new ChessPiece();
            chessPiece.XPosition = 1;
            chessPiece.YPosition = 1;
            chessPiece.Color = ChessColor.BLACK;
            chessPiece.Move();
            Queen queen = new Queen();
            queen.XPosition = 1;
            queen.YPosition = 1;
            queen.Move();
            queen.Color = ChessColor.WHITE;
        }
    }
}
