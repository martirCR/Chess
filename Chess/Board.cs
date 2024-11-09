using System;

namespace Chess
{
    public class Board
    {
        private const int _boardLength = 8;

        private string[,] _chessBoard = new string[_boardLength, _boardLength]; // String will be replaced piece type

        /// <summary>
        /// Moves pece
        /// </summary>
        /// <exception cref="NotImplementedException"></exception>
        public void MovePiece(Piece p)
        {
            int rank = p.Rank;
            switch (rank)
            {
                case 0:
                    {
                        //if (_start)
                        //{
                        /*    moves[0] = (p.Position.row + 2, p.Position.col);
                        }
                        moves[1] = (p.Position.row + 1, p.Position.col);
                        moves[2] = (p.Position.row + 1, p.Position.col - 1);*/
                        break;
                    }
                case 1:
                    {

                        break;
                    }
                case 2:
                    {

                        break;
                    }
            }


        }


        /// <summary>
        /// Checks to see if Piece is already on board
        /// </summary>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        private bool IsValid(Piece p)
        {
            if (p.Position.row > _boardLength || p.Position.col > _boardLength)
            {

            }
        }








    }
}
