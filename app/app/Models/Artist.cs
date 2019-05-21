using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SongArchive.Models
{
    public class Artist
    {
        public int ArtistID { get; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Artist(int id, string fname, string lname)
        {
            this.ArtistID = id;
            this.FirstName = fname;
            this.LastName = lname;
        }
        public Artist(string fname, string lname)
        {
            this.FirstName = fname;
            this.LastName = lname;
        }
    }
}
