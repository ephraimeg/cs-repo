using SongArchive.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SongArchive.View
{
    public partial class DetailForm : Form
    {
        public DetailForm()
        {
            InitializeComponent();
        }
        public void Show(string item, string value, DataSet ds)
        {
            if (item.Equals("artist"))
            {
                detailAlbumView1.Visible = false;
                detailSongView1.Visible = false;
                detailArtistView1.Show(value, ds);
            }
            else if (item.Equals("song"))
            {
                detailAlbumView1.Visible = false;
                detailArtistView1.Visible = false;
                detailSongView1.Show(value, ds);
            }
            else if (item.Equals("album"))
            {
                detailAlbumView1.Visible = true;
                detailArtistView1.Visible = false;
                detailSongView1.Visible = false;
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
