namespace QuattroDesignPatterns.Structural.Bridge.Transmission
{
    public class AutomaticTransmission : ITransmission
    {
        public void Shift()
        {
            Console.WriteLine("Automatic transmission shifts smoothly.");
        }
    }
}