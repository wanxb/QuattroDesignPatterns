namespace QuattroDesignPatterns.Behavioral.Visitor
{
    public interface IAudiVisitor
    {
        void Visit(AudiA3 a3);

        void Visit(AudiA4 a4);

        void Visit(AudiA6 a6);
    }
}