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
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        private static int[,] matrixA = new int[3, 3];
        private static int[,] matrixB = new int[3, 3];
        private static int[,] resultMatrix = new int[3, 3];
        private void btnAddMatrixes_Click(object sender, EventArgs e)
        {            
            initMatrix(groupBox1, matrixA);
            initMatrix(groupBox2, matrixB);

            resultMatrix = MatrixHandler.addMatrixes(matrixA, matrixB);

            // print result matrix to user 
            printResultMatrix(resultMatrix);
            
        }

        private void btnSubMatrixes_Click(object sender, EventArgs e)
        {
            initMatrix(groupBox1, matrixA);
            initMatrix(groupBox2, matrixB);

            resultMatrix = MatrixHandler.subMatrixes(matrixA, matrixB);

            // print result matrix to user 
            printResultMatrix(resultMatrix);                      

        }

        private void testPrintArray2d(int[,] arr2d)
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

        // loop thru textboxes and take input
        private void initMatrix(GroupBox gBox, int[,] arr2d)
        {
            string gBoxName = choseGroupBox(gBox);

            foreach (Control c in gBox.Controls)
            {
                if (c is TextBox)
                {
                    // nested loop that checks what is the name of the currect textbox, and assigns textbox value to matching arr2d element.
                    // the problem - the algorithm may have too big of a Big O complication
                    for (int i = 0; i < arr2d.GetLength(0); i++)
                    {
                        for (int j = 0; j < arr2d.GetLength(1); j++)
                        {
                            if (c.Name == (gBoxName + (i + 1).ToString() + "_" + (j + 1).ToString()))
                            {
                                arr2d[i, j] = int.Parse(c.Text);
                            }
                        }
                    }

                }
            }
        }
        // adjust name of groupBox - textboxes to: name of groupbox
        private string choseGroupBox(GroupBox gbox)
        {
            if (gbox.Name == "groupBox1")
            {
                return "txtMatrixA";
            }
            else if (gbox.Name == "groupBox2")
            {
                return "txtMatrixB";
            }
            else if (gbox.Name == "groupBox3")
            {
                return "txtResultMatrix";
            }
            else
            {
                return "ERROR";
                string message = "ERROR in function \"choseGroupBox(GroupBox gbox)\",\n Entered parameter does not match.";
                MessageBox.Show(message);
            }
        }

        private void printResultMatrix (int[,] arr2d)
        {
            for (int i = 0; i < arr2d.GetLength(0); i++)
            {
                for (int j = 0; j < arr2d.GetLength(1); j++)
                {
                    foreach (Control c in groupBox3.Controls)
                    {
                        if (c is TextBox)
                        { 
                            if (c.Name == ("txtResultMatrix" + (i + 1).ToString() + "_" + (j + 1).ToString()))
                            {
                                c.Text = arr2d[i, j].ToString();
                            }
                        }
                    }
                }
                
            }
            
        }

        private void btnMultiMatrixes_Click(object sender, EventArgs e)
        {
            initMatrix(groupBox1, matrixA);
            initMatrix(groupBox2, matrixB);

            resultMatrix = MatrixHandler.multiMatrixes(matrixA, matrixB);

            printResultMatrix(resultMatrix);
        }
    }
}
