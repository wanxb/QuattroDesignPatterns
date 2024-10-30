namespace QuattroDesignPatterns.Creational.Factory
{
    public class AudiCar(string model, string configuration) : ICar
    {
        private readonly string _model = model;
        private readonly string _configuration = configuration;

        public string GetModel()
        {
            return $"{_model} ({_configuration} configuration)";
        }

        public void Drive()
        {
            Console.WriteLine($"Driving the Audi {_model} ({_configuration} configuration).");
        }
    }
}