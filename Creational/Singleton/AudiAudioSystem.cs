namespace QuattroDesignPatterns.Creational.Singleton
{
    public class AudiAudioSystem : IAudioSystem
    {
        private static AudiAudioSystem? _instance;

        // Locks used to control thread safety
        private static readonly object _lock = new();

        // Private constructor to prevent external instantiation
        private AudiAudioSystem()
        { }

        // Public static method GetInstance
        public static AudiAudioSystem Instance
        {
            get
            {
                // Double-checked locking for thread safety and lazy loading
                if (_instance == null)
                {
                    lock (_lock)
                    {
                        _instance ??= new AudiAudioSystem();
                    }
                }
                return _instance;
            }
        }

        public void PlayMusic(string track)
        {
            Console.WriteLine($"Playing: {track} on Audi MMI system.");
        }

        public void StopMusic()
        {
            Console.WriteLine("Music stopped on Audi MMI system.");
        }
    }
}