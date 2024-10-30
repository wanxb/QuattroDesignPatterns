namespace QuattroDesignPatterns.Structural.Decorator
{
    public class AudiA4 : ICar
    {
        public string GetDescription()
        {
            return "Audi A4 Base Model";
        }

        public double GetCost()
        {
            return 35000; // Base cost for Audi A4
        }
    }
}