namespace QuattroDesignPatterns.Creational.Prototype
{
    public class AudiCarPrototype(string model, string color, string interior) : ICarPrototype
    {
        public string Model { get; set; } = model;
        public string Color { get; set; } = color;
        public string Interior { get; set; } = interior;

        public ICarPrototype Clone()
        {
            return new AudiCarPrototype(Model, Color, Interior);
        }

        public void ShowDetails()
        {
            Console.WriteLine($"Model: {Model}, Color: {Color}, Interior: {Interior}");
        }
    }
}