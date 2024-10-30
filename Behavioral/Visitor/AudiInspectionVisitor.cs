namespace QuattroDesignPatterns.Behavioral.Visitor
{
    public class AudiInspectionVisitor : IAudiVisitor
    {
        public void Visit(AudiA3 a3)
        {
            Console.WriteLine("Inspecting Audi A3...");
            a3.ShowDetails();
            Console.WriteLine("Audi A3 inspection complete.\n");
        }

        public void Visit(AudiA4 a4)
        {
            Console.WriteLine("Inspecting Audi A4...");
            a4.ShowDetails();
            Console.WriteLine("Audi A4 inspection complete.\n");
        }

        public void Visit(AudiA6 a6)
        {
            Console.WriteLine("Inspecting Audi A6...");
            a6.ShowDetails();
            Console.WriteLine("Audi A6 inspection complete.\n");
        }
    }
}