namespace SongArchive
{
    partial class InsertAlbumView
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
            this.btnSave = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.tbAlbumName = new System.Windows.Forms.TextBox();
            this.btnNewSinger = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lbSongList = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(13, 148);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(272, 35);
            this.btnSave.TabIndex = 22;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "SONG LIST";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(40, 33);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(44, 13);
            this.lblTitle.TabIndex = 24;
            this.lblTitle.Text = "ALBUM";
            // 
            // tbAlbumName
            // 
            this.tbAlbumName.Location = new System.Drawing.Point(105, 30);
            this.tbAlbumName.Name = "tbAlbumName";
            this.tbAlbumName.Size = new System.Drawing.Size(180, 20);
            this.tbAlbumName.TabIndex = 25;
            // 
            // btnNewSinger
            // 
            this.btnNewSinger.Location = new System.Drawing.Point(231, 64);
            this.btnNewSinger.Name = "btnNewSinger";
            this.btnNewSinger.Size = new System.Drawing.Size(53, 30);
            this.btnNewSinger.TabIndex = 27;
            this.btnNewSinger.Text = "New";
            this.btnNewSinger.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(231, 100);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(53, 30);
            this.btnSearch.TabIndex = 29;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // lbSongList
            // 
            this.lbSongList.FormattingEnabled = true;
            this.lbSongList.Location = new System.Drawing.Point(105, 66);
            this.lbSongList.Name = "lbSongList";
            this.lbSongList.Size = new System.Drawing.Size(120, 69);
            this.lbSongList.TabIndex = 26;
            // 
            // InsertAlbumView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnNewSinger);
            this.Controls.Add(this.lbSongList);
            this.Controls.Add(this.tbAlbumName);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label2);
            this.Name = "InsertAlbumView";
            this.Size = new System.Drawing.Size(300, 200);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox tbAlbumName;
        private System.Windows.Forms.Button btnNewSinger;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ListBox lbSongList;
    }
}
