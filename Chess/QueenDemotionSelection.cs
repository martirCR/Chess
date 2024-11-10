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
    public partial class QueenDemotionSelection : Form
    {
        public int PieceDemotion { get; private set; }

        public QueenDemotionSelection()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxBishop_Click(object sender, EventArgs e)
        {
            PieceDemotion = 1;
        }

        private void uxRook_Click(object sender, EventArgs e)
        {
            PieceDemotion = 2;
        }

        private void uxKnight_Click(object sender, EventArgs e)
        {
            PieceDemotion = 3;
        }
    }
}
