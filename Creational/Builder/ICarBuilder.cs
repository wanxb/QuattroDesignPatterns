namespace QuattroDesignPatterns.Creational.Builder
{
    public interface ICarBuilder
    {
        ICarBuilder SetModel(string model);

        ICarBuilder SetColor(string color);

        ICarBuilder SetInterior(string interior);

        AudiCar Build();
    }
}