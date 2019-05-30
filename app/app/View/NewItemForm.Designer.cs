namespace SongArchive
{
    partial class NewItemForm
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
            this.insertAlbumView1 = new SongArchive.InsertAlbumView();
            this.insertArtistView1 = new SongArchive.InsertArtistView();
            this.insertSongView1 = new SongArchive.InsertSongView();
            this.SuspendLayout();
            // 
            // insertAlbumView1
            // 
            this.insertAlbumView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.insertAlbumView1.Location = new System.Drawing.Point(0, 0);
            this.insertAlbumView1.Name = "insertAlbumView1";
            this.insertAlbumView1.Size = new System.Drawing.Size(301, 202);
            this.insertAlbumView1.TabIndex = 0;
            // 
            // insertArtistView1
            // 
            this.insertArtistView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.insertArtistView1.Location = new System.Drawing.Point(0, 0);
            this.insertArtistView1.Name = "insertArtistView1";
            this.insertArtistView1.Size = new System.Drawing.Size(301, 202);
            this.insertArtistView1.TabIndex = 1;
            // 
            // insertSongView1
            // 
            this.insertSongView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.insertSongView1.Location = new System.Drawing.Point(0, 0);
            this.insertSongView1.Name = "insertSongView1";
            this.insertSongView1.Size = new System.Drawing.Size(301, 202);
            this.insertSongView1.TabIndex = 2;
            // 
            // NewItemForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 202);
            this.Controls.Add(this.insertSongView1);
            this.Controls.Add(this.insertArtistView1);
            this.Controls.Add(this.insertAlbumView1);
            this.Name = "NewItemForm";
            this.Text = "New";
            this.ResumeLayout(false);

        }

        #endregion

        private InsertAlbumView insertAlbumView1;
        private InsertArtistView insertArtistView1;
        private InsertSongView insertSongView1;
    }
}