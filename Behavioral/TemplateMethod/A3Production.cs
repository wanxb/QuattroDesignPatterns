namespace QuattroDesignPatterns.Behavioral.TemplateMethod
{
    public class A3Production : AudiCarProduction
    {
        protected override void AssembleParts()
        {
            Console.WriteLine("Assembling parts for Audi A3.");
        }

        protected override void TestCar()
        {
            Console.WriteLine("Testing Audi A3 performance.");
        }
    }
}