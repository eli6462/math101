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
        

        private void test()
        {
            foreach (Control c in Controls)
            {
                if (c is TextBox)
                {
                    c.Text = "9";
                }
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }
        private void initMatrixA()
        {
            
        }
        private void button1_Click(object sender, EventArgs e)
        {            
            test();

            //test
            /*
            for (int i = 0; i < matrixA.GetLength(0); i++)
            {
                for (int j = 0; j < matrixA.GetLength(1); j++)
                {
                    testTextBox.Text += matrixA[i, j];
                }
                Console.WriteLine();
            }
            */
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                testTextBox.Text += "test "+i+", ";
            }
            
        }
    }
}
