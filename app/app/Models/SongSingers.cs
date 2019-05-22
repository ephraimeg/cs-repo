using System.Data.Linq;
using System.Data.Linq.Mapping;

namespace SongArchive.Models
{
    [Table(Name = "SongSingers")]
    public class SongSingers
    {
        private int _songid;
        private int _artistid;
        private EntityRef<Song> _song;
        private EntityRef<Artist> _artist;
        
        [Column(Storage = "_songid")]
        public int SongId { get { return this._songid; } set { this._songid = value; } }
        [Column(Storage = "_artistid")]
        public int ArtistId { get { return this._artistid; } set { this._artistid = value; } }
        [Association(Storage = "_song", IsForeignKey = true, ThisKey = "SongId")]
        public Song Song { get { return this._song.Entity; } set { this._song.Entity = value; } }
        [Association(Storage = "_artist", IsForeignKey = true, ThisKey = "ArtistId")]
        public Artist Artist { get { return this._artist.Entity; } set { this._artist.Entity = value; } }
        public SongSingers() { }
    }
}
