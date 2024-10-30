namespace QuattroDesignPatterns.Behavioral.Interpreter
{
    public class Interpreter
    {
        private List<IExpression> _expressions;

        public Interpreter()
        {
            _expressions = new List<IExpression>
        {
            new GoExpression(),
            new StopExpression()
        };
        }

        public void Interpret(string input)
        {
            Context context = new Context(input);

            foreach (var expression in _expressions)
            {
                expression.Interpret(context);
            }
        }
    }
}