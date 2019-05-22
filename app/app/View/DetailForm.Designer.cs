namespace SongArchive.View
{
    partial class DetailForm
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
            this.detailSongView1 = new SongArchive.DetailArtistView();
            this.detailAlbumView1 = new SongArchive.View.DetailAlbumView();
            this.detailArtistView1 = new SongArchive.View.DetailArtistView();
            this.SuspendLayout();
            // 
            // detailSongView
            // 
            this.detailSongView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.detailSongView1.Location = new System.Drawing.Point(0, 0);
            this.detailSongView1.Name = "detailSongView";
            this.detailSongView1.Size = new System.Drawing.Size(405, 377);
            this.detailSongView1.TabIndex = 0;
            // 
            // detailAlbumView1
            // 
            this.detailAlbumView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.detailAlbumView1.Location = new System.Drawing.Point(0, 0);
            this.detailAlbumView1.Name = "detailAlbumView1";
            this.detailAlbumView1.Size = new System.Drawing.Size(405, 377);
            this.detailAlbumView1.TabIndex = 1;
            // 
            // detailArtistView1
            // 
            this.detailArtistView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.detailArtistView1.Location = new System.Drawing.Point(0, 0);
            this.detailArtistView1.Name = "detailArtistView1";
            this.detailArtistView1.Size = new System.Drawing.Size(405, 377);
            this.detailArtistView1.TabIndex = 2;
            // 
            // DetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 377);
            this.Controls.Add(this.detailArtistView1);
            this.Controls.Add(this.detailAlbumView1);
            this.Controls.Add(this.detailSongView1);
            this.Name = "DetailForm";
            this.Text = "DetailForm";
            this.ResumeLayout(false);

        }

        #endregion

        private SongArchive.DetailArtistView detailSongView1;
        private DetailAlbumView detailAlbumView1;
        private DetailArtistView detailArtistView1;
    }
}