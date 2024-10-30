namespace QuattroDesignPatterns.Behavioral.Strategy
{
    public class ComfortMode : IDrivingMode
    {
        public void Drive()
        {
            Console.WriteLine("Driving in Comfort Mode: Balanced ride with smooth handling.");
        }
    }
}