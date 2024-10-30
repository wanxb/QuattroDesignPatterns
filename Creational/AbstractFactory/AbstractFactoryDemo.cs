using QuattroDesignPatterns.Creational.AbstractFactory.Luxury;
using QuattroDesignPatterns.Creational.AbstractFactory.Sport;

namespace QuattroDesignPatterns.Creational.AbstractFactory
{
    #region Abstract Factory

    /*
        抽象工厂模式
        抽象工厂模式是一种创建型设计模式，它提供一个创建一系列相关或相互依赖对象的接口，而无需指定它们的具体类。抽象工厂用于创建多个类的对象，它将工厂方法延伸为一系列工厂接口，以便创建不同类型的对象族。

        使用场景
        当系统需要独立于具体产品的创建和使用时。
        当需要创建一系列相关的对象时，并且不希望让客户端知道具体的类。

        优点
        隐藏了具体类的实现，降低了耦合度。
        有利于产品族的扩展，支持不同类型的产品切换。

        缺点
        扩展新的产品族需要修改抽象工厂类，违背了开闭原则。
        难以支持新产品的增加。

        扩展说明
        抽象工厂模式常与工厂方法模式结合使用，工厂方法负责创建单个产品，而抽象工厂负责创建多个相关的产品，常用于构建可扩展的产品家族。

        奥迪汽车例子
        假设我们有不同的奥迪汽车制造厂，每个工厂会创建一系列不同的汽车配件（如发动机和轮胎）。通过抽象工厂模式，我们可以根据不同的工厂选择不同的配件组合，而无需知道这些配件的具体类。
     */
    /*
        Abstract Factory Pattern
        The Abstract Factory Pattern is a creational design pattern that provides an interface for creating families of related or dependent objects without specifying their concrete classes. It is used when you need to create multiple types of objects, and it extends the Factory Method by introducing a series of factory interfaces for producing related objects.

        Usage scenarios
        When the system needs to be independent of how its objects are created and composed.
        When a family of related products is to be used together, and there is a need to ensure this constraint.

        Advantages
        Hides the implementation details of concrete classes, reducing coupling.
        Promotes product family consistency and supports switching between different sets of products.

        Disadvantages
        Adding a new product family requires modification of the Abstract Factory, violating the Open-Closed Principle.
        It can be challenging to support the addition of new products.

        Additional Notes
        The Abstract Factory Pattern is often used in conjunction with the Factory Method Pattern. The Factory Method is responsible for creating individual products, while the Abstract Factory creates related product families.

        Audi Example
        Imagine we have different Audi manufacturing plants, each responsible for creating specific car components such as engines and tires. Using the Abstract Factory Pattern, we can choose different combinations of components depending on the factory, without needing to know the exact classes of those components.
     */

    #endregion Abstract Factory

    public class AbstractFactoryDemo
    {
        public static void RunDemo()
        {
            Console.WriteLine("Welcome to the Audi Car Abstract Factory!");

            Console.Write("Please choose your Audi A8 type (Sport, Luxury):");
            string carType = Console.ReadLine()?.ToLower() ?? "sport";

            ICarFactory carFactory = GetCarFactory(carType);
            if (carFactory != null)
            {
                DisplayCarDetails(carType, carFactory);
            }
            else
            {
                Console.WriteLine("Invalid choice. Please select either 'Sport' or 'Luxury'.");
            }
        }

        private static ICarFactory? GetCarFactory(string carType)
        {
            return carType.Equals("sport", StringComparison.CurrentCultureIgnoreCase)
                ? new SportCarFactory()
                : carType.Equals("luxury", StringComparison.CurrentCultureIgnoreCase)
                ? new LuxuryCarFactory()
                : null;
        }

        private static void DisplayCarDetails(string carType, ICarFactory carFactory)
        {
            var engine = carFactory.CreateEngine();
            var tire = carFactory.CreateTire();

            Console.WriteLine($"You have selected a {carType} Audi A8 with the following components:");
            Console.WriteLine(engine.GetSpecifications());
            Console.WriteLine(tire.GetTireType());
        }
    }
}