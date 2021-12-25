namespace sql_syntax_highlighter
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
            this.Codes = new System.Windows.Forms.RichTextBox();
            this.lblStrings = new System.Windows.Forms.Label();
            this.lblKeywords = new System.Windows.Forms.Label();
            this.stringCounts = new System.Windows.Forms.Label();
            this.keywordCounts = new System.Windows.Forms.Label();
            this.commentCounts = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.variableCounts = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Codes
            // 
            this.Codes.Location = new System.Drawing.Point(12, 12);
            this.Codes.Name = "Codes";
            this.Codes.Size = new System.Drawing.Size(541, 420);
            this.Codes.TabIndex = 0;
            this.Codes.Text = "";
            this.Codes.TextChanged += new System.EventHandler(this.Codes_TextChanged);
            // 
            // lblStrings
            // 
            this.lblStrings.AutoSize = true;
            this.lblStrings.ForeColor = System.Drawing.Color.Red;
            this.lblStrings.Location = new System.Drawing.Point(12, 446);
            this.lblStrings.Name = "lblStrings";
            this.lblStrings.Size = new System.Drawing.Size(132, 15);
            this.lblStrings.TabIndex = 1;
            this.lblStrings.Text = "Count of strings in Text:";
            // 
            // lblKeywords
            // 
            this.lblKeywords.AutoSize = true;
            this.lblKeywords.ForeColor = System.Drawing.Color.Blue;
            this.lblKeywords.Location = new System.Drawing.Point(12, 476);
            this.lblKeywords.Name = "lblKeywords";
            this.lblKeywords.Size = new System.Drawing.Size(147, 15);
            this.lblKeywords.TabIndex = 2;
            this.lblKeywords.Text = "Count of keywords in Text:";
            // 
            // stringCounts
            // 
            this.stringCounts.AutoSize = true;
            this.stringCounts.ForeColor = System.Drawing.Color.Black;
            this.stringCounts.Location = new System.Drawing.Point(145, 446);
            this.stringCounts.Name = "stringCounts";
            this.stringCounts.Size = new System.Drawing.Size(13, 15);
            this.stringCounts.TabIndex = 3;
            this.stringCounts.Text = "0";
            // 
            // keywordCounts
            // 
            this.keywordCounts.AutoSize = true;
            this.keywordCounts.ForeColor = System.Drawing.Color.Black;
            this.keywordCounts.Location = new System.Drawing.Point(161, 476);
            this.keywordCounts.Name = "keywordCounts";
            this.keywordCounts.Size = new System.Drawing.Size(13, 15);
            this.keywordCounts.TabIndex = 4;
            this.keywordCounts.Text = "0";
            // 
            // commentCounts
            // 
            this.commentCounts.AutoSize = true;
            this.commentCounts.ForeColor = System.Drawing.Color.Black;
            this.commentCounts.Location = new System.Drawing.Point(165, 504);
            this.commentCounts.Name = "commentCounts";
            this.commentCounts.Size = new System.Drawing.Size(13, 15);
            this.commentCounts.TabIndex = 6;
            this.commentCounts.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Green;
            this.label2.Location = new System.Drawing.Point(12, 504);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Count of comments in Text:";
            // 
            // variableCounts
            // 
            this.variableCounts.AutoSize = true;
            this.variableCounts.ForeColor = System.Drawing.Color.Black;
            this.variableCounts.Location = new System.Drawing.Point(416, 446);
            this.variableCounts.Name = "variableCounts";
            this.variableCounts.Size = new System.Drawing.Size(13, 15);
            this.variableCounts.TabIndex = 8;
            this.variableCounts.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(271, 446);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Count of Variables in Text:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 537);
            this.Controls.Add(this.variableCounts);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.commentCounts);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.keywordCounts);
            this.Controls.Add(this.stringCounts);
            this.Controls.Add(this.lblKeywords);
            this.Controls.Add(this.lblStrings);
            this.Controls.Add(this.Codes);
            this.Name = "Form1";
            this.Text = "sql-syntax-highlighter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RichTextBox Codes;
        private Label lblStrings;
        private Label lblKeywords;
        private Label stringCounts;
        private Label keywordCounts;
        private Label commentCounts;
        private Label label2;
        private Label variableCounts;
        private Label label3;
    }
}