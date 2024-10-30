namespace QuattroDesignPatterns.Creational.Builder
{
    public class AudiCarBuilder : ICarBuilder
    {
        private string _model;
        private string _color;
        private string _interior;

        public ICarBuilder SetModel(string model)
        {
            _model = model;
            return this;
        }

        public ICarBuilder SetColor(string color)
        {
            _color = color;
            return this;
        }

        public ICarBuilder SetInterior(string interior)
        {
            _interior = interior;
            return this;
        }

        public AudiCar Build()
        {
            return new AudiCar(_model, _color, _interior);
        }
    }
}