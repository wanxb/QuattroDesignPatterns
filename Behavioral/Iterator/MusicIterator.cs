namespace QuattroDesignPatterns.Behavioral.Iterator
{
    public class MusicIterator : IIterator<string>
    {
        private readonly MusicPlaylist _playlist;
        private int _currentIndex;

        public MusicIterator(MusicPlaylist playlist)
        {
            _playlist = playlist;
            _currentIndex = 0;
        }

        public bool HasNext()
        {
            return _currentIndex < _playlist.Count;
        }

        public string Next()
        {
            return _playlist.GetSong(_currentIndex++);
        }
    }
}