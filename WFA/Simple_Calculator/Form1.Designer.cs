
namespace Calculator_Example
{
    partial class calculator_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(calculator_form));
            this.display = new System.Windows.Forms.TextBox();
            this.seven = new System.Windows.Forms.Button();
            this.eight = new System.Windows.Forms.Button();
            this.divition = new System.Windows.Forms.Button();
            this.nine = new System.Windows.Forms.Button();
            this.four = new System.Windows.Forms.Button();
            this.five = new System.Windows.Forms.Button();
            this.six = new System.Windows.Forms.Button();
            this.one = new System.Windows.Forms.Button();
            this.two = new System.Windows.Forms.Button();
            this.three = new System.Windows.Forms.Button();
            this.zero = new System.Windows.Forms.Button();
            this.multiplication = new System.Windows.Forms.Button();
            this.subtraction = new System.Windows.Forms.Button();
            this.addition = new System.Windows.Forms.Button();
            this.result = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.dot = new System.Windows.Forms.Button();
            this.Left_P = new System.Windows.Forms.Button();
            this.Right_P = new System.Windows.Forms.Button();
            this.sign = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // display
            // 
            this.display.Enabled = false;
            this.display.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.display.Location = new System.Drawing.Point(27, 26);
            this.display.Multiline = true;
            this.display.Name = "display";
            this.display.Size = new System.Drawing.Size(226, 81);
            this.display.TabIndex = 0;
            this.display.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // seven
            // 
            this.seven.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.seven.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seven.Location = new System.Drawing.Point(27, 165);
            this.seven.Name = "seven";
            this.seven.Size = new System.Drawing.Size(52, 45);
            this.seven.TabIndex = 1;
            this.seven.Text = "7";
            this.seven.UseVisualStyleBackColor = false;
            this.seven.Click += new System.EventHandler(this.Button_Click);
            // 
            // eight
            // 
            this.eight.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.eight.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eight.Location = new System.Drawing.Point(85, 165);
            this.eight.Name = "eight";
            this.eight.Size = new System.Drawing.Size(52, 45);
            this.eight.TabIndex = 2;
            this.eight.Text = "8";
            this.eight.UseVisualStyleBackColor = false;
            this.eight.Click += new System.EventHandler(this.Button_Click);
            // 
            // divition
            // 
            this.divition.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.divition.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.divition.Location = new System.Drawing.Point(201, 113);
            this.divition.Name = "divition";
            this.divition.Size = new System.Drawing.Size(52, 45);
            this.divition.TabIndex = 3;
            this.divition.Text = "/";
            this.divition.UseVisualStyleBackColor = false;
            this.divition.Click += new System.EventHandler(this.Button_Click);
            // 
            // nine
            // 
            this.nine.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.nine.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nine.Location = new System.Drawing.Point(143, 165);
            this.nine.Name = "nine";
            this.nine.Size = new System.Drawing.Size(52, 45);
            this.nine.TabIndex = 4;
            this.nine.Text = "9";
            this.nine.UseVisualStyleBackColor = false;
            this.nine.Click += new System.EventHandler(this.Button_Click);
            // 
            // four
            // 
            this.four.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.four.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.four.Location = new System.Drawing.Point(27, 216);
            this.four.Name = "four";
            this.four.Size = new System.Drawing.Size(52, 45);
            this.four.TabIndex = 5;
            this.four.Text = "4";
            this.four.UseVisualStyleBackColor = false;
            this.four.Click += new System.EventHandler(this.Button_Click);
            // 
            // five
            // 
            this.five.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.five.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.five.Location = new System.Drawing.Point(85, 215);
            this.five.Name = "five";
            this.five.Size = new System.Drawing.Size(52, 45);
            this.five.TabIndex = 6;
            this.five.Text = "5";
            this.five.UseVisualStyleBackColor = false;
            this.five.Click += new System.EventHandler(this.Button_Click);
            // 
            // six
            // 
            this.six.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.six.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.six.Location = new System.Drawing.Point(143, 216);
            this.six.Name = "six";
            this.six.Size = new System.Drawing.Size(52, 45);
            this.six.TabIndex = 7;
            this.six.Text = "6";
            this.six.UseVisualStyleBackColor = false;
            this.six.Click += new System.EventHandler(this.Button_Click);
            // 
            // one
            // 
            this.one.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.one.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.one.Location = new System.Drawing.Point(27, 266);
            this.one.Name = "one";
            this.one.Size = new System.Drawing.Size(52, 45);
            this.one.TabIndex = 8;
            this.one.Text = "1";
            this.one.UseVisualStyleBackColor = false;
            this.one.Click += new System.EventHandler(this.Button_Click);
            // 
            // two
            // 
            this.two.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.two.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.two.Location = new System.Drawing.Point(85, 266);
            this.two.Name = "two";
            this.two.Size = new System.Drawing.Size(52, 45);
            this.two.TabIndex = 9;
            this.two.Text = "2";
            this.two.UseVisualStyleBackColor = false;
            this.two.Click += new System.EventHandler(this.Button_Click);
            // 
            // three
            // 
            this.three.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.three.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.three.Location = new System.Drawing.Point(143, 267);
            this.three.Name = "three";
            this.three.Size = new System.Drawing.Size(52, 45);
            this.three.TabIndex = 10;
            this.three.Text = "3";
            this.three.UseVisualStyleBackColor = false;
            this.three.Click += new System.EventHandler(this.Button_Click);
            // 
            // zero
            // 
            this.zero.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.zero.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zero.Location = new System.Drawing.Point(85, 317);
            this.zero.Name = "zero";
            this.zero.Size = new System.Drawing.Size(52, 45);
            this.zero.TabIndex = 11;
            this.zero.Text = "0";
            this.zero.UseVisualStyleBackColor = false;
            this.zero.Click += new System.EventHandler(this.Button_Click);
            // 
            // multiplication
            // 
            this.multiplication.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.multiplication.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.multiplication.Location = new System.Drawing.Point(201, 164);
            this.multiplication.Name = "multiplication";
            this.multiplication.Size = new System.Drawing.Size(52, 45);
            this.multiplication.TabIndex = 12;
            this.multiplication.Text = "*";
            this.multiplication.UseVisualStyleBackColor = false;
            this.multiplication.Click += new System.EventHandler(this.Button_Click);
            // 
            // subtraction
            // 
            this.subtraction.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.subtraction.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subtraction.Location = new System.Drawing.Point(201, 215);
            this.subtraction.Name = "subtraction";
            this.subtraction.Size = new System.Drawing.Size(52, 45);
            this.subtraction.TabIndex = 13;
            this.subtraction.Text = "-";
            this.subtraction.UseVisualStyleBackColor = false;
            this.subtraction.Click += new System.EventHandler(this.Button_Click);
            // 
            // addition
            // 
            this.addition.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.addition.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addition.Location = new System.Drawing.Point(201, 266);
            this.addition.Name = "addition";
            this.addition.Size = new System.Drawing.Size(52, 45);
            this.addition.TabIndex = 14;
            this.addition.Text = "+";
            this.addition.UseVisualStyleBackColor = false;
            this.addition.Click += new System.EventHandler(this.Button_Click);
            // 
            // result
            // 
            this.result.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.result.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.result.Location = new System.Drawing.Point(201, 318);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(52, 43);
            this.result.TabIndex = 15;
            this.result.Text = "=";
            this.result.UseVisualStyleBackColor = false;
            this.result.Click += new System.EventHandler(this.Calc_Click);
            // 
            // clear
            // 
            this.clear.BackColor = System.Drawing.Color.Brown;
            this.clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear.Location = new System.Drawing.Point(27, 113);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(52, 45);
            this.clear.TabIndex = 16;
            this.clear.Text = "C";
            this.clear.UseVisualStyleBackColor = false;
            this.clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // dot
            // 
            this.dot.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.dot.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dot.Location = new System.Drawing.Point(27, 317);
            this.dot.Name = "dot";
            this.dot.Size = new System.Drawing.Size(52, 45);
            this.dot.TabIndex = 17;
            this.dot.Text = ".";
            this.dot.UseVisualStyleBackColor = false;
            this.dot.Click += new System.EventHandler(this.Button_Click);
            // 
            // Left_P
            // 
            this.Left_P.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.Left_P.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Left_P.Location = new System.Drawing.Point(85, 113);
            this.Left_P.Name = "Left_P";
            this.Left_P.Size = new System.Drawing.Size(52, 45);
            this.Left_P.TabIndex = 18;
            this.Left_P.Text = "(";
            this.Left_P.UseVisualStyleBackColor = false;
            this.Left_P.Click += new System.EventHandler(this.Button_Click);
            // 
            // Right_P
            // 
            this.Right_P.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.Right_P.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Right_P.Location = new System.Drawing.Point(143, 114);
            this.Right_P.Name = "Right_P";
            this.Right_P.Size = new System.Drawing.Size(52, 45);
            this.Right_P.TabIndex = 19;
            this.Right_P.Text = ")";
            this.Right_P.UseVisualStyleBackColor = false;
            this.Right_P.Click += new System.EventHandler(this.Button_Click);
            // 
            // sign
            // 
            this.sign.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.sign.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sign.Location = new System.Drawing.Point(143, 318);
            this.sign.Name = "sign";
            this.sign.Size = new System.Drawing.Size(52, 45);
            this.sign.TabIndex = 20;
            this.sign.Text = "+/-";
            this.sign.UseVisualStyleBackColor = false;
            this.sign.Click += new System.EventHandler(this.Sign_Change);
            // 
            // calculator_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(280, 389);
            this.Controls.Add(this.sign);
            this.Controls.Add(this.Right_P);
            this.Controls.Add(this.Left_P);
            this.Controls.Add(this.dot);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.result);
            this.Controls.Add(this.addition);
            this.Controls.Add(this.subtraction);
            this.Controls.Add(this.multiplication);
            this.Controls.Add(this.zero);
            this.Controls.Add(this.three);
            this.Controls.Add(this.two);
            this.Controls.Add(this.one);
            this.Controls.Add(this.six);
            this.Controls.Add(this.five);
            this.Controls.Add(this.four);
            this.Controls.Add(this.nine);
            this.Controls.Add(this.divition);
            this.Controls.Add(this.eight);
            this.Controls.Add(this.seven);
            this.Controls.Add(this.display);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "calculator_form";
            this.Text = "Calculator v1.0";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox display;
        private System.Windows.Forms.Button seven;
        private System.Windows.Forms.Button eight;
        private System.Windows.Forms.Button divition;
        private System.Windows.Forms.Button nine;
        private System.Windows.Forms.Button four;
        private System.Windows.Forms.Button five;
        private System.Windows.Forms.Button six;
        private System.Windows.Forms.Button one;
        private System.Windows.Forms.Button two;
        private System.Windows.Forms.Button three;
        private System.Windows.Forms.Button zero;
        private System.Windows.Forms.Button multiplication;
        private System.Windows.Forms.Button subtraction;
        private System.Windows.Forms.Button addition;
        private System.Windows.Forms.Button result;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button dot;
        private System.Windows.Forms.Button Left_P;
        private System.Windows.Forms.Button Right_P;
        private System.Windows.Forms.Button sign;
    }
}

