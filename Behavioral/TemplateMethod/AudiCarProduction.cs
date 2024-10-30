namespace QuattroDesignPatterns.Behavioral.TemplateMethod
{
    public abstract class AudiCarProduction
    {
        // Template method
        public void ProduceCar()
        {
            AssembleParts();
            TestCar();
            InspectQuality();
            Console.WriteLine("Audi car production completed.");
        }

        protected abstract void AssembleParts();

        protected abstract void TestCar();

        protected virtual void InspectQuality()
        {
            Console.WriteLine("Quality inspection completed.");
        }
    }
}