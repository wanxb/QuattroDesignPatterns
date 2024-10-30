namespace QuattroDesignPatterns.Structural.Flyweight
{
    public class Engine : IEngine
    {
        private readonly string _engineType;

        public Engine(string engineType)
        {
            _engineType = engineType;
        }

        public void Display(string carModel, string color)
        {
            Console.WriteLine($"Car Model: {carModel}, Engine: {_engineType}, Color: {color}");
        }
    }
}