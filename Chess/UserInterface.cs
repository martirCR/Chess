/* Userinterface.cs
 * Author: Thomas idk
 *         Martir Caceres Ramos
 *         Tim
*/


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chess
{
    public partial class UserInterface : Form
    {
        private Board _board = new Board();

        private const int _boardLength = 8;

        private Piece[,] _pieceLocation = new Piece[_boardLength,_boardLength];


        public UserInterface()
        {
            InitializeComponent();
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
                    if (_board.ChessBoard[i, j] != null)
                    {
                        Piece p = _board.ChessBoard[i, j];
                        l.Text = p.Rank.ToString();
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
                    l.TextAlign = ContentAlignment.MiddleCenter;
                    l.Font = new Font(FontFamily.GenericMonospace.ToString(), 16);
                    l.Click += ChessBoard;
                    uxChessBoard.Controls.Add(l);
                   // isWhite = !isWhite;
                }
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
            if (l.BackColor == Color.AliceBlue)
            {
                l.BackColor = Color.White;
                l.BorderStyle = BorderStyle.Fixed3D;
            }
            else
            {
                l.BackColor = Color.AliceBlue;
                l.BorderStyle = BorderStyle.FixedSingle;
            }
        }
    }
    
    
}
