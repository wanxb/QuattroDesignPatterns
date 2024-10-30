namespace QuattroDesignPatterns.Behavioral.Interpreter
{
    public class Context
    {
        public string Input { get; set; }

        public Context(string input)
        {
            Input = input;
        }
    }
}