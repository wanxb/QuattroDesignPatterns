namespace QuattroDesignPatterns.Behavioral.Visitor
{
    #region Visitor

    /*
        访问者模式
        访问者模式是一种行为型设计模式，它允许你在不改变对象结构的前提下，定义新的操作。通过访问者模式，可以将操作的逻辑与对象的结构分离，使得在不影响现有代码的情况下，可以轻松地添加新的操作。

        使用场景
        当一个对象结构中的元素数量不确定，且需要对这些元素进行多种不同的操作时。
        当你需要在对象结构中添加新操作，但又不想修改对象结构时。
        当你希望将某些操作分离到独立的类中，以便更好地组织代码。

        优点
        增强了系统的可扩展性，可以很方便地为对象结构添加新操作。
        通过将操作封装在访问者中，能够提高代码的可读性。
        促进了操作与对象结构的解耦，易于维护。

        缺点
        增加了系统的复杂性，尤其是对象结构变化时，可能需要修改所有访问者。
        需要在访问者中添加每个元素的操作，导致访问者可能变得庞大。

        扩展说明
        访问者模式广泛应用于需要对复杂对象结构进行操作的场景，例如编译器、报表生成器等。在这些场景中，访问者模式提供了一种优雅的方式来组织和管理复杂的操作。

        奥迪汽车例子
        想象一下，在一个汽车工厂中，有不同类型的汽车（如A3、A4、A6）。每种汽车都有不同的配置和功能（如引擎类型、车内装饰等）。通过访问者模式，可以创建一个访问者，来为不同类型的汽车实现不同的检查和维修操作，而不需要修改汽车的类定义。
     */
    /*
        Visitor Pattern
        The Visitor Pattern is a behavioral design pattern that allows you to define new operations on an object structure without changing the structure itself. By using the Visitor Pattern, you can separate the logic of operations from the structure of the objects, making it easier to add new operations without affecting existing code.

        Usage scenarios
        When the number of elements in an object structure is uncertain, and various operations need to be performed on these elements.
        When you need to add new operations to an object structure without modifying it.
        When you want to separate certain operations into independent classes for better organization of code.

        Advantages
        Enhances the extensibility of the system, allowing easy addition of new operations for the object structure.
        Improves code readability by encapsulating operations within visitors.
        Promotes decoupling of operations from object structures, making maintenance easier.

        Disadvantages
        Increases the complexity of the system, especially when the object structure changes, as it may require modification of all visitors.
        Every time a new operation is added, the visitor must implement operations for each element, which can lead to a bloated visitor class.

        Additional Notes
        The Visitor Pattern is widely used in scenarios that require operations on complex object structures, such as compilers and report generators. In these scenarios, the Visitor Pattern provides an elegant way to organize and manage complex operations.

        Audi Example
        Imagine a car factory with different types of cars (like A3, A4, A6). Each car has different configurations and features (like engine type, interior decor, etc.). By using the Visitor Pattern, a visitor can be created to implement various inspection and maintenance operations for different types of cars without modifying their class definitions.
     */

    #endregion Visitor

    public class VisitorDemo
    {
        public static void RunDemo()
        {
            var a3 = new AudiA3();
            var a4 = new AudiA4();
            var a6 = new AudiA6();

            var inspectionVisitor = new AudiInspectionVisitor();

            Console.WriteLine("Performing inspections:\n");
            a3.Accept(inspectionVisitor);
            a4.Accept(inspectionVisitor);
            a6.Accept(inspectionVisitor);
        }
    }
}