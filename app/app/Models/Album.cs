using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SongArchive.Models
{
    public class Album
    {
        public int AlbumID { get; }
        public string AlbumName { get; set; }

        public Album(int id, string name)
        {
            this.AlbumID = id;
            this.AlbumName = name;
        }
        
        public Album(string name)
        {
            this.AlbumName = name;
        }   
    }
}
