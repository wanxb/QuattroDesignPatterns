namespace QuattroDesignPatterns.Behavioral.Iterator
{
    public interface IIterator<T>
    {
        bool HasNext();

        T Next();
    }
}