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
    public partial class gausElimUserControl : UserControl
    {
        public gausElimUserControl()
        {
            InitializeComponent();
        }

        private static double[,] arr2d = new double[3, 4];

        private void btnEliminate_Click(object sender, EventArgs e)
        {
            testPrintArray2d(arr2d);
        }

        private void initMatrix(GroupBox gBox, double[,] arr2d)
        {            

            foreach (Control c in gBox.Controls)
            {
                if (c is TextBox)
                {                   
                    for (int i = 0; i < arr2d.GetLength(0); i++)
                    {
                        for (int j = 0; j < arr2d.GetLength(1); j++)
                        {
                            if (c.Name == ("txtMatrixA" + (i + 1).ToString() + "_" + (j + 1).ToString()))
                            {
                                arr2d[i, j] = int.Parse(c.Text);
                            }
                        }
                    }

                }
            }
        }

        private void testPrintArray2d(double[,] arr2d)
        {
            for (int i = 0; i < arr2d.GetLength(0); i++)
            {
                for (int j = 0; j < arr2d.GetLength(1); j++)
                {
                    testTextBox.Text += arr2d[i, j];
                }
                testTextBox.Text += "\n n ";
            }
            testTextBox.Text += " NEXT arr: ";
        }
    }
}
