namespace QuattroDesignPatterns.Behavioral.Memento
{
    public class Originator
    {
        private string _state;

        public void SetState(string state)
        {
            _state = state;
            Console.WriteLine($"State set to: {_state}");
        }

        public Memento SaveStateToMemento()
        {
            Console.WriteLine("Saving state to Memento.");
            return new Memento(_state);
        }

        public void GetStateFromMemento(Memento memento)
        {
            _state = memento.State;
            Console.WriteLine($"State restored from Memento: {_state}");
        }
    }
}