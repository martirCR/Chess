using System;
using System.Collections.Generic;

namespace Chess
{
    public class Board
    {
        private const int _boardLength = 8;

        public Piece[,] ChessBoard { get; set; } = new Piece[_boardLength, _boardLength];

        private const int _numberOfMoves = 32;

        private const int _pawn = 0;

        private const int _bishop = 1;

        private const int _knight = 2;

        private const int _rook = 3;

        private const int _queen = 4;

        private const int _king = 5;

        private void SetSpecialPieces(bool IsWhite)
        {
            int row;
            int inc = 0;
            if (IsWhite)
            {
                row = 0;
            }
            else
            {
                row = _boardLength - 1;
            }
            ChessBoard[row, inc] = new Piece((row, inc), _rook, IsWhite, true);
            inc = 1;
            ChessBoard[row, inc] = new Piece((row, inc), _knight, IsWhite, true);
            inc++;
            ChessBoard[row, inc] = new Piece((row, inc), _bishop, IsWhite, true);
            inc++;
            ChessBoard[row, inc] = new Piece((row, inc), _king, IsWhite, true);
            inc++;
            ChessBoard[row, inc] = new Piece((row, inc), _queen, IsWhite, true);
            inc++;
            ChessBoard[row, inc] = new Piece((row, inc), _bishop, IsWhite, true);
            inc++;
            ChessBoard[row, inc] = new Piece((row, inc), _knight, IsWhite, true);
            inc++;
            ChessBoard[row, inc] = new Piece((row, inc), _rook, IsWhite, true);

        }

        private void SetPawns(bool IsWhite)
        {
            int row;
            if (IsWhite)
            {
                row = 1;
            }
            else
            {
                row = _boardLength - 2;
            }
            for (int i = 0; i < _boardLength; i++)
            {
                ChessBoard[row, i] = new Piece((row, i), _pawn, IsWhite, true);
            }
        }

        public void SetPieces()
        {
            SetSpecialPieces(true);
            SetPawns(true);
            SetSpecialPieces(false);
            SetPawns(false);
        }


        /// <summary>
        /// Moves pece
        /// </summary>
        public void MovePiece(Piece p)
        { 

        }


        public (int row, int col)[] ValidMove(Piece p)
        {

            switch (p.Rank)
            {
                case _pawn: // pawn
                    {
                        (int row, int col)[] moves = new (int row, int col)[3];
                        if (p.Start)
                        {
                            moves[0] = (p.Position.row + 2, p.Position.col);
                        }
                        moves[1] = (p.Position.row + 1, p.Position.col);
                        moves[2] = (p.Position.row + 1, p.Position.col - 1);
                        moves[3] = (p.Position.row + 1, p.Position.col + 1);
                        return moves;
                    }
                case _bishop: // bishop
                    {

                        Queue<(int row, int col)> que = new Queue<(int row, int col)>();
                        for (int i = 1; i < 8; i++)// 8 is the maximum number of spaces a piece can move
                        {
                            que.Enqueue((p.Position.row + i, p.Position.col + i));
                            que.Enqueue((p.Position.row + i, p.Position.col - i));
                            que.Enqueue((p.Position.row - i, p.Position.col + i));
                            que.Enqueue((p.Position.row - i, p.Position.col - i));
                        }
                        (int row, int col)[] moves = new (int row, int col)[que.Count];
                        for (int i = 0; i < que.Count; i++)
                        {
                            moves[i] = que.Dequeue();
                        }
                        return moves;
                    }
                case _knight: // knight
                    {
                        (int row, int col)[] moves = new (int row, int col)[7];
                        moves[0] = (p.Position.row + 2, p.Position.col - 1);// tall up left
                        moves[1] = (p.Position.row + 2, p.Position.col + 1);//tall up right
                        moves[2] = (p.Position.row + 1, p.Position.col - 2); //short up left
                        moves[3] = (p.Position.row + 1, p.Position.col + 2);//short up right
                        moves[4] = (p.Position.row - 2, p.Position.col + 1);//tall down right
                        moves[5] = (p.Position.row - 2, p.Position.col - 1);//tall down left
                        moves[6] = (p.Position.row - 1, p.Position.col + 2);//short down right
                        moves[7] = (p.Position.row - 1, p.Position.col - 2);//short down left
                        return moves;
                    }
                case _rook://rook
                    {
                        Queue<(int row, int col)> que = new Queue<(int row, int col)>();
                        for (int i = 1; i < 8; i++)// 8 is the maximum number of spaces a piece can move
                        {
                            que.Enqueue((p.Position.row + i, p.Position.col));
                            que.Enqueue((p.Position.row - i, p.Position.col));
                            que.Enqueue((p.Position.row, p.Position.col + i));
                            que.Enqueue((p.Position.row, p.Position.col - i));
                        }
                        (int row, int col)[] moves = new (int row, int col)[que.Count];
                        for (int i = 0; i < que.Count; i++)
                        {
                            moves[i] = que.Dequeue();
                        }
                        return moves;
                    }
                case _queen://queen
                    {
                        Queue<(int row, int col)> que = new Queue<(int row, int col)>();
                        for (int i = 1; i < 8; i++)// 8 is the maximum number of spaces a piece can move
                        {
                            que.Enqueue((p.Position.row + i, p.Position.col));
                            que.Enqueue((p.Position.row - i, p.Position.col));
                            que.Enqueue((p.Position.row, p.Position.col + i));
                            que.Enqueue((p.Position.row, p.Position.col - i));
                            que.Enqueue((p.Position.row + i, p.Position.col + i));
                            que.Enqueue((p.Position.row + i, p.Position.col - i));
                            que.Enqueue((p.Position.row - i, p.Position.col + i));
                            que.Enqueue((p.Position.row - i, p.Position.col - i));
                        }
                        (int row, int col)[] moves = new (int row, int col)[que.Count];
                        for (int i = 0; i < que.Count; i++)
                        {
                            moves[i] = que.Dequeue();
                        }
                        return moves;




                    }
                case _king://king
                    {
                        Queue<(int row, int col)> que = new Queue<(int row, int col)>();
                        for (int i = 0; i < 1; i++)// 8 is the maximum number of spaces a piece can move
                        {
                            que.Enqueue((p.Position.row + i, p.Position.col));
                            que.Enqueue((p.Position.row - i, p.Position.col));
                            que.Enqueue((p.Position.row, p.Position.col + i));
                            que.Enqueue((p.Position.row, p.Position.col - i));
                            que.Enqueue((p.Position.row + i, p.Position.col + i));
                            que.Enqueue((p.Position.row + i, p.Position.col - i));
                            que.Enqueue((p.Position.row - i, p.Position.col + i));
                            que.Enqueue((p.Position.row - i, p.Position.col - i));
                        }
                        (int row, int col)[] moves = new (int row, int col)[que.Count];
                        for (int i = 0; i < que.Count; i++)
                        {
                            moves[i] = que.Dequeue();
                        }
                        return moves;
                    }



            }
            return null;
        }




        /// <summary>
        /// Checks to see if Piece is already on board
        /// </summary>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        private bool IsValid(Piece p)
        {
            if (p.Position.row < _boardLength && p.Position.col < _boardLength)
            {
                if (p.IsWhite && ChessBoard[p.Position.row, p.Position.col] == p)
                {
                    return false;
                }
                else if (!p.IsWhite && ChessBoard[p.Position.row, p.Position.col] == p)
                {
                    return true;
                }

                return true;
            }
            else
            {
                return false;
            }
        }








    }
}
