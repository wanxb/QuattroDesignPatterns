namespace QuattroDesignPatterns.Behavioral.Interpreter
{
    public class GoExpression : IExpression
    {
        public void Interpret(Context context)
        {
            if (context.Input.Contains("Go"))
            {
                Console.WriteLine("The Audi car is moving.");
            }
        }
    }
}