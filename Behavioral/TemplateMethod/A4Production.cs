namespace QuattroDesignPatterns.Behavioral.TemplateMethod
{
    public class A4Production : AudiCarProduction
    {
        protected override void AssembleParts()
        {
            Console.WriteLine("Assembling parts for Audi A4.");
        }

        protected override void TestCar()
        {
            Console.WriteLine("Testing Audi A4 performance.");
        }
    }
}