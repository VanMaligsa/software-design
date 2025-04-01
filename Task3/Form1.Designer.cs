namespace Task3
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
            btnCalculateFibonacci_Click = new Button();
            txtInput = new TextBox();
            lblResult = new Label();
            SuspendLayout();
            // 
            // btnCalculateFibonacci_Click
            // 
            btnCalculateFibonacci_Click.Location = new Point(89, 115);
            btnCalculateFibonacci_Click.Name = "btnCalculateFibonacci_Click";
            btnCalculateFibonacci_Click.Size = new Size(100, 35);
            btnCalculateFibonacci_Click.TabIndex = 0;
            btnCalculateFibonacci_Click.Text = "Calculate";
            btnCalculateFibonacci_Click.UseVisualStyleBackColor = true;
            btnCalculateFibonacci_Click.Click += btnCalculateFibonacci_Click_Click;
            // 
            // txtInput
            // 
            txtInput.Location = new Point(89, 71);
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(100, 23);
            txtInput.TabIndex = 1;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Location = new Point(89, 170);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(42, 15);
            lblResult.TabIndex = 2;
            lblResult.Text = "Result:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(274, 262);
            Controls.Add(lblResult);
            Controls.Add(txtInput);
            Controls.Add(btnCalculateFibonacci_Click);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCalculateFibonacci_Click;
        private TextBox txtInput;
        private Label lblResult;
    }
}
