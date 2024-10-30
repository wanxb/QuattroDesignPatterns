namespace QuattroDesignPatterns.Structural.Composite
{
    public class CompositeCarPart : ICarComponent
    {
        private readonly string _name;
        private readonly List<ICarComponent> _components = new List<ICarComponent>();

        public CompositeCarPart(string name)
        {
            _name = name;
        }

        public void AddComponent(ICarComponent component)
        {
            _components.Add(component);
        }

        public void DisplayDetails()
        {
            Console.WriteLine($"Composite Car Part: {_name}");
            foreach (var component in _components)
            {
                component.DisplayDetails();
            }
        }
    }
}