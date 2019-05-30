namespace SongArchive
{
    partial class DetailArtistView
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
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbSingers = new System.Windows.Forms.ListBox();
            this.lbComposers = new System.Windows.Forms.ListBox();
            this.tbSongId = new System.Windows.Forms.TextBox();
            this.tbSongTitle = new System.Windows.Forms.TextBox();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.tbAlbum = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "SONG ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "SINGERS";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(208, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "COMPOSERS";
            // 
            // lbSingers
            // 
            this.lbSingers.FormattingEnabled = true;
            this.lbSingers.Location = new System.Drawing.Point(19, 175);
            this.lbSingers.Name = "lbSingers";
            this.lbSingers.Size = new System.Drawing.Size(170, 95);
            this.lbSingers.TabIndex = 4;
            // 
            // lbComposers
            // 
            this.lbComposers.FormattingEnabled = true;
            this.lbComposers.Location = new System.Drawing.Point(211, 175);
            this.lbComposers.Name = "lbComposers";
            this.lbComposers.Size = new System.Drawing.Size(170, 95);
            this.lbComposers.TabIndex = 5;
            // 
            // tbSongId
            // 
            this.tbSongId.Location = new System.Drawing.Point(113, 20);
            this.tbSongId.Name = "tbSongId";
            this.tbSongId.Size = new System.Drawing.Size(268, 20);
            this.tbSongId.TabIndex = 6;
            // 
            // tbSongTitle
            // 
            this.tbSongTitle.Location = new System.Drawing.Point(113, 53);
            this.tbSongTitle.Name = "tbSongTitle";
            this.tbSongTitle.Size = new System.Drawing.Size(268, 20);
            this.tbSongTitle.TabIndex = 7;
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(16, 308);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(232, 50);
            this.btnExport.TabIndex = 8;
            this.btnExport.Text = "EXPORT TO XML";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(262, 308);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(119, 50);
            this.btnUpdate.TabIndex = 9;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // tbAlbum
            // 
            this.tbAlbum.Location = new System.Drawing.Point(113, 86);
            this.tbAlbum.Name = "tbAlbum";
            this.tbAlbum.Size = new System.Drawing.Size(268, 20);
            this.tbAlbum.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(43, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "ALBUM";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 56);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "SONG TITLE";
            // 
            // DetailArtistView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbAlbum);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.tbSongTitle);
            this.Controls.Add(this.tbSongId);
            this.Controls.Add(this.lbComposers);
            this.Controls.Add(this.lbSingers);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "DetailArtistView";
            this.Size = new System.Drawing.Size(403, 375);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox lbSingers;
        private System.Windows.Forms.ListBox lbComposers;
        private System.Windows.Forms.TextBox tbSongId;
        private System.Windows.Forms.TextBox tbSongTitle;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox tbAlbum;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}
