using System.Data.Linq;

namespace SongArchive.Models
{
    public class SongArchiveContext : DataContext
    {
        public Table<Song> Songs;
        public Table<Artist> Artists;
        public Table<Album> Albums;
        public Table<SongSingers> SongSingers;
        public Table<SongComposers> SongComposers;
        public Table<SongAlbums> SongAlbums;

        public SongArchiveContext(string connection) : base(connection) { }
    }
}
