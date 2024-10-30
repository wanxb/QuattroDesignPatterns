namespace QuattroDesignPatterns.Structural.Flyweight
{
    public class EngineFactory
    {
        private readonly Dictionary<string, IEngine> _engines = new Dictionary<string, IEngine>();

        public IEngine GetEngine(string engineType)
        {
            if (!_engines.ContainsKey(engineType))
            {
                _engines[engineType] = new Engine(engineType);
            }
            return _engines[engineType];
        }
    }
}