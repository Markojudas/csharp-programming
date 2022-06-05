using System;
using System.Data;
using System.Windows.Forms;

namespace Calculator_Example
{
    public partial class calculator_form : Form
    {
        public calculator_form()
        {
            InitializeComponent();
        }

        static bool equalflag;

        static bool Is_Operator(string text)
        {
            bool isOPerator = false;

            if(text == "+" || text == "-" || text == "*" || text == "/")
            {
                isOPerator = true;
            }

            return isOPerator;
        }

        private void Button_Click(object sender, EventArgs e)
        {
            
            if (equalflag && !Is_Operator(((Button)sender).Text))
            {
                display.Text = "";
            }
            display.Text += ((Button)sender).Text;
            equalflag = false;
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            display.Text = "";
            equalflag = false;
        }

        public static object Calc(string expression)
        {
            DataTable dt = new DataTable();
            var v = new object();
            try
            {
                v = dt.Compute(expression, "");
            }
            catch(Exception e)
            {
                v = "NaN";
            }

            return v;
        }

        private void Calc_Click(object sender, EventArgs e)
        {
            object results = Calc(display.Text);
            display.Text = results.ToString();
            equalflag = true;
        }

        private void Sign_Change(object sender, EventArgs e)
        {
            if (decimal.TryParse(display.Text, out decimal currentSign))
            {
                string newSign = (currentSign * -1).ToString();
                display.Text = newSign;
            }
        }
    }
}
