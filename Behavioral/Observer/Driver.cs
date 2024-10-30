namespace QuattroDesignPatterns.Behavioral.Observer
{
    public class Driver : IObserver
    {
        private string _name;

        public Driver(string name)
        {
            _name = name;
        }

        public void Update(string message)
        {
            Console.WriteLine($"Driver {_name} received update: {message}");
        }
    }
}