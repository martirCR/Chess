using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    public class Pawn
    {
        public bool IsWhite { get; }

        public (int row, int col) Position { get; set; }
        public int rank;

        public bool _start = true;
        /// change number of slots in moes based on valid moves for piece, so pawn has 4 valid moves
        public const int _numberOfMoves = 3;
        //update in the board class to false once moved
        public (int row, int col)[] ValidMove(Piece p)
        {
            
            (int row, int col)[] moves = new (int row, int col)[32];
            if (rank == 0)// rank 0 is pawn
            {
                if (_start)
                {
                    moves[0] = (p.Position.row + 2, p.Position.col);
                }
                moves[1] = (p.Position.row + 1, p.Position.col);
                moves[2] = (p.Position.row + 1, p.Position.col - 1);
                moves[3] = (p.Position.row + 1, p.Position.col + 1);
                return moves;
            }
            if (rank == 1) //rank 1 is bishop
            {

            }
        }
    }
}
