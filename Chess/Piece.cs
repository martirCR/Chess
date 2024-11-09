using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    internal interface Piece
    {
         bool IsWhite { get; }
         (int row, int col) Position { get; set; }       

        (int row, int col)[] ValidMove(Piece p);
        /// add a const int _numberOfMoves to determine maximum number of spaces a piece can move ie. pawn._numberOfMoves = 3 because it has 4 valid moves and minus one because 0 is a value in the array

        //implement constructor in each class


    }
}
