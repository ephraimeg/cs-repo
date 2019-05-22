using SongArchive.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SongArchive
{
    public partial class MainForm : Form
    {
        NewItemForm nForm;
        View.DetailForm dForm;
        private static DataSet modelsDataSet;
        private static DataSet singersDataSet;

        public MainForm()
        {
            InitializeComponent();
            nForm = new NewItemForm();
            dForm = new View.DetailForm();
        }

        private void songToolStripMenuItem_Click(object sender, EventArgs e)
        {
            nForm = new NewItemForm();
            nForm.Show("song");
        }

        private void singerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            nForm = new NewItemForm();
            nForm.Show("artist");
        }

        private void albumToolStripMenuItem_Click(object sender, EventArgs e)
        {
            nForm = new NewItemForm();
            nForm.Show("album");
        }

        private void LoadModels()
        {
            modelsDataSet = new DataSet();
            singersDataSet = new DataSet();
            string connectionString = "";
            string query = "select * from songs; select * from vw_singers; select * from vw_composers; select * from albums";
            string singersq = "select * from vw_songartists";
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    using (SqlCommand command = new SqlCommand(query, con))
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(modelsDataSet);
                    }
                    using (SqlCommand command = new SqlCommand(singersq, con))
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(singersDataSet);
                    }
                }
                catch(Exception exc)
                {
                    MessageBox.Show(exc.Message);
                }
            }
        }
        
        private void connectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateDataGrid();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            UpdateDataGrid();
        }

        private void UpdateDataGrid()
        {
            LoadModels();
            dgSongs.DataSource = modelsDataSet.Tables[0];
            dgSingers.DataSource = modelsDataSet.Tables[1];
            dgComposers.DataSource = modelsDataSet.Tables[2];
            dgAlbums.DataSource = modelsDataSet.Tables[3];
        }

        private void dgSongs_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            dForm = new View.DetailForm();
            string value = dgSongs.Rows[e.RowIndex].Cells[0].Value.ToString();
            dForm.Show("song", value, singersDataSet);
        }

        private void dgSingers_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            dForm = new View.DetailForm();
            string value = dgSingers.Rows[e.RowIndex].Cells[0].Value.ToString();
            dForm.Show("artist", value, singersDataSet);
        }
        
        private void dgAlbums_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            dForm = new View.DetailForm();
            string value = dgAlbums.Rows[e.RowIndex].Cells[0].Value.ToString();
            //dForm.Show("album", value);
        }
    }
}
