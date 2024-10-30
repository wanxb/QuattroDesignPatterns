using QuattroDesignPatterns.Structural.Bridge.Engine;
using QuattroDesignPatterns.Structural.Bridge.Transmission;

namespace QuattroDesignPatterns.Structural.Bridge
{
    #region Bridge

    /*
        桥接模式
        桥接模式是一种结构型设计模式，它通过将抽象与实现分离，使它们可以独立变化。该模式使用组合而不是继承来共享功能，允许不同部分可以灵活扩展。桥接模式常用于需要在多个维度上扩展类的场景。

        使用场景
        当你不希望在抽象和实现之间紧耦合时。
        需要扩展多个维度的类时，比如支持多种设备的操作系统。

        优点
        使抽象和实现可以独立变化。
        避免了类的爆炸式增长。

        缺点
        增加了系统的复杂度。

        扩展说明
        桥接模式通常和组合模式、适配器模式等结合使用，在大型系统中，桥接模式能显著减少代码重复。

        奥迪汽车例子
        奥迪汽车提供不同的引擎和变速箱组合，比如电动引擎可以搭配自动变速箱，燃油引擎也可以搭配手动变速箱。通过桥接模式，我们可以将"引擎"和"变速箱"解耦，使它们可以独立扩展。
     */
    /*
        Bridge Pattern
        The Bridge Pattern is a structural design pattern that decouples an abstraction from its implementation, allowing both to evolve independently. Instead of inheritance, it uses composition to share functionality and allows flexibility when extending different parts.

        Usage scenarios
        When you want to decouple an abstraction from its implementation.
        When you need to extend a class in multiple dimensions, such as supporting multiple devices for an operating system.

        Advantages
        Allows abstraction and implementation to evolve independently.
        Avoids the explosion of subclasses.

        Disadvantages
        Increases complexity.

        Additional Notes
        The Bridge Pattern is often used together with other patterns like the Composite and Adapter patterns. In large systems, it can significantly reduce code duplication.

        Audi Example
        Audi offers various engine and transmission combinations. For instance, an electric engine can be paired with an automatic transmission, while a fuel engine can be paired with a manual transmission. With the Bridge Pattern, "engine" and "transmission" can be decoupled and extended independently.
     */

    #endregion Bridge

    public class BridgeDemo
    {
        public static void RunDemo()
        {
            Console.WriteLine("Welcome to the Audi Car Bridge Pattern demo!");

            // Ask user for engine type
            Console.Write("Please choose an engine type (Electric, Fuel):");
            string engineChoice = Console.ReadLine()?.ToLower() ?? "electric";
            IEngine engine = engineChoice == "fuel" ? new FuelEngine() : new ElectricEngine();

            // Ask user for transmission type
            Console.Write("Please choose a transmission type (Automatic, Manual):");
            string transmissionChoice = Console.ReadLine()?.ToLower() ?? "automatic";
            ITransmission transmission = transmissionChoice == "manual" ? new ManualTransmission() : new AutomaticTransmission();

            // Create the Audi car with selected engine and transmission
            AudiCar audiCar = new AudiCar(engine, transmission);
            audiCar.Drive();
        }
    }
}