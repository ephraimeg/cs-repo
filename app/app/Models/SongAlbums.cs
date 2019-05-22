using System.Data.Linq;
using System.Data.Linq.Mapping;

namespace SongArchive.Models
{
    [Table(Name = "SongAlbums")]
    public class SongAlbums
    {
        private int _songid;
        private int _albumid;
        private EntityRef<Song> _song;
        private EntityRef<Album> _album;
        
        [Column(IsPrimaryKey = true, Storage = "_songid")]
        public int SongId { get { return this._songid; } set { this._songid = value; } }
        [Column(IsPrimaryKey = true, Storage = "_albumid")]
        public int AlbumId { get { return this._albumid; } set { this._albumid = value; } }
        [Association(Storage = "_song", IsForeignKey = true, ThisKey = "SongId")]
        public Song Song { get { return this._song.Entity; } set { this._song.Entity = value; } }
        [Association(Storage = "_album", IsForeignKey = true, ThisKey = "AlbumId")]
        public Album Album { get { return this._album.Entity; } set { this._album.Entity = value; } }
        public SongAlbums() { }
    }
}
