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
    public partial class Form2 : Form
    {
        private static int[,] matrixA = new int[3, 3];
        public Form2()
        {
            InitializeComponent();
        }

        // loop thru textboxes
        

        private void initMatrix(GroupBox gBox, int[,] arr2d)
        {
            int i = 0, j = 0;

            foreach (Control c in gBox.Controls)
            {
                if (c is TextBox)                                    
                {
                    arr2d[i,j] = int.Parse(c.Text);

                    // this code loops thru all indexes of arr2d (all possible i AND j combinations)
                    if (j < arr2d.GetLength(1)-1 && i <= arr2d.GetLength(0)-1)
                    {
                        j++;
                    }
                    else if (j >= arr2d.GetLength(1)-1 && i <= arr2d.GetLength(0)-2)
                    {
                        j = 0;
                        i++;
                    }
                    else
                        break;
                }
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }        
        private void button1_Click(object sender, EventArgs e)
        {
            initMatrix(groupBox2, matrixA);

            //test
            
            for (int i = 0; i < matrixA.GetLength(0); i++)
            {
                for (int j = 0; j < matrixA.GetLength(1); j++)
                {
                    testTextBox.Text += matrixA[i, j];
                }
                testTextBox.Text += "\n";
            }
                       
        }

        
    }
}
