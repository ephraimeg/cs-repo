using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SongArchive
{
    public partial class NewItemForm : Form
    {
        public NewItemForm()
        {
            InitializeComponent();
        }
        
        public void Show(string item)
        {
            if (item.Equals("artist"))
            {
                insertAlbumView1.Visible = false;
                insertArtistView1.Visible = true;
                insertSongView1.Visible = false;
            }
            else if (item.Equals("song"))
            {
                insertAlbumView1.Visible = false;
                insertArtistView1.Visible = false;
                insertSongView1.Visible = true;
            }
            else if (item.Equals("album"))
            {
                insertAlbumView1.Visible = true;
                insertArtistView1.Visible = false;
                insertSongView1.Visible = false;
            }
            else
            {
                MessageBox.Show("Something went wrong, please try again.");
                return;
            }
            this.Show();
        }
    }
}
