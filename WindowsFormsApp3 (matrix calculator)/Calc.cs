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

        private void initMatrixTEST(GroupBox gBox, int[,] arr2d)
        {            

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
                            if (c.Name == ("resultMatrix" + (i+1).ToString()+"_"+ (j + 1).ToString()))
                            {                                
                                arr2d[i, j] = int.Parse(c.Text);
                            }
                        }
                    }
                                       
                }
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }      

        private void btnMatrixInterface_Click(object sender, EventArgs e)
        {
            this.userControl11.Show();
            this.testUserControl21.Hide();

            this.funcUserControl11.Hide();
        }

        private void btnFunctionInterface_Click(object sender, EventArgs e)
        {
            this.userControl11.Hide();
            this.testUserControl21.Hide();
            this.funcUserControl11.Show();
        }

        private void btnTestInerface_click(object sender, EventArgs e)
        {
            this.userControl11.Hide();
            this.funcUserControl11.Hide();

            this.testUserControl21.Show();
        }
    }
}
