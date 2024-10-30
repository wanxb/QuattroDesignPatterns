namespace QuattroDesignPatterns.Structural.Composite
{
    public class CarPart : ICarComponent
    {
        private readonly string _name;

        public CarPart(string name)
        {
            _name = name;
        }

        public void DisplayDetails()
        {
            Console.WriteLine($"Car Part: {_name}");
        }
    }
}