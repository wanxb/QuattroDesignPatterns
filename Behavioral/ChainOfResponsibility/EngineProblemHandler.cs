namespace QuattroDesignPatterns.Behavioral.ChainOfResponsibility
{
    public class EngineProblemHandler : IProblemHandler
    {
        private IProblemHandler _nextHandler;

        public void SetNext(IProblemHandler nextHandler)
        {
            _nextHandler = nextHandler;
        }

        public void Handle(string problem)
        {
            if (problem == "engine")
            {
                Console.WriteLine("Engine problem handled by the Engine Team.");
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