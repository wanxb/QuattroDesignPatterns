namespace QuattroDesignPatterns.Behavioral.ChainOfResponsibility
{
    public class TireProblemHandler : IProblemHandler
    {
        private IProblemHandler _nextHandler;

        public void SetNext(IProblemHandler nextHandler)
        {
            _nextHandler = nextHandler;
        }

        public void Handle(string problem)
        {
            if (problem == "tire")
            {
                Console.WriteLine("Tire problem handled by the Tire Team.");
            }
            else if (_nextHandler != null)
            {
                _nextHandler.Handle(problem);
            }
            else
            {
                Console.WriteLine("Problem not handled.");
            }
        }
    }
}