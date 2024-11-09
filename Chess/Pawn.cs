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

        public int rank { get; };

        public bool _start = true;
        /// change number of slots in moes based on valid moves for piece, so pawn has 4 valid moves
        public const int _numberOfMoves = 3;
        
    }
}
