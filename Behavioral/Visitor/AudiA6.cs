namespace QuattroDesignPatterns.Behavioral.Visitor
{
    public class AudiA6
    {
        public void Accept(IAudiVisitor visitor)
        {
            visitor.Visit(this);
        }

        public void ShowDetails()
        {
            Console.WriteLine("This is an Audi A6.");
        }
    }
}