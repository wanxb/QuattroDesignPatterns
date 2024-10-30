namespace QuattroDesignPatterns.Structural.Proxy
{
    public class CarDiagnosticsProxy(string carModel) : ICarDiagnostics
    {
        private readonly string _carModel = carModel;
        private RealCarDiagnostics _realDiagnostics;

        public void RunDiagnostics()
        {
            Console.WriteLine($"Checking pre-conditions for Audi model {_carModel} diagnostics...");

            if (_realDiagnostics == null)
            {
                _realDiagnostics = new RealCarDiagnostics(_carModel);
            }

            // Simulate pre-checks like permissions, network status, etc.
            Console.WriteLine("Pre-checks passed. Now starting diagnostics...");
            _realDiagnostics.RunDiagnostics();
        }
    }
}