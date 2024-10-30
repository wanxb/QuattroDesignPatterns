namespace QuattroDesignPatterns.Behavioral.State
{
    public class IdleState : IEngineState
    {
        public void Handle(AudiCar audiCar)
        {
            Console.WriteLine("The Audi engine is now idling.");
            audiCar.SetState(new DrivingState()); // Transition to DrivingState
        }
    }
}