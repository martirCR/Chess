using System;
using System.Collections.Generic;

namespace Chess
{
    public class Board
    {
        private const int _boardLength = 8;

        private string[,] _chessBoard = new string[_boardLength, _boardLength]; // String will be replaced piece type
        private int _numberOfMoves = 32;


        /// <summary>
        /// Moves pece
        /// </summary>
        /// <exception cref="NotImplementedException"></exception>
        public void MovePiece(Piece p)

        { }
            (int row, int col)[] ValidMove(Piece p)            {
                
                switch (p.Rank)
                {
                    case 0: // pawn
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
                    case 1: // bishop
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
                    case 2: // knight
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
                    case 3://rook
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
                    case 4://queen
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
                    case 5:
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
            if (p.Position.row > _boardLength || p.Position.col > _boardLength)
            {

            }
        }








    }
}
