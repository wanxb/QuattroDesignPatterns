namespace QuattroDesignPatterns.Behavioral.Interpreter
{
    public class StopExpression : IExpression
    {
        public void Interpret(Context context)
        {
            if (context.Input.Contains("Stop"))
            {
                Console.WriteLine("The Audi car has stopped.");
            }
        }
    }
}