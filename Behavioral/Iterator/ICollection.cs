namespace QuattroDesignPatterns.Behavioral.Iterator
{
    public interface ICollection<T>
    {
        IIterator<T> CreateIterator();
    }
}