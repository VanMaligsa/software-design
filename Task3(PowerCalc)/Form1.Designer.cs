namespace Task3_PowerCalc_
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
            btnCalcuate_Click = new Button();
            lblResult = new Label();
            txtBaseInput = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtExpoInput = new TextBox();
            SuspendLayout();
            // 
            // btnCalcuate_Click
            // 
            btnCalcuate_Click.Location = new Point(101, 174);
            btnCalcuate_Click.Name = "btnCalcuate_Click";
            btnCalcuate_Click.Size = new Size(100, 28);
            btnCalcuate_Click.TabIndex = 0;
            btnCalcuate_Click.Text = "Calculate";
            btnCalcuate_Click.UseVisualStyleBackColor = true;
            btnCalcuate_Click.Click += btnCalcuate_Click_Click;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Location = new Point(101, 216);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(42, 15);
            lblResult.TabIndex = 1;
            lblResult.Text = "Result:";
            // 
            // txtBaseInput
            // 
            txtBaseInput.Location = new Point(101, 52);
            txtBaseInput.Name = "txtBaseInput";
            txtBaseInput.Size = new Size(100, 23);
            txtBaseInput.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(101, 34);
            label1.Name = "label1";
            label1.Size = new Size(31, 15);
            label1.TabIndex = 3;
            label1.Text = "Base";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(101, 104);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 4;
            label2.Text = "Exponent";
            // 
            // txtExpoInput
            // 
            txtExpoInput.Location = new Point(101, 122);
            txtExpoInput.Name = "txtExpoInput";
            txtExpoInput.Size = new Size(100, 23);
            txtExpoInput.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(274, 278);
            Controls.Add(txtExpoInput);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtBaseInput);
            Controls.Add(lblResult);
            Controls.Add(btnCalcuate_Click);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCalcuate_Click;
        private Label lblResult;
        private TextBox txtBaseInput;
        private Label label1;
        private Label label2;
        private TextBox txtExpoInput;
    }
}
