namespace QuattroDesignPatterns.Structural.Decorator
{
    #region Decorator

    /*
        装饰器模式
        装饰器模式是一种结构型设计模式，它允许在不修改原有类的情况下，动态地为对象添加功能。这通过将对象放入一个装饰器对象中来实现，装饰器对象增强了原对象的功能，但保持了与原类相同的接口。

        使用场景
        当需要为对象添加额外功能，但是不想通过继承来实现。
        当需要动态地组合不同的行为或功能，并且希望在运行时进行这些组合。
        当你希望能够在不影响其他对象的情况下，改变某个对象的行为。

        优点
        动态增加功能，无需修改原有类，符合开闭原则。
        可以在运行时以不同的顺序或组合添加多个装饰器。
        比继承更加灵活，避免了类的爆炸性增长。

        缺点
        如果装饰器过多，可能导致代码变得复杂且难以调试。
        装饰器模式容易导致对象的层级嵌套过深，增加理解难度。

        扩展说明
        装饰器模式与代理模式（Proxy）和适配器模式（Adapter）有一定相似性，但装饰器主要用于增强对象的功能，而不是改变接口或者控制访问。

        奥迪汽车例子
        在奥迪汽车中，可以把车辆的升级选项看作是一个装饰器模式。例如，基础版的奥迪A4可以通过添加升级选项（如运动座椅、豪华内饰、先进的驾驶辅助系统）来增强功能，而不需要更改A4的基本结构。
     */
    /*
        Decorator Pattern
        The Decorator Pattern is a structural design pattern that allows behavior to be added to individual objects, dynamically, without modifying the class itself. This is achieved by wrapping the object with a decorator class that enhances its functionality while maintaining the same interface.

        Usage scenarios
        When you want to add functionality to an object without modifying its class.
        When you need to dynamically combine different behaviors or functionalities, often at runtime.
        When you want to modify the behavior of specific instances of a class without affecting others.

        Advantages
        Dynamically adds functionalities without altering the original class, adhering to the open-closed principle.
        Allows for flexible combination of functionalities in different orders or configurations at runtime.
        More flexible than inheritance, avoiding the complexity of subclass proliferation.

        Disadvantages
        Too many decorators can complicate the code and make it difficult to debug.
        It can lead to deep layers of wrapped objects, which might make understanding the code harder.
        Additional Notes:
        The Decorator Pattern is similar to the Proxy and Adapter patterns, but it's primarily focused on adding behavior, not altering the interface or controlling access.

        Audi Example
        In Audi cars, you can think of vehicle upgrade options as a decorator pattern. For instance, the base model Audi A4 can be enhanced by adding features like sport seats, luxury interiors, or advanced driver-assistance systems, without altering the base structure of the A4.
     */

    #endregion Decorator

    public class DecoratorDemo
    {
        public static void RunDemo()
        {
            Console.WriteLine("Welcome to the Audi Car Customization!");

            ICar audiA4 = new AudiA4();
            Console.WriteLine($"Base model: {audiA4.GetDescription()} - ${audiA4.GetCost()}");

            // Ask user if they want to add Sport Package
            Console.Write("Would you like to add the Sport Package? (yes/no): ");
            string sportPackageInput = Console.ReadLine()?.ToLower();
            if (sportPackageInput == "yes")
            {
                audiA4 = new SportPackage(audiA4);
            }

            // Ask user if they want to add Luxury Package
            Console.Write("Would you like to add the Luxury Package? (yes/no): ");
            string luxuryPackageInput = Console.ReadLine()?.ToLower();
            if (luxuryPackageInput == "yes")
            {
                audiA4 = new LuxuryPackage(audiA4);
            }

            // Final description and cost
            Console.WriteLine($"Your customized Audi: {audiA4.GetDescription()} - ${audiA4.GetCost()}");
        }
    }
}