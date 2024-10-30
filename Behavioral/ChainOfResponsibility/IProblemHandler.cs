namespace QuattroDesignPatterns.Behavioral.ChainOfResponsibility
{
    public interface IProblemHandler
    {
        void SetNext(IProblemHandler nextHandler);

        void Handle(string problem);
    }
}