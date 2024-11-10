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
            for(int i = 2; i < _boardLength - 2; i++)
            {
                for(int j = 0; j < _boardLength; j++)
                {
                    ChessBoard[i, j] = null;
                }
            }
            SetSpecialPieces(false);
            SetPawns(false);
        }


        /// <summary>
        /// if move is valid updates piece position and the chessboard index with said position
        /// </summary>
        public void MovePiece((int row, int col) move, (int row, int col)[] possible, Piece p)
        {
            if (IsValid(p, move.row, move.col))
            {

                if (ChessBoard[move.row, move.col] == null)// if the space is empty
                {
                    p.Position = (move.row, move.col);
                    ChessBoard[move.row, move.col] = p;
                    return;
                }
                if (ChessBoard[move.row, move.col].IsWhite != p.IsWhite)//if it is a opposite color
                {
                    p.Position = (move.row, move.col);
                    ChessBoard[move.row, move.col] = p;
                    return;
                }
            }
            return;
        }
        /// <summary>
        /// search for move returns true if found and if found the out parameter is the index
        /// </summary>
        /// <param name="move"></param>
        /// <param name="possible"></param>
        /// <param name="index"></param>
        /// <returns></returns>
        private bool MoveSearch((int row, int col) move, (int row, int col)[] possible, out int? index)
        {
            for (int i = 0; i < possible.Length; i++)
            {
                if (possible[i] == move)
                {
                    index = i;
                    return true;
                }
            }
            index = null;
            return false;
        }



        /// <summary>
        /// checks valid moves for the piece
        /// </summary>
        /// <param name="p">the pieceparam>
        /// <returns>an array of valid moves the piece can make</returns>
        public (int row, int col)[] ValidMove(Piece p)//might have to switch for statements and while statements
        {

            switch (p.Rank)
            {
                case _pawn: // pawn 
                    {
                        (int row, int col)[] moves = new (int row, int col)[3];
                        Queue<(int row, int col)> que = new Queue<(int row, int col)>();
                        if (p.Start)//double jump check
                        {
                            if (!p.IsWhite && ChessBoard[p.Position.row + 2, p.Position.col] == null && ChessBoard[p.Position.row + 1, p.Position.col] == null)// if the space is empty
                            {
                                que.Enqueue((p.Position.row + 2, p.Position.col));
                            }
                        }
                        //single jump check
                        if (ChessBoard[p.Position.row + 1, p.Position.col] == null)// if the space is empty
                        {
                            que.Enqueue((p.Position.row + 2, p.Position.col));
                        }
                        //steal left check                        
                        if (ChessBoard[p.Position.row + 1, p.Position.col - 1] != null && ChessBoard[p.Position.row + 1, p.Position.col - 1].IsWhite != p.IsWhite)//if it is a opposite color
                        {
                            que.Enqueue((p.Position.row + 2, p.Position.col));
                        }
                        //steal right check                        
                        if (ChessBoard[p.Position.row + 1, p.Position.col + 1] != null && ChessBoard[p.Position.row + 1, p.Position.col + 1].IsWhite != p.IsWhite)//if it is a opposite color
                        {
                            que.Enqueue((p.Position.row + 2, p.Position.col));
                        }
                        for (int i = que.Count; i > 0; i--)
                        {
                            moves[i] = que.Dequeue();
                        }
                        return moves;

                    }
                case _bishop: // bishop
                    {

                        Queue<(int row, int col)> que = new Queue<(int row, int col)>();
                        bool ur = true;//up right
                        bool ul = true;//up left
                        bool dr = true;// down right
                        bool dl = true;// down left
                        while (ur)
                        {
                            for (int i = 1; i < 8; i++)
                            {
                                if ((ChessBoard[p.Position.row + i, p.Position.col + i] == null) || ChessBoard[p.Position.row + i, p.Position.col + i].IsWhite != p.IsWhite)
                                {
                                    que.Enqueue((p.Position.row + i, p.Position.col + i));
                                }
                                else
                                {
                                    ur = false;
                                }
                            }
                        }
                        //up left
                        while (ul)
                        {
                            for (int i = 1; i < 8; i++)
                            {
                                if ((ChessBoard[p.Position.row + i, p.Position.col - i] == null) || ChessBoard[p.Position.row + i, p.Position.col - i].IsWhite != p.IsWhite)
                                {
                                    que.Enqueue((p.Position.row + i, p.Position.col - i));
                                }
                                else
                                {
                                    ul = false;
                                }
                            }
                        }
                        //down right
                        while (dr)
                        {
                            for (int i = 1; i < 8; i++)
                            {
                                if ((ChessBoard[p.Position.row - i, p.Position.col + i] == null) || ChessBoard[p.Position.row - i, p.Position.col + i].IsWhite != p.IsWhite)
                                {
                                    que.Enqueue((p.Position.row - i, p.Position.col + i));
                                }
                                else
                                {
                                    dr = false;
                                }
                            }
                        }
                        //down left
                        while (dl)
                        {
                            for (int i = 1; i < 8; i++)
                            {
                                if ((ChessBoard[p.Position.row - i, p.Position.col - i] == null) || ChessBoard[p.Position.row - i, p.Position.col - i].IsWhite != p.IsWhite)
                                {
                                    que.Enqueue((p.Position.row - i, p.Position.col - i));
                                }
                                else
                                {
                                    dl = false;
                                }
                            }
                        }
                        (int row, int col)[] moves = new (int row, int col)[que.Count];
                        for (int i = que.Count; i > 0; i--)
                        {
                            moves[i] = que.Dequeue();
                        }
                        return moves;
                    }
                case _knight: // knight
                    {
                        Queue<(int row, int col)> que = new Queue<(int row, int col)>();
                        (int row, int col)[] spots = new (int row, int col)[7];
                        spots[0] = (p.Position.row + 2, p.Position.col - 1);//tall up left
                        spots[1] = (p.Position.row + 2, p.Position.col + 1);//tall up right
                        spots[2] = (p.Position.row + 1, p.Position.col - 2);//short up left
                        spots[3] = (p.Position.row + 1, p.Position.col + 2);//short up right
                        spots[4] = (p.Position.row - 2, p.Position.col + 1);//tall down right
                        spots[5] = (p.Position.row - 2, p.Position.col - 1);//tall down left
                        spots[6] = (p.Position.row - 1, p.Position.col + 2);//short down right
                        spots[7] = (p.Position.row - 1, p.Position.col - 2);//short down left                        

                        foreach ((int row, int col) spot in spots)
                        {
                            if ((ChessBoard[spot.row, spot.col] == null) || ChessBoard[spot.row, spot.col].IsWhite != p.IsWhite)
                            {
                                que.Enqueue((spot));
                            }
                        }
                        (int row, int col)[] moves = new (int row, int col)[que.Count];
                        for (int i = que.Count; i > 0; i--)
                        {
                            moves[i] = que.Dequeue();
                        }
                        return moves;
                    }
                case _rook://rook
                    {
                        Queue<(int row, int col)> que = new Queue<(int row, int col)>();
                        bool up = true;//up
                        bool down = true;//down
                        bool right = true;// right
                        bool left = true;// left
                        while (up)
                        {
                            for (int i = 1; i < 8; i++)
                            {
                                if ((ChessBoard[p.Position.row + i, p.Position.col] == null) || ChessBoard[p.Position.row + i, p.Position.col].IsWhite != p.IsWhite)
                                {
                                    que.Enqueue((p.Position.row + i, p.Position.col));
                                }

                                else
                                {
                                    up = false;
                                }
                            }
                        }
                        //down
                        while (down)
                        {
                            for (int i = 1; i < 8; i++)
                            {
                                if ((ChessBoard[p.Position.row - i, p.Position.col] == null) || ChessBoard[p.Position.row - i, p.Position.col].IsWhite != p.IsWhite)
                                {
                                    que.Enqueue((p.Position.row - i, p.Position.col));
                                }
                                else
                                {
                                    down = false;
                                }
                            }
                        }
                        //right
                        while (right)
                        {
                            for (int i = 1; i < 8; i++)
                            {
                                if ((ChessBoard[p.Position.row, p.Position.col + i] == null) || ChessBoard[p.Position.row, p.Position.col + i].IsWhite != p.IsWhite)
                                {
                                    que.Enqueue((p.Position.row, p.Position.col + i));
                                }
                                else
                                {
                                    right = false;
                                }
                            }
                        }
                        //left
                        while (left)
                        {
                            for (int i = 1; i < 8; i++)
                            {
                                if ((ChessBoard[p.Position.row, p.Position.col - i] == null) || ChessBoard[p.Position.row, p.Position.col - i].IsWhite != p.IsWhite)
                                {
                                    que.Enqueue((p.Position.row, p.Position.col - i));
                                }
                                else
                                {
                                    left = false;
                                }
                            }
                        }
                        (int row, int col)[] moves = new (int row, int col)[que.Count];
                        for (int i = que.Count; i > 0; i--)
                        {
                            moves[i] = que.Dequeue();
                        }
                        return moves;
                    }
                case _queen://queen
                    {
                        Queue<(int row, int col)> que = new Queue<(int row, int col)>();
                        bool up = true;//up
                        bool down = true;//down
                        bool right = true;// right
                        bool left = true;// left
                        bool ur = true;//up right
                        bool ul = true;//up left
                        bool dr = true;// down right
                        bool dl = true;// down left
                        //each while stops when it encounter a piece and if it is the opposite color it adds to the queue
                        //up 
                        while (up)
                        {
                            for (int i = 1; i < 8; i++)
                            {
                                if ((ChessBoard[p.Position.row + i, p.Position.col] == null) || ChessBoard[p.Position.row + i, p.Position.col].IsWhite != p.IsWhite)
                                {
                                    que.Enqueue((p.Position.row + i, p.Position.col));
                                }

                                else
                                {
                                    up = false;
                                }
                            }
                        }
                        //down
                        while (down)
                        {
                            for (int i = 1; i < 8; i++)
                            {
                                if ((ChessBoard[p.Position.row - i, p.Position.col] == null) || ChessBoard[p.Position.row - i, p.Position.col].IsWhite != p.IsWhite)
                                {
                                    que.Enqueue((p.Position.row - i, p.Position.col));
                                }
                                else
                                {
                                    down = false;
                                }
                            }
                        }
                        //right
                        while (right)
                        {
                            for (int i = 1; i < 8; i++)
                            {
                                if ((ChessBoard[p.Position.row, p.Position.col + i] == null) || ChessBoard[p.Position.row, p.Position.col + i].IsWhite != p.IsWhite)
                                {
                                    que.Enqueue((p.Position.row, p.Position.col + i));
                                }
                                else
                                {
                                    right = false;
                                }
                            }
                        }
                        //left
                        while (left)
                        {
                            for (int i = 1; i < 8; i++)
                            {
                                if ((ChessBoard[p.Position.row, p.Position.col - i] == null) || ChessBoard[p.Position.row, p.Position.col - i].IsWhite != p.IsWhite)
                                {
                                    que.Enqueue((p.Position.row, p.Position.col - i));
                                }
                                else
                                {
                                    left = false;
                                }
                            }
                        }
                        //up right
                        while (ur)
                        {
                            for (int i = 1; i < 8; i++)
                            {
                                if ((ChessBoard[p.Position.row + i, p.Position.col + i] == null) || ChessBoard[p.Position.row + i, p.Position.col + i].IsWhite != p.IsWhite)
                                {
                                    que.Enqueue((p.Position.row + i, p.Position.col + i));
                                }
                                else
                                {
                                    ur = false;
                                }
                            }
                        }
                        //up left
                        while (ul)
                        {
                            for (int i = 1; i < 8; i++)
                            {
                                if ((ChessBoard[p.Position.row + i, p.Position.col - i] == null) || ChessBoard[p.Position.row + i, p.Position.col - i].IsWhite != p.IsWhite)
                                {
                                    que.Enqueue((p.Position.row + i, p.Position.col - i));
                                }
                                else
                                {
                                    ul = false;
                                }
                            }
                        }
                        //down right
                        while (dr)
                        {
                            for (int i = 1; i < 8; i++)
                            {
                                if ((ChessBoard[p.Position.row - i, p.Position.col + i] == null) || ChessBoard[p.Position.row - i, p.Position.col + i].IsWhite != p.IsWhite)
                                {
                                    que.Enqueue((p.Position.row - i, p.Position.col + i));
                                }
                                else
                                {
                                    dr = false;
                                }
                            }
                        }
                        //down left
                        while (dl)
                        {
                            for (int i = 1; i < 8; i++)
                            {
                                if ((ChessBoard[p.Position.row - i, p.Position.col - i] == null) || ChessBoard[p.Position.row - i, p.Position.col - i].IsWhite != p.IsWhite)
                                {
                                    que.Enqueue((p.Position.row - i, p.Position.col - i));
                                }
                                else
                                {
                                    dl = false;
                                }
                            }
                        }
                        (int row, int col)[] moves = new (int row, int col)[que.Count];
                        for (int i = que.Count; i > 0; i--)
                        {
                            moves[i] = que.Dequeue();
                        }
                        return moves;
                    }
                case _king:
                    {
                        Queue<(int row, int col)> que = new Queue<(int row, int col)>();
                        (int row, int col)[] spots = new (int row, int col)[7];
                        spots[0] = (p.Position.row + 1, p.Position.col);//up
                        spots[1] = (p.Position.row - 1, p.Position.col);//down
                        spots[2] = (p.Position.row, p.Position.col + 1);//right
                        spots[3] = (p.Position.row, p.Position.col - 1);//left
                        spots[4] = (p.Position.row + 1, p.Position.col + 1);//up right
                        spots[5] = (p.Position.row + 1, p.Position.col - 1);//up left
                        spots[6] = (p.Position.row - 1, p.Position.col + 1);//down
                        spots[7] = (p.Position.row - 1, p.Position.col - 1);//down left

                        foreach ((int row, int col) spot in spots)
                        {
                            if ((ChessBoard[spot.row, spot.col] == null) || ChessBoard[spot.row, spot.col].IsWhite != p.IsWhite)
                            {
                                que.Enqueue((spot));
                            }
                        }

                        (int row, int col)[] moves = new (int row, int col)[que.Count];
                        for (int i = que.Count; i > 0; i--)
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
        /// <returns>True if valid, false if not.</returns>
        private bool IsValid(Piece p, int row, int col)
        {
            if (row < _boardLength && col < _boardLength)
            {
                if (ChessBoard[row, col] != null)
                {
                    if (((p.IsWhite && ChessBoard[row, col].IsWhite) || !p.IsWhite && !ChessBoard[row, col].IsWhite)
                        && ChessBoard[row, col] == p)
                    {
                        return false;
                    }
                    else
                    {
                        return true;
                    }
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
