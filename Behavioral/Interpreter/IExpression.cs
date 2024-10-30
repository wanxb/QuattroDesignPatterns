namespace QuattroDesignPatterns.Behavioral.Interpreter
{
    public interface IExpression
    {
        void Interpret(Context context);
    }
}