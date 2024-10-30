namespace QuattroDesignPatterns.Behavioral.Strategy
{
    public class EcoMode : IDrivingMode
    {
        public void Drive()
        {
            Console.WriteLine("Driving in Eco Mode: Fuel-efficient and smooth.");
        }
    }
}