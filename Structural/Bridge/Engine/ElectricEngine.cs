namespace QuattroDesignPatterns.Structural.Bridge.Engine
{
    public class ElectricEngine : IEngine
    {
        public void Start()
        {
            Console.WriteLine("Electric engine starts silently.");
        }
    }
}