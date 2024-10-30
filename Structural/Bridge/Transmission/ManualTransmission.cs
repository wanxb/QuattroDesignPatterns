namespace QuattroDesignPatterns.Structural.Bridge.Transmission
{
    public class ManualTransmission : ITransmission
    {
        public void Shift()
        {
            Console.WriteLine("Manual transmission shifts with a click.");
        }
    }
}