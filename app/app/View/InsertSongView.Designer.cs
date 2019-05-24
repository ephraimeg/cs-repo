namespace SongArchive
{
    partial class InsertSongView
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxTitle = new System.Windows.Forms.TextBox();
            this.cbSinger = new System.Windows.Forms.ComboBox();
            this.cbComposer = new System.Windows.Forms.ComboBox();
            this.btnNewSinger = new System.Windows.Forms.Button();
            this.btnNewComposer = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(10, 33);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(71, 13);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "SONG TITLE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "SINGER";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "COMPOSER";
            // 
            // tbxTitle
            // 
            this.tbxTitle.Location = new System.Drawing.Point(105, 30);
            this.tbxTitle.Name = "tbxTitle";
            this.tbxTitle.Size = new System.Drawing.Size(180, 20);
            this.tbxTitle.TabIndex = 3;
            // 
            // cbSinger
            // 
            this.cbSinger.FormattingEnabled = true;
            this.cbSinger.Location = new System.Drawing.Point(105, 66);
            this.cbSinger.Name = "cbSinger";
            this.cbSinger.Size = new System.Drawing.Size(121, 21);
            this.cbSinger.TabIndex = 4;
            // 
            // cbComposer
            // 
            this.cbComposer.FormattingEnabled = true;
            this.cbComposer.Location = new System.Drawing.Point(105, 102);
            this.cbComposer.Name = "cbComposer";
            this.cbComposer.Size = new System.Drawing.Size(121, 21);
            this.cbComposer.TabIndex = 5;
            // 
            // btnNewSinger
            // 
            this.btnNewSinger.Location = new System.Drawing.Point(232, 64);
            this.btnNewSinger.Name = "btnNewSinger";
            this.btnNewSinger.Size = new System.Drawing.Size(53, 23);
            this.btnNewSinger.TabIndex = 6;
            this.btnNewSinger.Text = "Add";
            this.btnNewSinger.UseVisualStyleBackColor = true;
            // 
            // btnNewComposer
            // 
            this.btnNewComposer.Location = new System.Drawing.Point(232, 100);
            this.btnNewComposer.Name = "btnNewComposer";
            this.btnNewComposer.Size = new System.Drawing.Size(53, 23);
            this.btnNewComposer.TabIndex = 7;
            this.btnNewComposer.Text = "Add";
            this.btnNewComposer.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(13, 148);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(272, 35);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // InsertSongView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnNewComposer);
            this.Controls.Add(this.btnNewSinger);
            this.Controls.Add(this.cbComposer);
            this.Controls.Add(this.cbSinger);
            this.Controls.Add(this.tbxTitle);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblTitle);
            this.Name = "InsertSongView";
            this.Size = new System.Drawing.Size(300, 200);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxTitle;
        private System.Windows.Forms.ComboBox cbSinger;
        private System.Windows.Forms.ComboBox cbComposer;
        private System.Windows.Forms.Button btnNewSinger;
        private System.Windows.Forms.Button btnNewComposer;
        private System.Windows.Forms.Button btnSave;
    }
}
