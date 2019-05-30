using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SongArchive
{
    public partial class InsertArtistView : UserControl
    {
        public InsertArtistView()
        {
            InitializeComponent();
        }
        private void CreateArtist()
        {
            if(tbFirstName.Text.Equals(string.Empty) || tbLastName.Equals(string.Empty))
            {
                MessageBox.Show("All input fields are required");
                return;
            }

            string query = "insert into artists (firstname, lastname) values (@firstname, @lastname)";
            using (SqlConnection con = new SqlConnection("Server=virmdesql20\\sql03;database=zzz_for_deletion;uid=oos;pwd=it-oos"))
            {
                con.Open();
                using(SqlCommand sql = new SqlCommand(query,con))
                {
                    sql.Parameters.AddWithValue("@firstname", tbFirstName.Text);
                    sql.Parameters.AddWithValue("@lastname", tbLastName.Text);
                    int result = sql.ExecuteNonQuery();
                    if(result < 0)
                    {
                        MessageBox.Show("An error occured while inserting new Artist");
                    }
                }
            }
            this.Parent.Hide();
            this.Parent.Dispose();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            CreateArtist();
        }
    }
}
