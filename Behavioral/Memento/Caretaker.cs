namespace QuattroDesignPatterns.Behavioral.Memento
{
    public class Caretaker
    {
        private readonly List<Memento> _mementoList = new List<Memento>();
        private Originator _originator;

        public Caretaker(Originator originator)
        {
            _originator = originator;
        }

        public void AddMemento(Memento memento)
        {
            _mementoList.Add(memento);
        }

        public Memento GetMemento(int index)
        {
            return _mementoList[index];
        }
    }
}