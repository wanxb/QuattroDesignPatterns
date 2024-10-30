namespace QuattroDesignPatterns.Creational.AbstractFactory.Sport
{
    public class SportCarFactory : ICarFactory
    {
        public IEngine CreateEngine()
        {
            return new SportEngine();
        }

        public ITire CreateTire()
        {
            return new SportTire();
        }
    }
}