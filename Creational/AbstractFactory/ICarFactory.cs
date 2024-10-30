namespace QuattroDesignPatterns.Creational.AbstractFactory
{
    public interface ICarFactory
    {
        IEngine CreateEngine();

        ITire CreateTire();
    }
}