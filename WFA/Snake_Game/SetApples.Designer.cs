
namespace PA5_Draft
{
    partial class SetApples
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
            this.num_apples_nud = new System.Windows.Forms.NumericUpDown();
            this.setApples_lbl = new System.Windows.Forms.Label();
            this.ok = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.num_apples_nud)).BeginInit();
            this.SuspendLayout();
            // 
            // num_apples_nud
            // 
            this.num_apples_nud.Location = new System.Drawing.Point(182, 28);
            this.num_apples_nud.Maximum = new decimal(new int[] {
            1999,
            0,
            0,
            0});
            this.num_apples_nud.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.num_apples_nud.Name = "num_apples_nud";
            this.num_apples_nud.Size = new System.Drawing.Size(50, 20);
            this.num_apples_nud.TabIndex = 0;
            this.num_apples_nud.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // setApples_lbl
            // 
            this.setApples_lbl.AutoSize = true;
            this.setApples_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.setApples_lbl.Location = new System.Drawing.Point(44, 28);
            this.setApples_lbl.Name = "setApples_lbl";
            this.setApples_lbl.Size = new System.Drawing.Size(132, 16);
            this.setApples_lbl.TabIndex = 1;
            this.setApples_lbl.Text = "Number of Apples";
            // 
            // ok
            // 
            this.ok.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.ok.Location = new System.Drawing.Point(56, 93);
            this.ok.Name = "ok";
            this.ok.Size = new System.Drawing.Size(75, 23);
            this.ok.TabIndex = 2;
            this.ok.Text = "OK";
            this.ok.UseVisualStyleBackColor = true;
            this.ok.Click += new System.EventHandler(this.ok_Click);
            // 
            // cancel
            // 
            this.cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancel.Location = new System.Drawing.Point(157, 93);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(75, 23);
            this.cancel.TabIndex = 3;
            this.cancel.Text = "Cancel";
            this.cancel.UseVisualStyleBackColor = true;
            // 
            // SetApples
            // 
            this.AcceptButton = this.ok;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.CancelButton = this.cancel;
            this.ClientSize = new System.Drawing.Size(277, 145);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.ok);
            this.Controls.Add(this.setApples_lbl);
            this.Controls.Add(this.num_apples_nud);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MinimizeBox = false;
            this.Name = "SetApples";
            this.ShowIcon = false;
            this.Text = "Set Number of Apples";
            ((System.ComponentModel.ISupportInitialize)(this.num_apples_nud)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown num_apples_nud;
        private System.Windows.Forms.Label setApples_lbl;
        private System.Windows.Forms.Button ok;
        private System.Windows.Forms.Button cancel;
    }
}