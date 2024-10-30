namespace QuattroDesignPatterns.Structural.Flyweight
{
    #region Flyweight

    /*
        享元模式
        享元模式是一种结构型设计模式，它通过共享细粒度的对象来尽可能减少内存使用。享元模式适用于具有大量类似对象且内存占用较高的场景，通过共享相同的对象来避免重复创建。

        使用场景
        应用中存在大量相似对象，每个对象占用的内存开销较大。
        对象的状态可以分为内蕴状态（共享的部分）和外蕴状态（独立的部分）。

        优点
        通过共享对象减少内存使用，提升性能。
        提高了系统的可扩展性，因为共享的对象可以重复使用。

        缺点
        实现复杂，需要区分对象的内蕴状态和外蕴状态。
        为了实现共享，可能引入一些复杂的对象管理逻辑。

        扩展说明
        享元模式可以有效用于缓存和池化技术中，例如字符串池、数据库连接池等场景。享元模式通过将内蕴状态存储在共享对象中，使得客户端可以同时使用这些对象并节省内存。

        奥迪汽车例子
        假设我们在奥迪汽车的制造过程中，所有相同型号的汽车共享相同的引擎配置，这样就不需要为每辆车都创建一个新的引擎对象。引擎配置可以作为享元对象，而车身颜色等个性化的配置则是外蕴状态。
     */
    /*
        Flyweight Pattern
        The Flyweight Pattern is a structural design pattern that minimizes memory usage by sharing as much data as possible with similar objects. It is particularly useful when a large number of objects are created that have a significant memory footprint. The Flyweight Pattern reduces the overhead by sharing objects that are identical in certain aspects.

        Usage scenarios
        When an application has many similar objects, and each object consumes a lot of memory.
        When objects can be divided into intrinsic (shared) and extrinsic (unique) states.

        Advantages
        Reduces memory usage by sharing objects.
        Improves system scalability, as shared objects can be reused multiple times.

        Disadvantages
        Increased complexity due to the need to separate intrinsic and extrinsic states.
        May introduce complicated object management logic to achieve sharing.

        Additional Notes
        The Flyweight Pattern is often used in caching and pooling technologies, such as string pools, database connection pools, and more. By storing intrinsic state in shared objects, clients can reuse these objects and save memory.

        Audi Example
        Imagine in the manufacturing process of Audi cars, all cars of the same model share the same engine configuration. This way, there is no need to create a new engine object for each car. The engine configuration serves as a flyweight object, while attributes like body color are extrinsic states unique to each car.
     */

    #endregion Flyweight

    public class FlyweightDemo
    {
        public static void RunDemo()
        {
            Console.WriteLine("Welcome to the Audi Car Flyweight Demo!");

            var engineFactory = new EngineFactory();

            // Car 1
            var engine1 = engineFactory.GetEngine("V6");
            engine1.Display("Audi A4", "Red");

            // Car 2
            var engine2 = engineFactory.GetEngine("V6");
            engine2.Display("Audi A6", "Black");

            // Car 3
            var engine3 = engineFactory.GetEngine("V8");
            engine3.Display("Audi A8", "White");

            Console.WriteLine("Notice that the same engine configuration is reused for the V6 models.");
        }
    }
}