namespace Task2_Exer3
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
            ListBoxBooks = new ListBox();
            btnShowInfo = new Button();
            SuspendLayout();
            // 
            // ListBoxBooks
            // 
            ListBoxBooks.FormattingEnabled = true;
            ListBoxBooks.ItemHeight = 15;
            ListBoxBooks.Location = new Point(34, 31);
            ListBoxBooks.Name = "ListBoxBooks";
            ListBoxBooks.Size = new Size(398, 229);
            ListBoxBooks.TabIndex = 0;
            // 
            // btnShowInfo
            // 
            btnShowInfo.Location = new Point(98, 277);
            btnShowInfo.Name = "btnShowInfo";
            btnShowInfo.Size = new Size(280, 44);
            btnShowInfo.TabIndex = 1;
            btnShowInfo.Text = "Show Information";
            btnShowInfo.UseVisualStyleBackColor = true;
            btnShowInfo.Click += btnShowInfo_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(466, 345);
            Controls.Add(btnShowInfo);
            Controls.Add(ListBoxBooks);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private ListBox ListBoxBooks;
        private Button btnShowInfo;
    }
}
