namespace QuattroDesignPatterns.Structural.Facade
{
    public class AudiMMIFacade
    {
        private readonly AudioSystem _audioSystem;
        private readonly NavigationSystem _navigationSystem;
        private readonly BluetoothSystem _bluetoothSystem;

        public AudiMMIFacade()
        {
            _audioSystem = new AudioSystem();
            _navigationSystem = new NavigationSystem();
            _bluetoothSystem = new BluetoothSystem();
        }

        public void StartJourney(string destination, string phoneName)
        {
            Console.WriteLine("Initializing the Audi MMI system...");
            _audioSystem.PlayMusic();
            _navigationSystem.SetDestination(destination);
            _bluetoothSystem.ConnectPhone(phoneName);
            Console.WriteLine("All systems are ready. Enjoy your journey!");
        }
    }
}