namespace QuattroDesignPatterns.Structural.Adapter
{
    internal class AudiMultimediaSystem(IAudioSource audioSource)
    {
        private readonly IAudioSource _audioSource = audioSource;

        public void PlayMusic()
        {
            _audioSource.PlayAudio();
        }
    }
}