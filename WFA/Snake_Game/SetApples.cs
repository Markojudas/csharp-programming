using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PA5_Draft
{
    public partial class SetApples : Form
    {
        public int num_of_apples;
        public SetApples()
        {
            InitializeComponent();
        }

        private void ok_Click(object sender, EventArgs e)
        {
            num_of_apples = (int)num_apples_nud.Value;
        }
    }
}
