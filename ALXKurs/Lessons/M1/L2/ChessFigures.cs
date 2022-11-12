using ALXKurs.Lessons.M1.L2.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALXKurs.Lessons.M1.L2
{
    public class ChessFigures
    {
        public ChessFiguresTypes FigureType;
        public ChessColor FigureColor;

        public ChessFigures() { }

        public ChessFigures(ChessFiguresTypes chessFiguresTypes, ChessColor chessColor)
        {
            FigureType = chessFiguresTypes;
            FigureColor = chessColor;
        }
    }
}
