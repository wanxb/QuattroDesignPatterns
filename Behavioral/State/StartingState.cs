namespace QuattroDesignPatterns.Behavioral.State
{
    public class StartingState : IEngineState
    {
        public void Handle(AudiCar audiCar)
        {
            Console.WriteLine("The Audi engine is starting...");
            audiCar.SetState(new IdleState()); // Transition to IdleState
        }
    }
}