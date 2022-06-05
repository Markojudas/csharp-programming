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
    public partial class BlackPiecePromotion : Form
    {
        internal Promotion chosenPiece;
        public BlackPiecePromotion()
        {
            InitializeComponent();
            chosenPiece = (Promotion)Piece.BPAWN;
        }

        private void knight_Click(object sender, EventArgs e)
        {
            chosenPiece = Promotion.BKNIGHT;
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void rook_Click(object sender, EventArgs e)
        {
            chosenPiece = Promotion.BROOK;
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void bishop_Click(object sender, EventArgs e)
        {
            chosenPiece = Promotion.BROOK;
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void queen_Click(object sender, EventArgs e)
        {
            chosenPiece = Promotion.BQUEEN;
            DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
