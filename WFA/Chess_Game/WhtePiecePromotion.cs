using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PA6_Draft
{
    public partial class WhtePiecePromotion : Form
    {
        internal Promotion chosenPiece;
        public WhtePiecePromotion()
        {
            InitializeComponent();
            chosenPiece = (Promotion)Piece.WPAWN;
        }

        private void knight_Click(object sender, EventArgs e)
        {
            chosenPiece = Promotion.WKNIGHT;
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void rook_Click(object sender, EventArgs e)
        {
            chosenPiece = Promotion.WROOK;
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void bishop_Click(object sender, EventArgs e)
        {
            chosenPiece = Promotion.WBISHOP;
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void queen_Click(object sender, EventArgs e)
        {
            chosenPiece = Promotion.WQUEEN;
            DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
