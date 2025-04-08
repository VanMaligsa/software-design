namespace Task3._2_Exercise3_
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
            btnShowInfo = new Button();
            BookListBox = new ListBox();
            SuspendLayout();
            // 
            // btnShowInfo
            // 
            btnShowInfo.Location = new Point(167, 304);
            btnShowInfo.Name = "btnShowInfo";
            btnShowInfo.Size = new Size(280, 44);
            btnShowInfo.TabIndex = 5;
            btnShowInfo.Text = "Show Information";
            btnShowInfo.UseVisualStyleBackColor = true;
            btnShowInfo.Click += btnShowInfo_Click;
            // 
            // BookListBox
            // 
            BookListBox.FormattingEnabled = true;
            BookListBox.ItemHeight = 15;
            BookListBox.Location = new Point(29, 34);
            BookListBox.Name = "BookListBox";
            BookListBox.Size = new Size(518, 229);
            BookListBox.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(579, 360);
            Controls.Add(btnShowInfo);
            Controls.Add(BookListBox);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnShowInfo;
        private ListBox BookListBox;
    }
}
