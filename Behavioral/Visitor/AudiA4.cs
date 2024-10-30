namespace QuattroDesignPatterns.Behavioral.Visitor
{
    public class AudiA4
    {
        public void Accept(IAudiVisitor visitor)
        {
            visitor.Visit(this);
        }

        public void ShowDetails()
        {
            Console.WriteLine("This is an Audi A4.");
        }
    }
}