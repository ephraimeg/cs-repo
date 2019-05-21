using SongArchive.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SongArchive
{
    public partial class MainForm : Form
    {
        NewItemForm nForm;
        DataSet dataSet;

        public MainForm()
        {
            InitializeComponent();
            nForm = new NewItemForm();
        }

        private void songToolStripMenuItem_Click(object sender, EventArgs e)
        {
            nForm.Show("song");
        }

        private void singerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            nForm.Show("artist");
        }

        private void albumToolStripMenuItem_Click(object sender, EventArgs e)
        {
            nForm.Show("album");
        }

        private DataSet LoadModels()
        {
            DataSet dbset = new DataSet();
            string connectionString = "";
            string query = "select * from songs; select * from vw_singers; select * from vw_composers; select * from albums";
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    using (SqlCommand command = new SqlCommand(query, con))
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(dbset);
                    } 
                }
                catch(Exception exc)
                {
                    MessageBox.Show(exc.Message);
                }
            }
            return dbset;
        }

        private void connectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataSet = LoadModels();
            dgSongs.DataSource = dataSet.Tables[0];
            dgSingers.DataSource = dataSet.Tables[1];
            dgComposers.DataSource = dataSet.Tables[2];
            dgAlbums.DataSource = dataSet.Tables[3];

            //string connectionString = "";
            //string sql = "select * from songs";

            //DataContext db = new DataContext(connectionString);
            //db.Log = Console.Out;

            //Table<Song> Songs = db.GetTable<Song>();
            ////Table<Artist> Artists = db.GetTable<Artist>();
            ////Table<Album> Albums = db.GetTable<Album>();

            //IQueryable<Song> songQuery =
            //    from song in Songs select song;

            //foreach(Song s in songQuery)
            //{
            //    MessageBox.Show($"ID={s.SongID}, Title={s.Title}");
            //}

        }
    }
}
