using System.Data.Linq;
using System.Data.Linq.Mapping;

namespace SongArchive.Models
{
    [Table(Name = "Songs")]
    public class Song
    {
        private int _SongID;
        [Column(IsPrimaryKey=true, Storage= "_SongID")]
        public int SongID { get { return this._SongID; } set { this._SongID = value; } }
        private string _Title;
        [Column(Storage="_Title")]
        public string Title { get { return this._Title; } set { this._Title = value; } }
        
        public Song()
        {
            _SongID = 0;
            _Title = null;
        }

        public Song(int id, string title)
        {
            this.SongID = id;
            this.Title = title;
        }

        public Song(string title)
        {
            this.Title = title;
        }
    }
}
