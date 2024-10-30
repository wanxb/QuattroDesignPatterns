namespace QuattroDesignPatterns.Creational.Prototype
{
    #region Prototype

    /*
        原型模式
        原型模式是一种创建性设计模式，它允许通过复制现有对象来创建新对象。原型模式使得在运行时通过克隆现有对象来创建新对象变得容易。

        使用场景
        当一个类的实例需要通过动态指定其属性或特性来创建新实例时。
        当创建对象的成本较高，使用现有对象的克隆会更有效。

        优点
        通过克隆来创建对象比通过构造函数更简单。
        可以在运行时改变对象的属性和特性。

        缺点
        需要为每个类实现克隆方法，这可能导致类的复杂性增加。
        在某些情况下，克隆对象可能会引入额外的复杂性，如深拷贝和浅拷贝问题。

        扩展说明
        深拷贝和浅拷贝：在使用原型模式时，可能会遇到需要进行深拷贝（复制对象及其引用的对象）或浅拷贝（仅复制对象本身，不复制其引用的对象）的问题。实现深拷贝通常需要额外的逻辑来确保所有相关对象都被正确复制。
        性能优化：原型模式可以显著减少创建对象时的开销，尤其是在对象的创建过程非常复杂或耗费资源的情况下。通过复制现有对象，我们可以快速生成新对象，而无需从头开始创建。
        避免构造函数的复杂性：在某些情况下，构造函数可能需要许多参数，使用原型模式可以避免创建复杂的构造函数。用户只需复制现有对象并根据需要修改属性。

        奥迪汽车例子
        我们可以通过原型模式来创建不同配置的奥迪汽车。通过克隆现有的奥迪汽车对象，我们可以快速创建新的汽车对象，而无需重复配置所有细节。
    */
    /*
        Prototype Pattern
        The Prototype Pattern is a creational design pattern that allows for creating new objects by copying existing ones. This pattern makes it easy to create new objects at runtime by cloning existing instances.

        Usage scenarios
        When instances of a class need to be created with dynamic properties or features.
        When the cost of creating an object is high, and using a clone of an existing object is more efficient.

        Advantages
        Cloning makes object creation simpler compared to using constructors.
        Allows changing object properties and features at runtime.

        Disadvantages
        Requires implementing a clone method for each class, which can increase complexity.
        Cloning objects may introduce additional complexity, such as deep copy and shallow copy issues.

        Additional Notes
        Deep Copy vs Shallow Copy:
        When using the Prototype Pattern, you may encounter the need for deep copy (copying the object and its referenced objects) or shallow copy (copying only the object itself, not its referenced objects). Implementing deep copies often requires additional logic to ensure all related objects are correctly copied.
        Performance Optimization:
        The Prototype Pattern can significantly reduce the overhead of creating objects, especially when the creation process is complex or resource-intensive. By copying existing objects, we can quickly generate new instances without starting from scratch.
        Avoiding Complex Constructors:
        In some cases, constructors may require many parameters. The Prototype Pattern can help avoid creating complex constructors. Users only need to copy existing objects and modify properties as needed.

        Audi Example
        We can use the Prototype Pattern to create different configurations of Audi cars. By cloning existing Audi car objects, we can quickly create new car objects without reconfiguring all the details.
     */

    #endregion Prototype

    public class PrototypeDemo
    {
        public static void RunDemo()
        {
            Console.WriteLine("Welcome to the Audi Car Prototype Demo!");

            // Create a prototype
            var originalAudi = new AudiCarPrototype("A6", "Black", "Leather");
            Console.WriteLine("Original Audi Car:");
            originalAudi.ShowDetails();

            // Clone the original Audi car
            var clonedAudi = (AudiCarPrototype)originalAudi.Clone();
            Console.WriteLine("Cloned Audi Car:");
            clonedAudi.ShowDetails();

            // Change the properties of the cloned car
            clonedAudi.Color = "Red";
            Console.WriteLine("Modified Cloned Audi Car:");
            clonedAudi.ShowDetails();
        }
    }
}