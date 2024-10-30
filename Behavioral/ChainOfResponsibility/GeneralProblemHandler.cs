namespace QuattroDesignPatterns.Behavioral.ChainOfResponsibility
{
    public class GeneralProblemHandler : IProblemHandler
    {
        private IProblemHandler _nextHandler;

        public void SetNext(IProblemHandler nextHandler)
        {
            _nextHandler = nextHandler;
        }

        public void Handle(string problem)
        {
            if (problem == "general")
            {
                Console.WriteLine("General problem handled by the General Service Team.");
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