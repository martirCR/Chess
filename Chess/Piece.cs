using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    public class Piece
    {
        
        public bool IsWhite { get; }

        public (int row, int col) Position { get; set; }

        public bool Start { get; set; } = true;
        /// change number of slots in moes based on valid moves for piece, so pawn has 4 valid moves
        public const int NumberOfMoves = 3;
        public int Rank;


        Piece((int row, int col) position, int rank, bool isWhite, bool start)
        {
            Position = position;
            Rank = rank;
            IsWhite = isWhite;
            Start = start;
        }
        
    }
}
