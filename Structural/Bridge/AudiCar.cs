using QuattroDesignPatterns.Structural.Bridge.Engine;
using QuattroDesignPatterns.Structural.Bridge.Transmission;

namespace QuattroDesignPatterns.Structural.Bridge
{
    public class AudiCar(IEngine engine, ITransmission transmission)
    {
        private readonly IEngine _engine = engine;
        private readonly ITransmission _transmission = transmission;

        public void Drive()
        {
            _engine.Start();
            _transmission.Shift();
            Console.WriteLine("The Audi car is now driving.");
        }
    }
}