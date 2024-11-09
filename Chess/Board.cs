using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public void MovePiece(/*Piece p*/)
        {
            /* (int row, int col) = p.Move;
             * if (IsValid(row, col))
             * {
             *     _chessBoard[row,col] = p;
             * }
            */


        }


        /// <summary>
        /// Checks to see if Piece is already on board
        /// </summary>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        private bool IsValid()
        {
            throw new NotImplementedException();
        }


       
    }
}
