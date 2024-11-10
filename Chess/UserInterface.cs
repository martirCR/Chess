/* Userinterface.cs
 * Author: Thomas idk
 *         Martir Caceres Ramos
 *         Tim
*/


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
//using System.Threading.Tasks;


namespace Chess
{
    public partial class UserInterface : Form
    {
        private Board _board = new Board();

        private const int _boardLength = 8;

        private Piece[,] _pieceLocation = new Piece[_boardLength, _boardLength];

        private PiecePainter _piecePainter = new PiecePainter();

        private Label _currentSelected;

        private Dictionary<Label, Piece> _waaah = new Dictionary<Label, Piece>();

        private bool _whiteTurn = true;

        private Image _pawnBlackImage = Image.FromFile(@"..\..\..\Chess Pieces pngs\blackPawn.png");

        private Image _kingBlackImage = Image.FromFile(@"..\..\..\Chess Pieces pngs\blackKing.png");

        private Image _knightBlackImage = Image.FromFile(@"..\..\..\Chess Pieces pngs\blackKnight.png");

        private Image _bishopBlackImage = Image.FromFile(@"..\..\..\Chess Pieces pngs\blackBishop.png");

        private Image _queenBlackImage = Image.FromFile(@"..\..\..\Chess Pieces pngs\blackQueen.png");

        private Image _rookBlackImage = Image.FromFile(@"..\..\..\Chess Pieces pngs\blackRook.png");

        private Image _pawnWhiteImage = Image.FromFile(@"..\..\..\Chess Pieces pngs\whitePawn.png");

        private Image _bishopWhiteImage = Image.FromFile(@"..\..\..\Chess Pieces pngs\whiteBishop.png");

        private Image _kingWhiteImage = Image.FromFile(@"..\..\..\Chess Pieces pngs\whiteKing.png");

        private Image _knightWhiteImage = Image.FromFile(@"..\..\..\Chess Pieces pngs\whiteKnight.png");

        private Image _queenWhiteImage = Image.FromFile(@"..\..\..\Chess Pieces pngs\whiteQueen.png");

        private Image _rookWhiteImage = Image.FromFile(@"..\..\..\Chess Pieces pngs\whiteRook.png");


        public UserInterface()
        {
            InitializeComponent();
        }

        private void PlaceImages(Label l, Piece p)
        {
            switch (p.Rank)
            {
                case 0:
                    {
                        if (p.IsWhite)
                        {
                            l.Image = new Bitmap(_pawnWhiteImage, l.Size);


                        }
                        else
                        {
                            l.Image = new Bitmap(_pawnBlackImage, l.Size);
                        }
                        break;
                    }
                case 1:
                    {
                        if (p.IsWhite)
                        {
                            l.Image = new Bitmap(_bishopWhiteImage, l.Size);
                        }
                        else
                        {
                            l.Image = new Bitmap(_bishopBlackImage, l.Size);
                        }
                        break;
                    }
                case 2:
                    {
                        if (p.IsWhite)
                        {
                            l.Image = new Bitmap(_knightWhiteImage, l.Size);
                        }
                        else
                        {
                            l.Image = new Bitmap(_knightBlackImage, l.Size);
                        }
                        break;
                    }
                case 3:
                    {
                        if (p.IsWhite)
                        {
                            l.Image = new Bitmap(_rookWhiteImage, l.Size);
                        }
                        else
                        {
                            l.Image = new Bitmap(_rookBlackImage, l.Size);
                        }
                        break;
                    }
                case 4:
                    {
                        if (p.IsWhite)
                        {
                            l.Image = new Bitmap(_queenWhiteImage, l.Size);
                        }
                        else
                        {
                            l.Image = new Bitmap(_queenBlackImage, l.Size);
                        }
                        break;
                    }
                case 5:
                    {
                        if (p.IsWhite)
                        {
                            l.Image = new Bitmap(_kingWhiteImage, l.Size);
                        }
                        else
                        {
                            l.Image = new Bitmap(_kingBlackImage, l.Size);
                        }
                        break;
                    }
            }
        }

