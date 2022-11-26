
using ALXKurs.Lessons.M2.L2.Classes.Inheritens;
using ALXKurs.Lessons.M1.L2.Enums;


namespace ALXKurs.Lessons.M2.L2
{
    public class L2Inherites
    {
        public static void Run()
        {
           ChessPiece chessPiece = new ChessPiece();
            chessPiece.XPosition = 1;
            chessPiece.YPosition = 1;
            chessPiece.Move();
            chessPiece.Present();
            

            Queen queen = new Queen();
            queen.XPosition = 1;
            queen.YPosition = 1;
            queen.Move();
            queen.Color = ChessColor.WHITE;
            queen.Present();
            

            Knight knight = new Knight();
            knight.XPosition = 1;
            knight.YPosition = 1;
            knight.Move();
            knight.Color = ChessColor.BLACK;
            knight.Present();
            

            Bishop bishop = new Bishop();
            bishop.XPosition = 1;
            bishop.YPosition = 1;
            bishop.Move();
            bishop.Color = ChessColor.BLACK;
            bishop.Present();
          
        }
   
    }
}
