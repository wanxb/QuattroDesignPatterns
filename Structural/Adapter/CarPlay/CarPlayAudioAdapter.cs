namespace QuattroDesignPatterns.Structural.Adapter.CarPlay
{
    public class CarPlayAudioAdapter(CarPlayDevice carPlayDevice) : IAudioSource
    {
        private readonly CarPlayDevice _carPlayDevice = carPlayDevice;

        public void PlayAudio()
        {
            Console.WriteLine(_carPlayDevice.Connect());
            Console.WriteLine("Playing audio through CarPlay.");
        }
    }
}