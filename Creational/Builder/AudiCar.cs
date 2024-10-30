namespace QuattroDesignPatterns.Creational.Builder
{
    public class AudiCar(string model, string color, string interior) : ICar
    {
        private readonly string _model = model;
        private readonly string _color = color;
        private readonly string _interior = interior;

        public void ShowDetails()
        {
            Console.WriteLine($"Model: {_model}, Color: {_color}, Interior: {_interior}");
        }
    }
}