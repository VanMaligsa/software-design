namespace lab1
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
            listBoxResults = new ListBox();
            btnSort_Click = new Button();
            SuspendLayout();
            // 
            // listBoxResults
            // 
            listBoxResults.FormattingEnabled = true;
            listBoxResults.ItemHeight = 15;
            listBoxResults.Location = new Point(122, 52);
            listBoxResults.Name = "listBoxResults";
            listBoxResults.Size = new Size(120, 124);
            listBoxResults.TabIndex = 0;
            // 
            // btnSort_Click
            // 
            btnSort_Click.Location = new Point(122, 206);
            btnSort_Click.Name = "btnSort_Click";
            btnSort_Click.Size = new Size(120, 31);
            btnSort_Click.TabIndex = 1;
            btnSort_Click.Text = "Sort";
            btnSort_Click.UseVisualStyleBackColor = true;
            btnSort_Click.Click += btnSort_Click_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(356, 326);
            Controls.Add(btnSort_Click);
            Controls.Add(listBoxResults);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private ListBox listBoxResults;
        private Button btnSort_Click;
    }
}
