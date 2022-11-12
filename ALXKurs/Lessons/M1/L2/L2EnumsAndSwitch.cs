using ALXKurs.Lessons.M1.L2.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALXKurs.Lessons.M1.L2
{
    public class L2EnumsAndSwitch
    {
        public static void Run()
        {
            var whiteQueen = new ChessFigures(ChessFiguresTypes.QUEEN, ChessColor.WHITE);

            var blackQueen = new ChessFigures();
            blackQueen.FigureType = ChessFiguresTypes.QUEEN;
            blackQueen.FigureColor = ChessColor.BLACK;

            var whiteKing = new ChessFigures
            {
                FigureType = ChessFiguresTypes.KING,
                FigureColor = ChessColor.WHITE
            };

            var blackBishop = new ChessFigures(ChessFiguresTypes.BISHOP, ChessColor.BLACK);

            GetFiguresType(whiteKing);
            GetFiguresType(blackBishop);
            GetFiguresType(whiteQueen);
            GetFiguresType(blackQueen);

        }
        private static void GetFiguresType(ChessFigures chessFigure)
        {
            switch (chessFigure.FigureType)
            {
                case ChessFiguresTypes.QUEEN:
                    Console.WriteLine("The figure is a queen");
                    break;
                case ChessFiguresTypes.PAWN:
                    Console.WriteLine("The figure is a pawn");
                    break;
                case ChessFiguresTypes.KING:
                    Console.WriteLine("The figure is a king");
                    break;
                case ChessFiguresTypes.BISHOP:
                    Console.WriteLine("The figure is a bishop");
                    break;
                case ChessFiguresTypes.ROOK:
                    Console.WriteLine("The figure is a rook");
                    break;
                default:
                    Console.WriteLine("The type is undefined...");
                    break;
            }
            Console.WriteLine("Figure is classified");
        }
    }
}
