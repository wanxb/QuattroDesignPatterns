namespace QuattroDesignPatterns.Structural.Composite
{
    public class CompositeDemo
    {
        #region Composite

        /*
            组合模式
            组合模式是一种结构型设计模式，它通过将对象组织成树形结构来表示“部分-整体”的层次结构。组合模式使得客户端对单个对象和组合对象的使用具有一致性。它主要用于需要处理对象的层次结构，且不希望对不同对象的操作进行区分时。

            使用场景
            当需要表示对象的部分-整体层次结构时。
            当希望客户端忽略组合对象与单个对象的差异时。
            文件系统、图形界面元素的层次化设计等。

            优点
            简化了客户端代码，客户端可以一致地处理单个对象和组合对象。
            容易增加新的对象类型。

            缺点
            设计较为复杂，尤其是在对象层次结构过于庞大时。
            使得叶子节点与容器节点的功能有所差异。

            扩展说明
            组合模式在许多实际应用中非常有用，特别是在需要对树形结构进行遍历、操作的场景。例如，HTML DOM 树结构、文件系统等。

            奥迪汽车例子
            假设我们要表示一辆奥迪汽车的零部件结构，每个部件可能由多个子部件组成，最终形成一个整体。通过组合模式，我们可以将“车门”、“车轮”等作为叶子节点，“车身”作为容器节点，并将它们组合成一个完整的汽车结构。
         */
        /*
            Composite Pattern
            The Composite Pattern is a structural design pattern that organizes objects into a tree structure to represent part-whole hierarchies. It allows clients to treat individual objects and compositions of objects uniformly. This pattern is useful when you need to deal with hierarchical objects without differentiating between leaf and composite nodes.

            Usage scenarios
            When you need to represent part-whole hierarchies of objects.
            When you want clients to ignore the differences between individual objects and compositions.
            Examples include file systems, graphical user interfaces with hierarchical components.

            Advantages
            Simplifies client code by allowing uniform treatment of individual and composite objects.
            Makes it easier to add new object types.

            Disadvantages
            Can make the design more complex, especially with a large object hierarchy.
            Leaf nodes and container nodes may have different responsibilities.

            Additional Notes
            The Composite Pattern is very useful in real-world applications where you need to traverse and operate on hierarchical structures. Examples include the HTML DOM tree and file systems.

            Audi Example
            Imagine we want to represent the structure of an Audi car, where each part might consist of multiple subparts, eventually forming a whole car. Using the Composite Pattern, we can treat "doors," "wheels" as leaf nodes and "car body" as a composite node, combining them into a complete car structure.
         */

        #endregion Composite

        public static void RunDemo()
        {
            Console.WriteLine("Welcome to the Audi Car Composite Pattern demo!");

            // Create individual car parts (leaves)
            ICarComponent wheel = new CarPart("Wheel");
            ICarComponent door = new CarPart("Door");
            ICarComponent engine = new CarPart("Engine");

            // Create composite parts (composite)
            CompositeCarPart carBody = new CompositeCarPart("Car Body");
            carBody.AddComponent(door);
            carBody.AddComponent(engine);

            CompositeCarPart car = new CompositeCarPart("Audi Car");
            car.AddComponent(carBody);
            car.AddComponent(wheel);

            // Display the whole car structure
            car.DisplayDetails();
        }
    }
}