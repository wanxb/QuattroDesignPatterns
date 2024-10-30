namespace QuattroDesignPatterns.Behavioral.Iterator
{
    public class MusicPlaylist : ICollection<string>
    {
        private List<string> _songs = new List<string>();

        public void AddSong(string song)
        {
            _songs.Add(song);
        }

        public IIterator<string> CreateIterator()
        {
            return new MusicIterator(this);
        }

        public int Count => _songs.Count;

        public string GetSong(int index)
        {
            return _songs[index];
        }
    }
}