using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using System.Xml.Linq;

namespace SongArchive
{
    public partial class DetailArtistView : UserControl
    {
        public DetailArtistView()
        {
            InitializeComponent();
        }

        public void Show(string value, DataSet ds)
        {
            DataRow[] rows = ds.Tables[0].Select($"songId = '{value}'");
            tbSongId.Text = value;
            tbSongTitle.Text = rows[0].ItemArray[3].ToString();
            //tbLastName.Text = rows[0].ItemArray[2].ToString();

            foreach (DataRow row in rows)
            {
                lbSingers.Items.Add($"{row.ItemArray[1].ToString()} {row.ItemArray[2].ToString()}");
            }

            this.Show();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            List<XElement> artists = new List<XElement>();

            foreach (object obj in lbSingers.Items)
            {
                artists.Add(new XElement("artist", obj.ToString()));
            }
            XDocument xdoc = new XDocument(
                new XElement("song",
                    new XElement("id", tbSongId.Text),
                    new XElement("title", tbSongTitle.Text),
                    new XElement("singers", artists)));

            xdoc.Save($"song_{DateTime.Now.ToString("yyyyMMddHHmmss")}.xml",SaveOptions.OmitDuplicateNamespaces);

            Console.WriteLine(xdoc.ToString());
        }
    }
}
