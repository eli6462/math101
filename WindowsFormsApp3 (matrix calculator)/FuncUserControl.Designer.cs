
namespace WindowsFormsApp3__matrix_calculator_
{
    partial class FuncUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.inputBox = new System.Windows.Forms.TextBox();
            this.resolveBtn = new System.Windows.Forms.Button();
            this.resultBox = new System.Windows.Forms.TextBox();
            this.instructionsLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // inputBox
            // 
            this.inputBox.Location = new System.Drawing.Point(344, 158);
            this.inputBox.Margin = new System.Windows.Forms.Padding(4);
            this.inputBox.Name = "inputBox";
            this.inputBox.Size = new System.Drawing.Size(305, 22);
            this.inputBox.TabIndex = 0;
            // 
            // resolveBtn
            // 
            this.resolveBtn.Location = new System.Drawing.Point(445, 204);
            this.resolveBtn.Margin = new System.Windows.Forms.Padding(4);
            this.resolveBtn.Name = "resolveBtn";
            this.resolveBtn.Size = new System.Drawing.Size(100, 28);
            this.resolveBtn.TabIndex = 2;
            this.resolveBtn.Text = "Find X";
            this.resolveBtn.UseVisualStyleBackColor = true;
            this.resolveBtn.Click += new System.EventHandler(this.resolveBtn_Click);
            // 
            // resultBox
            // 
            this.resultBox.Location = new System.Drawing.Point(344, 258);
            this.resultBox.Margin = new System.Windows.Forms.Padding(4);
            this.resultBox.Name = "resultBox";
            this.resultBox.Size = new System.Drawing.Size(305, 22);
            this.resultBox.TabIndex = 3;
            // 
            // instructionsLabel
            // 
            this.instructionsLabel.AutoSize = true;
            this.instructionsLabel.Location = new System.Drawing.Point(65, 158);
            this.instructionsLabel.Name = "instructionsLabel";
            this.instructionsLabel.Size = new System.Drawing.Size(256, 48);
            this.instructionsLabel.TabIndex = 4;
            this.instructionsLabel.Text = "Please enter your quadratic equation here\r\n\r\nEx. 1x^2+5x+6=0";
            // 
            // FuncUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.instructionsLabel);
            this.Controls.Add(this.resultBox);
            this.Controls.Add(this.resolveBtn);
            this.Controls.Add(this.inputBox);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FuncUserControl";
            this.Size = new System.Drawing.Size(1088, 516);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox inputBox;
        private System.Windows.Forms.Button resolveBtn;
        private System.Windows.Forms.TextBox resultBox;
        private System.Windows.Forms.Label instructionsLabel;
    }
}
