namespace QuattroDesignPatterns.Structural.Decorator
{
    public class LuxuryPackage : CarDecorator
    {
        public LuxuryPackage(ICar car) : base(car)
        {
        }

        public override string GetDescription()
        {
            return _car.GetDescription() + ", Luxury Package";
        }

        public override double GetCost()
        {
            return _car.GetCost() + 8000; // Additional cost for luxury package
        }
    }
}