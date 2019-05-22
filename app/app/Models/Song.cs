using System.Data.Linq;
using System.Data.Linq.Mapping;

namespace SongArchive.Models
{
    [Table(Name = "Songs")]
    public class Song
    {
        private int _SongID;
        private string _Title;
        private EntitySet<SongComposers> _SongComposers;
        private EntitySet<SongSingers> _SongSingers;
        private EntitySet<SongAlbums> _SongAlbums;

        [Column(IsPrimaryKey=true, IsDbGenerated = true, Storage= "_SongID")]
        public int SongID { get { return this._SongID; } }
        [Column(Storage="_Title")]
        public string Title { get { return this._Title; } set { this._Title = value; } }
        [Association(Storage = "_SongComposers", OtherKey = "SongId")]
        public EntitySet<SongComposers> SongComposers { get { return this._SongComposers; } set { this._SongComposers = value; } }
        [Association(Storage = "_SongSingers", OtherKey = "SongId")]
        public EntitySet<SongSingers> SongSingers { get { return this._SongSingers; } set { this._SongSingers = value; } }
        [Association(Storage = "_SongAlbums", OtherKey = "SongId")]
        public EntitySet<SongAlbums> SongAlbums { get { return this._SongAlbums; } set { this._SongAlbums = value; } }

        public Song()
        {
            this._SongComposers = new EntitySet<SongComposers>();
            this._SongSingers = new EntitySet<SongSingers>();
        }

        public Song(int id, string title)
        {
            this._SongID = id;
            this.Title = title;
        }

        public Song(string title)
        {
            this.Title = title;
        }
    }
}
