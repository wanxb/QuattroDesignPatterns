namespace QuattroDesignPatterns.Behavioral.State
{
    public class AudiCar
    {
        private IEngineState _currentState;

        public AudiCar(IEngineState initialState)
        {
            _currentState = initialState;
        }

        public void SetState(IEngineState newState)
        {
            _currentState = newState;
        }

        public void HandleState()
        {
            _currentState.Handle(this);
        }
    }
}