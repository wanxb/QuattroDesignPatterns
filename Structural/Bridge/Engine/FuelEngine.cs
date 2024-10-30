namespace QuattroDesignPatterns.Structural.Bridge.Engine
{
    public class FuelEngine : IEngine
    {
        public void Start()
        {
            Console.WriteLine("Fuel engine starts with a roar.");
        }
    }
}