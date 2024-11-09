using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    public class PiecePainter
    {
        /// <summary>
        /// The height of a single card image from the input files.
        /// </summary>
        public int PieceImageHeight { get; set; }

        /// <summary>
        /// The width of a single card image from the input files.
        /// </summary>
        public int PieceImageWidth { get; set; }

        /// <summary>
        /// The width, in pixels, of the line forming the highlight of a card.
        /// </summary>
        private const int _highlightWidth = 2;        
        
        /// <summary>
        /// The height of a displayed card drawing.
        /// </summary>
        //public const int PieceHeight = _pieceImageHeight / 2;

        /// <summary>
        /// The width of a displayed card drawing.
        /// </summary>
        //public const int PieceWidth = _pieceImageWidth / 2;

        /// <summary>
        /// Gets the pen used to highlight selected cards.
        /// </summary>
        public Pen HighlightPen { get; } = new Pen(Color.Magenta, _highlightWidth);

        public Image newImage = Image.FromFile("C:\\Users\\odoro\\source\\repos\\Chess\\Chess\\Chess Pieces pngs\\black-chess-bishop-stroke-png-5694544.png");

        /// <summary>
        /// Draws the back of a card on the given graphics context at the given location.
        /// </summary>
        /// <param name="g">The graphics context on which to draw.</param>
        /// <param name="x">The x-coordinate of the upper-left corner.</param>
        /// <param name="y">The y-coordinate of the upper-left corner.</param>
        public void DrawPiece(Graphics g, int x, int y)
        {
            g.DrawImage(newImage,0,0);
        }
        
    }
}
