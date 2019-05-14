namespace GTL
{
    partial class FormView
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
            this.btnConfirm = new System.Windows.Forms.Button();
            this.rtbxInBox = new System.Windows.Forms.RichTextBox();
            this.lbxMyList = new System.Windows.Forms.ListBox();
            this.btnDeleteItem = new System.Windows.Forms.Button();
            this.btnClearTextBox = new System.Windows.Forms.Button();
            this.btnClearListBox = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(289, 89);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(89, 29);
            this.btnConfirm.TabIndex = 1;
            this.btnConfirm.Text = "Add";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // rtbxInBox
            // 
            this.rtbxInBox.Location = new System.Drawing.Point(12, 89);
            this.rtbxInBox.Name = "rtbxInBox";
            this.rtbxInBox.Size = new System.Drawing.Size(271, 342);
            this.rtbxInBox.TabIndex = 2;
            this.rtbxInBox.Text = "";
            // 
            // lbxMyList
            // 
            this.lbxMyList.FormattingEnabled = true;
            this.lbxMyList.Location = new System.Drawing.Point(384, 89);
            this.lbxMyList.Name = "lbxMyList";
            this.lbxMyList.Size = new System.Drawing.Size(272, 342);
            this.lbxMyList.TabIndex = 3;
            // 
            // btnDeleteItem
            // 
            this.btnDeleteItem.Location = new System.Drawing.Point(289, 124);
            this.btnDeleteItem.Name = "btnDeleteItem";
            this.btnDeleteItem.Size = new System.Drawing.Size(89, 29);
            this.btnDeleteItem.TabIndex = 4;
            this.btnDeleteItem.Text = "Delete";
            this.btnDeleteItem.UseVisualStyleBackColor = true;
            this.btnDeleteItem.Click += new System.EventHandler(this.btnDeleteItem_Click);
            // 
            // btnClearTextBox
            // 
            this.btnClearTextBox.Location = new System.Drawing.Point(289, 159);
            this.btnClearTextBox.Name = "btnClearTextBox";
            this.btnClearTextBox.Size = new System.Drawing.Size(89, 29);
            this.btnClearTextBox.TabIndex = 5;
            this.btnClearTextBox.Text = "Clear Text Area";
            this.btnClearTextBox.UseVisualStyleBackColor = true;
            this.btnClearTextBox.Click += new System.EventHandler(this.btnClearTextBox_Click);
            // 
            // btnClearListBox
            // 
            this.btnClearListBox.Location = new System.Drawing.Point(289, 194);
            this.btnClearListBox.Name = "btnClearListBox";
            this.btnClearListBox.Size = new System.Drawing.Size(89, 29);
            this.btnClearListBox.TabIndex = 6;
            this.btnClearListBox.Text = "Clear List";
            this.btnClearListBox.UseVisualStyleBackColor = true;
            this.btnClearListBox.Click += new System.EventHandler(this.btnClearListBox_Click);
            // 
            // FormView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 456);
            this.Controls.Add(this.btnClearListBox);
            this.Controls.Add(this.btnClearTextBox);
            this.Controls.Add(this.btnDeleteItem);
            this.Controls.Add(this.lbxMyList);
            this.Controls.Add(this.rtbxInBox);
            this.Controls.Add(this.btnConfirm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormView";
            this.Text = "Sandbox";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.RichTextBox rtbxInBox;
        private System.Windows.Forms.ListBox lbxMyList;
        private System.Windows.Forms.Button btnDeleteItem;
        private System.Windows.Forms.Button btnClearTextBox;
        private System.Windows.Forms.Button btnClearListBox;
    }
}

