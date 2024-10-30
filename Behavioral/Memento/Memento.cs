namespace QuattroDesignPatterns.Behavioral.Memento
{
    public class Memento
    {
        public string State { get; private set; }

        public Memento(string state)
        {
            State = state;
        }
    }
}