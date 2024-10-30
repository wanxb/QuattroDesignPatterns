namespace QuattroDesignPatterns.Structural.Proxy
{
    public class RealCarDiagnostics : ICarDiagnostics
    {
        private readonly string _carModel;

        public RealCarDiagnostics(string carModel)
        {
            _carModel = carModel;
        }

        public void RunDiagnostics()
        {
            Console.WriteLine($"Running in-depth diagnostics on Audi model {_carModel}...");
            // Simulate time-consuming diagnostic process
            System.Threading.Thread.Sleep(2000);
            Console.WriteLine("Diagnostics complete!");
        }
    }
}