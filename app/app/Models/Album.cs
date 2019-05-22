using System.Data.Linq;
using System.Data.Linq.Mapping;

namespace SongArchive.Models
{
    [Table(Name = "Albums")]
    public class Album
    {
        private int _albumid;
        private string _albumname;
        private EntitySet<SongAlbums> _SongAlbums;
        
        [Column(IsPrimaryKey = true, IsDbGenerated = true, Storage = "_albumid")]
        public int AlbumId { get { return this._albumid; } }
        [Column(Storage = "_albumname")]
        public string AlbumName { get { return this._albumname; } set { this._albumname = value; } }
        [Association(Storage = "_SongAlbums", OtherKey = "AlbumId")]
        public EntitySet<SongAlbums> SongAlbums { get { return this._SongAlbums; } set { this._SongAlbums = value; } }

        public Album()
        {
            this._SongAlbums = new EntitySet<SongAlbums>();
        }

        public Album(int id, string name)
        {
            this._albumid = id;
            this.AlbumName = name;
        }
        
        public Album(string name)
        {
            this.AlbumName = name;
        }   
    }
}
