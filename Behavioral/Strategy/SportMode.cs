namespace QuattroDesignPatterns.Behavioral.Strategy
{
    public class SportMode : IDrivingMode
    {
        public void Drive()
        {
            Console.WriteLine("Driving in Sport Mode: High performance and quick acceleration.");
        }
    }
}