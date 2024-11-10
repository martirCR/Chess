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

        public UserInterface()
        {
            InitializeComponent();
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
                    if (_board.ChessBoard[i, j] != null)
                    {
                        Piece p = _board.ChessBoard[i, j];
                        l.Font = new Font(FontFamily.GenericMonospace.ToString(), 16);
                        l.TextAlign = ContentAlignment.MiddleCenter;

                        l.Text = p.Rank.ToString();
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
                    l.Width = uxChessBoard.Width / _boardLength;
                    l.Height = uxChessBoard.Height / _boardLength;
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
            //uxTurnColor.Text = "White";
            _board.SetPieces();

            bool isWhite = false;

           
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

        private void MovePiece(Label l)
        {
            Piece p;
            if (_waaah.TryGetValue(l, out p))
            {
                int row = p.Position.row;
                int col = p.Position.col;

                p.Position = (row + 1, col);

                _board.ChessBoard[row, col] = null; // Needs MOve method.
                _board.ChessBoard[row + 1, col] = p;

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
                MovePiece(_currentSelected);

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



            _currentSelected = l;
        }
    }


}
