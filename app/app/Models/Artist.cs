using System.Data.Linq;
using System.Data.Linq.Mapping;

namespace SongArchive.Models
{
    [Table(Name = "Artists")]
    public class Artist
    {
        private int _artistid;
        private string _firstname;
        private string _lastname;
        private EntitySet<SongComposers> _SongComposers;
        private EntitySet<SongSingers> _SongSingers;

        [Column(IsPrimaryKey = true, IsDbGenerated = true, Storage = "_artistid")]
        public int ArtistId { get { return _artistid; } }
        [Column(Storage = "_firstname")]
        public string FirstName { get { return _firstname; } set { this._firstname = value; } }
        [Column(Storage = "_lastname")]
        public string LastName { get { return _lastname; } set { this._lastname = value; } }
        [Association(Storage = "_SongComposers", OtherKey = "ArtistId")]
        public EntitySet<SongComposers> SongComposers { get { return this._SongComposers; } set { this._SongComposers = value; } }
        [Association(Storage = "_SongComposers", OtherKey = "ArtistId")]
        public EntitySet<SongSingers> SongSingers { get { return this._SongSingers; } set { this._SongSingers = value; } }

        public Artist()
        {
            this._SongComposers = new EntitySet<SongComposers>();
            this._SongSingers = new EntitySet<SongSingers>();
        }

        public Artist(int id, string fname, string lname)
        {
            this._artistid = id;
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
