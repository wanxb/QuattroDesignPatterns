namespace QuattroDesignPatterns.Structural.Decorator
{
    public class SportPackage : CarDecorator
    {
        public SportPackage(ICar car) : base(car)
        {
        }

        public override string GetDescription()
        {
            return _car.GetDescription() + ", Sport Package";
        }

        public override double GetCost()
        {
            return _car.GetCost() + 5000; // Additional cost for sport package
        }
    }
}