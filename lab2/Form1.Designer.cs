namespace lab2
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
            lblResult = new Label();
            button1 = new Button();
            txtInput = new TextBox();
            SuspendLayout();
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Location = new Point(106, 197);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(39, 15);
            lblResult.TabIndex = 0;
            lblResult.Text = "Result";
            // 
            // button1
            // 
            button1.Location = new Point(106, 138);
            button1.Name = "button1";
            button1.Size = new Size(107, 31);
            button1.TabIndex = 1;
            button1.Text = "Calculate";
            button1.UseVisualStyleBackColor = true;
            // 
            // txtInput
            // 
            txtInput.Location = new Point(106, 85);
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(107, 23);
            txtInput.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(299, 351);
            Controls.Add(txtInput);
            Controls.Add(button1);
            Controls.Add(lblResult);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblResult;
        private Button button1;
        private TextBox txtInput;
    }
}
