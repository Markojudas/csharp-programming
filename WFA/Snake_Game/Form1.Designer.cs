namespace PA5_Draft
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.Field = new System.Windows.Forms.PictureBox();
            this.mainTimer = new System.Windows.Forms.Timer(this.components);
            this.stateBar = new System.Windows.Forms.ToolStrip();
            this.step_lbl = new System.Windows.Forms.ToolStripLabel();
            this.step_pro_bar = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.num_eaten_apples_lbl = new System.Windows.Forms.ToolStripLabel();
            this.num_eaten_apples = new System.Windows.Forms.ToolStripLabel();
            ((System.ComponentModel.ISupportInitialize)(this.Field)).BeginInit();
            this.stateBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // Field
            // 
            this.Field.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Field.Location = new System.Drawing.Point(0, 0);
            this.Field.Name = "Field";
            this.Field.Size = new System.Drawing.Size(604, 581);
            this.Field.TabIndex = 0;
            this.Field.TabStop = false;
            this.Field.Click += new System.EventHandler(this.Field_Click);
            this.Field.Paint += new System.Windows.Forms.PaintEventHandler(this.Field_Paint);
            // 
            // mainTimer
            // 
            this.mainTimer.Enabled = true;
            this.mainTimer.Interval = 12;
            this.mainTimer.Tick += new System.EventHandler(this.MainTimer_Tick);
            // 
            // stateBar
            // 
            this.stateBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.stateBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.step_lbl,
            this.step_pro_bar,
            this.toolStripSeparator1,
            this.num_eaten_apples_lbl,
            this.num_eaten_apples});
            this.stateBar.Location = new System.Drawing.Point(0, 556);
            this.stateBar.Name = "stateBar";
            this.stateBar.Size = new System.Drawing.Size(604, 25);
            this.stateBar.TabIndex = 1;
            this.stateBar.Text = "toolStrip1";
            // 
            // step_lbl
            // 
            this.step_lbl.Name = "step_lbl";
            this.step_lbl.Size = new System.Drawing.Size(33, 22);
            this.step_lbl.Text = "Step:";
            // 
            // step_pro_bar
            // 
            this.step_pro_bar.Maximum = 10;
            this.step_pro_bar.Name = "step_pro_bar";
            this.step_pro_bar.Size = new System.Drawing.Size(100, 22);
            this.step_pro_bar.Step = 1;
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // num_eaten_apples_lbl
            // 
            this.num_eaten_apples_lbl.Name = "num_eaten_apples_lbl";
            this.num_eaten_apples_lbl.Size = new System.Drawing.Size(78, 22);
            this.num_eaten_apples_lbl.Text = "Apples Eaten:";
            // 
            // num_eaten_apples
            // 
            this.num_eaten_apples.Name = "num_eaten_apples";
            this.num_eaten_apples.Size = new System.Drawing.Size(0, 22);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 581);
            this.Controls.Add(this.stateBar);
            this.Controls.Add(this.Field);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(620, 620);
            this.MinimumSize = new System.Drawing.Size(620, 620);
            this.Name = "MainForm";
            this.Text = "Snakes";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Snakes_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.Field)).EndInit();
            this.stateBar.ResumeLayout(false);
            this.stateBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Field;
        private System.Windows.Forms.Timer mainTimer;
        private System.Windows.Forms.ToolStrip stateBar;
        private System.Windows.Forms.ToolStripLabel step_lbl;
        private System.Windows.Forms.ToolStripProgressBar step_pro_bar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel num_eaten_apples_lbl;
        private System.Windows.Forms.ToolStripLabel num_eaten_apples;
    }
}

