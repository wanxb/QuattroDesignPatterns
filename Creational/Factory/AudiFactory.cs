namespace QuattroDesignPatterns.Creational.Factory
{
    public static class AudiFactory
    {
        public static ICar CreateCar(string model, string configuration)
        {
            return new AudiCar(model, configuration);
        }
    }
}