
namespace WindowsFormsApp3__matrix_calculator_
{
    partial class Form2
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
            this.btnMatrixInterface = new System.Windows.Forms.Button();
            this.btnFunctionInterface = new System.Windows.Forms.Button();
            this.funcUserControl11 = new WindowsFormsApp3__matrix_calculator_.FuncUserControl();
            this.userControl11 = new WindowsFormsApp3__matrix_calculator_.UserControl1();
            this.testUserControl21 = new WindowsFormsApp3__matrix_calculator_.TestUserControl();
            this.btnTestInerface = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMatrixInterface
            // 
            this.btnMatrixInterface.Location = new System.Drawing.Point(80, 1);
            this.btnMatrixInterface.Name = "btnMatrixInterface";
            this.btnMatrixInterface.Size = new System.Drawing.Size(85, 35);
            this.btnMatrixInterface.TabIndex = 2;
            this.btnMatrixInterface.Text = "matrix";
            this.btnMatrixInterface.UseVisualStyleBackColor = true;
            this.btnMatrixInterface.Click += new System.EventHandler(this.btnMatrixInterface_Click);
            // 
            // btnFunctionInterface
            // 
            this.btnFunctionInterface.Location = new System.Drawing.Point(161, 1);
            this.btnFunctionInterface.Name = "btnFunctionInterface";
            this.btnFunctionInterface.Size = new System.Drawing.Size(85, 35);
            this.btnFunctionInterface.TabIndex = 3;
            this.btnFunctionInterface.Text = "functions";
            this.btnFunctionInterface.UseVisualStyleBackColor = true;
            this.btnFunctionInterface.Click += new System.EventHandler(this.btnFunctionInterface_Click);
            // 
            // funcUserControl11
            // 
            this.funcUserControl11.Location = new System.Drawing.Point(-8, 42);
            this.funcUserControl11.Name = "funcUserControl11";
            this.funcUserControl11.Size = new System.Drawing.Size(816, 419);
            this.funcUserControl11.TabIndex = 1;
            // 
            // userControl11
            // 
            this.userControl11.Location = new System.Drawing.Point(-8, 42);
            this.userControl11.Name = "userControl11";
            this.userControl11.Size = new System.Drawing.Size(816, 419);
            this.userControl11.TabIndex = 0;
            // 
            // testUserControl21
            // 
            this.testUserControl21.Location = new System.Drawing.Point(-8, 42);
            this.testUserControl21.Name = "testUserControl21";
            this.testUserControl21.Size = new System.Drawing.Size(816, 419);
            this.testUserControl21.TabIndex = 4;
            // 
            // btnTestInerface
            // 
            this.btnTestInerface.Location = new System.Drawing.Point(611, 1);
            this.btnTestInerface.Name = "btnTestInerface";
            this.btnTestInerface.Size = new System.Drawing.Size(85, 35);
            this.btnTestInerface.TabIndex = 5;
            this.btnTestInerface.Text = "matrix TEST";
            this.btnTestInerface.UseVisualStyleBackColor = true;
            this.btnTestInerface.Click += new System.EventHandler(this.btnTestInerface_click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnTestInerface);
            this.Controls.Add(this.testUserControl21);
            this.Controls.Add(this.btnFunctionInterface);
            this.Controls.Add(this.btnMatrixInterface);
            this.Controls.Add(this.funcUserControl11);
            this.Controls.Add(this.userControl11);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private UserControl1 userControl11;
        private FuncUserControl funcUserControl11;
        private System.Windows.Forms.Button btnMatrixInterface;
        private System.Windows.Forms.Button btnFunctionInterface;
        private TestUserControl testUserControl21;
        private System.Windows.Forms.Button btnTestInerface;
    }
}