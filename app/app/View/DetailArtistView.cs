using SongArchive.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Xml.Linq;

namespace SongArchive.View
{
    public partial class DetailArtistView : UserControl
    {
        public DetailArtistView()
        {
            InitializeComponent();
        }

        public void Show(string value, DataSet ds)
        {
            DataRow[] rows = ds.Tables[0].Select($"artistId = '{value}'");
            tbArtistId.Text = value;
            tbFirstName.Text = rows[0].ItemArray[1].ToString();
            tbLastName.Text = rows[0].ItemArray[2].ToString();

            foreach(DataRow row in rows)
            {
                lbSongs.Items.Add(row.ItemArray[3].ToString());
            }
            //lbAlbums.Items.AddRange();
            this.Show();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            List<XElement> songs = new List<XElement>();

            foreach (object obj in lbSongs.Items)
            {
                songs.Add(new XElement("song", obj.ToString()));
            }
            XDocument xdoc = new XDocument(
                new XElement("song",
                    new XElement("id", tbArtistId.Text),
                    new XElement("name", $"{tbFirstName.Text} {tbLastName.Text}"),
                    new XElement("songs", songs)));

            xdoc.Save($"artist_{DateTime.Now.ToString("yyyyMMddHHmmss")}.xml", SaveOptions.OmitDuplicateNamespaces);

            Console.WriteLine(xdoc.ToString());
        }
    }
}
