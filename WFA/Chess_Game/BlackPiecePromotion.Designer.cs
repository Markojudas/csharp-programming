namespace PA6_Draft
{
    partial class BlackPiecePromotion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.knight = new System.Windows.Forms.PictureBox();
            this.rook = new System.Windows.Forms.PictureBox();
            this.bishop = new System.Windows.Forms.PictureBox();
            this.queen = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.knight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rook)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bishop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.queen)).BeginInit();
            this.SuspendLayout();
            // 
            // knight
            // 
            this.knight.Image = global::PA6_Draft.Properties.Resources.bkn;
            this.knight.Location = new System.Drawing.Point(22, 21);
            this.knight.Name = "knight";
            this.knight.Size = new System.Drawing.Size(100, 50);
            this.knight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.knight.TabIndex = 0;
            this.knight.TabStop = false;
            this.knight.Click += new System.EventHandler(this.knight_Click);
            // 
            // rook
            // 
            this.rook.Image = global::PA6_Draft.Properties.Resources.br;
            this.rook.Location = new System.Drawing.Point(22, 77);
            this.rook.Name = "rook";
            this.rook.Size = new System.Drawing.Size(100, 50);
            this.rook.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.rook.TabIndex = 1;
            this.rook.TabStop = false;
            this.rook.Click += new System.EventHandler(this.rook_Click);
            // 
            // bishop
            // 
            this.bishop.Image = global::PA6_Draft.Properties.Resources.bb;
            this.bishop.Location = new System.Drawing.Point(22, 133);
            this.bishop.Name = "bishop";
            this.bishop.Size = new System.Drawing.Size(100, 50);
            this.bishop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bishop.TabIndex = 2;
            this.bishop.TabStop = false;
            this.bishop.Click += new System.EventHandler(this.bishop_Click);
            // 
            // queen
            // 
            this.queen.Image = global::PA6_Draft.Properties.Resources.bq;
            this.queen.Location = new System.Drawing.Point(22, 189);
            this.queen.Name = "queen";
            this.queen.Size = new System.Drawing.Size(100, 50);
            this.queen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.queen.TabIndex = 3;
            this.queen.TabStop = false;
            this.queen.Click += new System.EventHandler(this.queen_Click);
            // 
            // BlackPiecePromotion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(145, 261);
            this.Controls.Add(this.queen);
            this.Controls.Add(this.bishop);
            this.Controls.Add(this.rook);
            this.Controls.Add(this.knight);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BlackPiecePromotion";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            ((System.ComponentModel.ISupportInitialize)(this.knight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rook)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bishop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.queen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox knight;
        private System.Windows.Forms.PictureBox rook;
        private System.Windows.Forms.PictureBox bishop;
        private System.Windows.Forms.PictureBox queen;
    }
}