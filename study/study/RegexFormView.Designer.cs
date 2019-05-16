namespace GTL
{
    partial class RegexFormView
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
            this.lblPattern = new System.Windows.Forms.Label();
            this.lblText = new System.Windows.Forms.Label();
            this.tbxPattern = new System.Windows.Forms.TextBox();
            this.btnMatch = new System.Windows.Forms.Button();
            this.tbxText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rtbxPatternHistory = new System.Windows.Forms.RichTextBox();
            this.rtbxPatternMatches = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblPattern
            // 
            this.lblPattern.AutoSize = true;
            this.lblPattern.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPattern.Location = new System.Drawing.Point(12, 27);
            this.lblPattern.Name = "lblPattern";
            this.lblPattern.Size = new System.Drawing.Size(48, 16);
            this.lblPattern.TabIndex = 0;
            this.lblPattern.Text = "Pattern";
            // 
            // lblText
            // 
            this.lblText.AutoSize = true;
            this.lblText.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblText.Location = new System.Drawing.Point(12, 93);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(30, 16);
            this.lblText.TabIndex = 1;
            this.lblText.Text = "Text";
            // 
            // tbxPattern
            // 
            this.tbxPattern.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxPattern.Location = new System.Drawing.Point(15, 47);
            this.tbxPattern.Name = "tbxPattern";
            this.tbxPattern.Size = new System.Drawing.Size(351, 26);
            this.tbxPattern.TabIndex = 2;
            // 
            // btnMatch
            // 
            this.btnMatch.Location = new System.Drawing.Point(387, 47);
            this.btnMatch.Name = "btnMatch";
            this.btnMatch.Size = new System.Drawing.Size(75, 26);
            this.btnMatch.TabIndex = 3;
            this.btnMatch.Text = "Match";
            this.btnMatch.UseVisualStyleBackColor = true;
            this.btnMatch.Click += new System.EventHandler(this.btnMatch_Click);
            // 
            // tbxText
            // 
            this.tbxText.Location = new System.Drawing.Point(15, 112);
            this.tbxText.Multiline = true;
            this.tbxText.Name = "tbxText";
            this.tbxText.Size = new System.Drawing.Size(447, 125);
            this.tbxText.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 254);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Pattern History";
            // 
            // rtbxPatternHistory
            // 
            this.rtbxPatternHistory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbxPatternHistory.Enabled = false;
            this.rtbxPatternHistory.Location = new System.Drawing.Point(15, 273);
            this.rtbxPatternHistory.Name = "rtbxPatternHistory";
            this.rtbxPatternHistory.ReadOnly = true;
            this.rtbxPatternHistory.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.rtbxPatternHistory.Size = new System.Drawing.Size(195, 104);
            this.rtbxPatternHistory.TabIndex = 6;
            this.rtbxPatternHistory.Text = "";
            // 
            // rtbxPatternMatches
            // 
            this.rtbxPatternMatches.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbxPatternMatches.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.rtbxPatternMatches.Location = new System.Drawing.Point(230, 273);
            this.rtbxPatternMatches.Name = "rtbxPatternMatches";
            this.rtbxPatternMatches.ReadOnly = true;
            this.rtbxPatternMatches.Size = new System.Drawing.Size(232, 104);
            this.rtbxPatternMatches.TabIndex = 7;
            this.rtbxPatternMatches.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(227, 254);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Pattern Matches";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(496, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.DefaultExt = "txt";
            this.openFileDialog1.FileName = "*.txt";
            this.openFileDialog1.Filter = "Text documents (.txt)|*.txt";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "txt";
            this.saveFileDialog1.FileName = "*.txt";
            this.saveFileDialog1.Filter = "Text documents (.txt)|*.txt";
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // RegexFormView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 417);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rtbxPatternMatches);
            this.Controls.Add(this.rtbxPatternHistory);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxText);
            this.Controls.Add(this.btnMatch);
            this.Controls.Add(this.tbxPattern);
            this.Controls.Add(this.lblText);
            this.Controls.Add(this.lblPattern);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "RegexFormView";
            this.Text = "Regex";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPattern;
        private System.Windows.Forms.Label lblText;
        private System.Windows.Forms.TextBox tbxPattern;
        private System.Windows.Forms.Button btnMatch;
        private System.Windows.Forms.TextBox tbxText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox rtbxPatternHistory;
        private System.Windows.Forms.RichTextBox rtbxPatternMatches;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}