        private void MakeBoard()
        {
            bool isWhite = false;
            _waaah.Clear();
            uxChessBoard.Controls.Clear();

            for (int i = 0; i < _boardLength; i++)
            {
                for (int j = 0; j < _boardLength; j++)
                {
                    if (i % 2 == 0)
                    {
                        if (j % 2 == 0)
                        {
                            isWhite = false;
                        }
                        else
                        {
                            isWhite = true;
                        }
                    }
                    else
                    {
                        if (j % 2 == 0)
                        {
                            isWhite = true;
                        }
                        else
                        {
                            isWhite = false;
                        }
                    }
                    Label l = new Label();
                    l.Name = i.ToString() + j.ToString();
                    l.Width = uxChessBoard.Width / _boardLength;
                    l.Height = uxChessBoard.Height / _boardLength;
                    if (_board.ChessBoard[i, j] != null)
                    {
                        Piece p = _board.ChessBoard[i, j];
                        l.Font = new Font(FontFamily.GenericMonospace.ToString(), 16);
                        l.TextAlign = ContentAlignment.MiddleCenter;

                        //l.Text = p.Rank.ToString();
                        PlaceImages(l, p);

                        //l.Text = l.Name;


                        _waaah.Add(l, p);


                        /* if (p.Rank == 1)
                         {
                             Graphics g = 
                         }
                         else
                         {*/
                        //}
                    }


                    if (isWhite)
                    {
                        l.BackColor = Color.White;
                    }
                    else
                    {
                        l.BackColor = Color.Green;
                    }
                    l.BorderStyle = BorderStyle.FixedSingle;
                    l.Margin = Padding.Empty;
                    l.Click += ChessBoard;

                    uxChessBoard.Controls.Add(l);
                    // isWhite = !isWhite;
                }
            }
            Invalidate();
        }

        /// <summary>
        /// Handles the New Game Clicke event
        /// </summary>
        /// <param name="sender">The object signaling the event</param>
        /// <param name="e">Info on the event</param>
        private void NewClick(object sender, EventArgs e)
        {
            _board.SetPieces();
            uxTurnColor.Text = "White";


            MakeBoard();

        }

        /// <summary>
        /// Sets a label back to the default Label
        /// </summary>
        /// <param name="l">The label being set to default</param>
        private void DefaultLabel(Label l)
        {
            if (l.BackColor == Color.LightBlue)
            {
                l.BackColor = Color.White;
            }
            else
            {
                l.BackColor = Color.Green;
            }
            l.BorderStyle = BorderStyle.FixedSingle;
        }

        private void MovePiece(Label prevSelected, Label currentSelected)
        {
            Piece p;
            if (_waaah.TryGetValue(prevSelected, out p))
            {
                if (_whiteTurn)
                {
                    uxTurnColor.Text = "Black";
                    _whiteTurn = false;
                }
                else
                {
                    uxTurnColor.Text = "White";
                    _whiteTurn = true;
                }
                _waaah.Remove(prevSelected);
                int row = p.Position.row;
                int col = p.Position.col;
                //(int row, int col)[] validMoves = _board.ValidMove(p);


                string coordinates = currentSelected.Name;

                int currentRow = Convert.ToInt32(coordinates[0] - '0');
                int currentCol = Convert.ToInt32(coordinates[1] - '0');

                /*for (int i = 0; i < validMoves.Length; i++)
                {
                    if ((validMoves[i] == (currentRow, currentCol)))
                    {*/
                _board.ChessBoard[row, col] = null; // Needs MOve method.

                _board.ChessBoard[currentRow, currentCol] = p;
                p.Position = (currentRow, currentCol);
                //p.Start = false;
                /*
                                    }
                                }*/


                p.Position = (currentRow, currentCol);



                //_waaah.Add(currentSelected, p);

                MakeBoard();
            }
        }


        /// <summary>
        /// Changes colors of selected space
        /// </summary>
        /// <param name="sender">The object signaling the event</param>
        /// <param name="e">Info on the event</param>
        private void ChessBoard(object sender, EventArgs e)
        {
            Label l = (Label)sender;

            if (_currentSelected != null)
            {
                DefaultLabel(_currentSelected);
                MovePiece(_currentSelected, l);

            }

            if (l.BackColor == Color.White)
            {
                l.BackColor = Color.LightBlue;
                l.BorderStyle = BorderStyle.Fixed3D;
            }
            else if (l.BackColor == Color.Green)
            {
                l.BackColor = Color.DarkGreen;
                l.BorderStyle = BorderStyle.Fixed3D;
            }
            else
            {
                DefaultLabel(l);
            }
            string coordinates = l.Name;
            int currentRow = Convert.ToInt32(coordinates[0] - '0');
            int currentCol = Convert.ToInt32(coordinates[1] - '0');
            try
            {
                if ((_whiteTurn && !_board.ChessBoard[currentRow, currentCol].IsWhite) ||
                    (!_whiteTurn && _board.ChessBoard[currentRow, currentCol].IsWhite))
                {
                    DefaultLabel(l);
                }
                else
                {
                    _currentSelected = l;
                }
            }
            catch
            {
                DefaultLabel(l);
            }
        }
    }


}
