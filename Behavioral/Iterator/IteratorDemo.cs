namespace QuattroDesignPatterns.Behavioral.Iterator
{
    #region Iterator

    /*
        迭代器模式
        迭代器模式是一种行为型设计模式，它提供一种方法来顺序访问集合对象中的元素，而不暴露集合对象的内部表示。通过使用迭代器，可以在不需要了解集合内部结构的情况下，遍历集合中的元素。

        使用场景
        当需要访问集合中的元素，但不需要暴露集合的内部结构时。
        当需要在不修改集合的情况下遍历集合中的元素时。
        当需要支持多种不同的遍历方式时。

        优点
        可以提供一致的遍历接口，简化了集合的访问。
        遍历代码与集合的内部实现分离，提高了系统的灵活性。

        缺点
        可能需要为每个集合实现一个迭代器，增加了代码的复杂性。
        如果集合的结构非常复杂，可能会导致迭代器的实现也变得复杂。

        扩展说明
        迭代器模式可以与组合模式结合使用，以便在树形结构中进行遍历。它也可以用来简化并统一对不同集合的访问，如列表、数组等。

        奥迪汽车例子
        想象一辆奥迪汽车的车载媒体系统，它可以播放音乐列表，用户可以通过迭代器顺序访问列表中的每一首歌曲，而无需关心媒体列表的内部实现细节。
     */
    /*
        Iterator Pattern
        The Iterator Pattern is a behavioral design pattern that provides a way to access the elements of a collection object sequentially without exposing its internal representation. By using an iterator, elements can be traversed without needing to understand the internal structure of the collection.

        Usage scenarios
        When you need to access elements in a collection without exposing its internal structure.
        When you want to traverse the elements of a collection without modifying it.
        When you need to support multiple ways of iterating through a collection.

        Advantages
        Provides a consistent traversal interface, simplifying access to collections.
        Separates iteration code from the internal implementation of the collection, enhancing system flexibility.

        Disadvantages
        It may require an iterator to be implemented for each collection, increasing code complexity.
        If the collection's structure is very complex, it can make the implementation of the iterator complex as well.

        Additional Notes
        The Iterator Pattern can be combined with the Composite Pattern to facilitate traversal in tree structures. It can also simplify and unify access to different types of collections, such as lists, arrays, etc.

        Audi Example
        Consider the Audi car's media system that allows playback of a music playlist. Users can sequentially access each song in the playlist through an iterator without needing to understand the underlying implementation details of the media list.
     */

    #endregion Iterator

    public class IteratorDemo
    {
        public static void RunDemo()
        {
            Console.WriteLine("Welcome to the Audi Music Playlist Iterator!");

            var playlist = new MusicPlaylist();
            playlist.AddSong("Song 1");
            playlist.AddSong("Song 2");
            playlist.AddSong("Song 3");

            var iterator = playlist.CreateIterator();

            Console.WriteLine("Playing songs in the playlist:");
            while (iterator.HasNext())
            {
                string song = iterator.Next();
                Console.WriteLine($"Now playing: {song}");
            }
        }
    }
}