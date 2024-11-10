namespace Chess
{
    public class Piece

    {
        public bool IsWhite { get; }

        public (int row, int col) Position { get; set; }


        public int Rank { get; }


        public bool Start { get; set; }

        public int TurnsLeft { get; set; }

        public string name { get; }

        /// change number of slots in moes based on valid moves for piece, so pawn has 4 valid moves
        //private const int _numberOfMoves = 3;


        public Piece((int row, int col) position, int rank, bool isWhite, bool start)
        {
            Position = position;
            Rank = rank;
            IsWhite = isWhite;
            Start = start;
            switch (rank)
            {
                case 0:
                    {
                        name = "Pawn";
                        TurnsLeft = -1;
                        break;
                    }
                case 1:
                    {
                        name = "Bishop";
                        TurnsLeft = 8;
                        break;
                    }
                case 2:
                    {
                        name = "Knight";
                        TurnsLeft = 8;
                        break;
                    }
                case 3:
                    {
                        name = "Rook";
                        TurnsLeft = 8;
                        break;
                    }
                case 4:
                    {
                        name = "Queen";
                        TurnsLeft = 6;
                        break;
                    }
                case 5:
                    {
                        name = "King";
                        TurnsLeft = -1;
                        break;
                    }

            }
        }


    }
}
