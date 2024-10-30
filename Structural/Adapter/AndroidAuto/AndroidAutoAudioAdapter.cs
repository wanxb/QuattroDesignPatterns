namespace QuattroDesignPatterns.Structural.Adapter.AndroidAuto
{
    public class AndroidAutoAudioAdapter(AndroidAutoDevice androidAutoDevice) : IAudioSource
    {
        private readonly AndroidAutoDevice _androidAutoDevice = androidAutoDevice;

        public void PlayAudio()
        {
            Console.WriteLine(_androidAutoDevice.Connect());
            Console.WriteLine("Playing audio through Android Auto.");
        }
    }
}