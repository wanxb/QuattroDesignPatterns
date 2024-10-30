namespace QuattroDesignPatterns.Behavioral.State
{
    public class DrivingState : IEngineState
    {
        public void Handle(AudiCar audiCar)
        {
            Console.WriteLine("The Audi is now driving.");
            // Normally you might transition back to Idle after some action
        }
    }
}