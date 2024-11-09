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
        private string[,] _chessBoard = new string[_boardLength, _boardLength]; // String will be replaced by piece type
        /// <summary>
        /// Moves pece
        /// </summary>
        /// <exception cref="NotImplementedException"></exception>
        public void MovePiece(/*Piece p*/)
        {


            throw new NotImplementedException();
        }
        /// <summary>
        /// Checks to see if Piece is already on board
        /// </summary>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        private bool IsValid(int row, int col, /*piece*/)
        {
            chessBoard
            if (chessboard[row, col] != /*piece*/)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }