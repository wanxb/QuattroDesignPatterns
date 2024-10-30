namespace QuattroDesignPatterns.Creational.AbstractFactory.Luxury
{
    public class LuxuryCarFactory : ICarFactory
    {
        public IEngine CreateEngine()
        {
            return new LuxuryEngine();
        }

        public ITire CreateTire()
        {
            return new LuxuryTire();
        }
    }
}