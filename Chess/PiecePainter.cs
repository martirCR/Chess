using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    public static class PiecePainter
    {
        /// <summary>
        /// The height of a single card image from the input files.
        /// </summary>
        private const int _cardImageHeight = 333;

        /// <summary>
        /// The width of a single card image from the input files.
        /// </summary>
        private const int _cardImageWidth = 234;

        /// <summary>
        /// The width, in pixels, of the line forming the highlight of a card.
        /// </summary>
        private const int _highlightWidth = 2;

        /// <summary>
        /// The pen used to draw the box where the stock will be placed.
        /// </summary>
        private static readonly Pen _boxPen = new(Color.White);

        /// <summary>
        /// The height of a displayed card drawing.
        /// </summary>
        public const int CardHeight = _cardImageHeight / 2;

        /// <summary>
        /// The width of a displayed card drawing.
        /// </summary>
        public const int CardWidth = _cardImageWidth / 2;

        /// <summary>
        /// Gets the back of a card.
        /// </summary>
        public static Image CardBack { get; } = Images.Back;

        /// <summary>
        /// Gets the pen used to highlight selected cards.
        /// </summary>
        public static Pen HighlightPen { get; } = new (Color.Magenta, _highlightWidth);

        /// <summary>
        /// Draws the back of a card on the given graphics context at the given location.
        /// </summary>
        /// <param name="g">The graphics context on which to draw.</param>
        /// <param name="x">The x-coordinate of the upper-left corner.</param>
        /// <param name="y">The y-coordinate of the upper-left corner.</param>
        public static void DrawBack(Graphics g, int x, int y)
        {
            g.DrawImage(CardBack, x, y, CardWidth, CardHeight);
        }
    }
}
