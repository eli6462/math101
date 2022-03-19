using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3__matrix_calculator_
{
    public partial class FuncUserControl : UserControl
    {
        public FuncUserControl()
        {
            InitializeComponent();
            inputBox.Text = "1x^2+5x+6=0";
        }

        private void resolveBtn_Click(object sender, EventArgs e)
        {
            int[] args;

            args=FunctionHandler.ParseInput(inputBox.Text);
            int a = args[0];
            int b = args[1];
            int c = args[2];



            String sol = FunctionHandler.SolveQuad(a, b, c);

            resultBox.Text = sol;

        }
    }
}
