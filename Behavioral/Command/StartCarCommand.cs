namespace QuattroDesignPatterns.Behavioral.Command
{
    public class StartCarCommand : ICommand
    {
        private AudiCar _audiCar;

        public StartCarCommand(AudiCar audiCar)
        {
            _audiCar = audiCar;
        }

        public void Execute()
        {
            Console.WriteLine("Starting the Audi car...");
            _audiCar.Start();
        }

        public void Undo()
        {
            Console.WriteLine("Undoing start command. Stopping the Audi car...");
            _audiCar.Stop();
        }
    }
}