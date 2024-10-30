namespace QuattroDesignPatterns.Behavioral.Command
{
    public class StopCarCommand : ICommand
    {
        private AudiCar _audiCar;

        public StopCarCommand(AudiCar audiCar)
        {
            _audiCar = audiCar;
        }

        public void Execute()
        {
            Console.WriteLine("Stopping the Audi car...");
            _audiCar.Stop();
        }

        public void Undo()
        {
            Console.WriteLine("Undoing stop command. Starting the Audi car...");
            _audiCar.Start();
        }
    }
}