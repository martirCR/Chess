namespace Chess
{
    public class Pawn

    {
        public bool IsWhite { get; }

        public (int row, int col) Position { get; set; }

        public int Rank { get; }

        public bool Start { get; set; }

        /// change number of slots in moes based on valid moves for piece, so pawn has 4 valid moves
        //private const int _numberOfMoves = 3;

    }
}
