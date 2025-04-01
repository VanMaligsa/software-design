namespace Task2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtInput = new TextBox();
            btnCalculateFactorial_Click = new Button();
            txtArrayInput = new TextBox();
            btnCalculateSum_Click = new Button();
            lblSumResult = new Label();
            SuspendLayout();
            // 
            // txtInput
            // 
            txtInput.Location = new Point(115, 67);
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(100, 23);
            txtInput.TabIndex = 0;
            // 
            // btnCalculateFactorial_Click
            // 
            btnCalculateFactorial_Click.Location = new Point(115, 111);
            btnCalculateFactorial_Click.Name = "btnCalculateFactorial_Click";
            btnCalculateFactorial_Click.Size = new Size(100, 27);
            btnCalculateFactorial_Click.TabIndex = 1;
            btnCalculateFactorial_Click.Text = "Calculate";
            btnCalculateFactorial_Click.UseVisualStyleBackColor = true;
            btnCalculateFactorial_Click.Click += btnCalculateFactorial_Click_Click;
            // 
            // txtArrayInput
            // 
            txtArrayInput.Location = new Point(115, 167);
            txtArrayInput.Name = "txtArrayInput";
            txtArrayInput.Size = new Size(100, 23);
            txtArrayInput.TabIndex = 2;
            // 
            // btnCalculateSum_Click
            // 
            btnCalculateSum_Click.Location = new Point(115, 209);
            btnCalculateSum_Click.Name = "btnCalculateSum_Click";
            btnCalculateSum_Click.Size = new Size(100, 23);
            btnCalculateSum_Click.TabIndex = 3;
            btnCalculateSum_Click.Text = "Calculate Sum";
            btnCalculateSum_Click.UseVisualStyleBackColor = true;
            btnCalculateSum_Click.Click += btnCalculateSum_Click_Click;
            // 
            // lblSumResult
            // 
            lblSumResult.AutoSize = true;
            lblSumResult.Location = new Point(115, 252);
            lblSumResult.Name = "lblSumResult";
            lblSumResult.Size = new Size(42, 15);
            lblSumResult.TabIndex = 4;
            lblSumResult.Text = "Result:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(311, 377);
            Controls.Add(lblSumResult);
            Controls.Add(btnCalculateSum_Click);
            Controls.Add(txtArrayInput);
            Controls.Add(btnCalculateFactorial_Click);
            Controls.Add(txtInput);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtInput;
        private Button btnCalculateFactorial_Click;
        private TextBox txtArrayInput;
        private Button btnCalculateSum_Click;
        private Label lblSumResult;
    }
}
