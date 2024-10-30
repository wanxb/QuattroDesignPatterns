namespace QuattroDesignPatterns.Creational.Factory
{
    #region Factory

    /*
        工厂模式
        工厂模式是一种创建型设计模式，它提供了一个接口用于在超类中创建对象，但允许子类改变所要创建的对象类型。它有助于封装实例化逻辑，促进客户端与被实例化类之间的松耦合。

        使用场景
        当一个类无法预见需要创建的对象类型时。
        当一个类希望其子类指定要创建的对象时。
        当你想要管理和封装复杂对象的创建过程时。
        常用于涉及框架或库的场景，其中具体的实现是在运行时提供的。
        示例： 在汽车应用中，工厂可以用于根据用户输入创建各种汽车模型。

        优点
        通过减少客户端代码对具体类的依赖，促进了松耦合。
        通过封装对象创建过程，提高了代码的可维护性和灵活性。
        支持开闭原则，允许在不修改现有代码的情况下引入新类。

        缺点
        可能通过增加额外的类来引入代码复杂性。
        如果用于简单场景，可能导致过度设计。

        扩展说明
        工厂模式可以通过抽象工厂模式进一步增强，后者提供了一个接口，用于在不指定具体类的情况下创建相关或依赖对象的系列。

        奥迪汽车例子
        在奥迪汽车的上下文中，工厂模式可以用于根据用户的规格创建不同型号的奥迪汽车。例如，用户可以选择奥迪车型（A3、A4、A6）并指定配置（运动型、豪华型、基础型）。工厂然后根据这些信息生成相应的奥迪汽车对象。
    */
    /*
        Factory Pattern
        The Factory Pattern is a creational design pattern that provides an interface for creating objects in a superclass, but allows subclasses to alter the type of objects that will be created. It helps in encapsulating the instantiation logic, promoting loose coupling between the client and the classes being instantiated.

        Usage scenarios
        When a class cannot anticipate the type of objects it needs to create.
        When a class wants its subclasses to specify the objects it creates.
        When you want to manage and encapsulate the creation of complex objects.
        Commonly used in scenarios involving frameworks or libraries, where the specific implementations are provided at runtime.
        Example: In automotive applications, a factory can be used to create various car models based on user input.

        Advantages
        Promotes loose coupling by reducing the dependency of the client code on concrete classes.
        Enhances code maintainability and flexibility by encapsulating object creation.
        Supports the Open/Closed Principle, allowing new classes to be introduced without modifying existing code.

        Disadvantages
        Can introduce complexity to the codebase by adding additional classes.
        May lead to over-engineering if used for simple scenarios.

        Additional Notes
        The Factory Pattern can be further enhanced using the Abstract Factory Pattern, which provides an interface for creating families of related or dependent objects without specifying their concrete classes.

        Audi Example
        In the context of Audi cars, the Factory Pattern can be used to create different models of Audi vehicles based on user specifications. For instance, users can choose an Audi model (A3, A4, A6) and specify a configuration (Sport, Luxury, Base). The factory then produces the appropriate Audi car object based on this information.
     */

    #endregion Factory

    public class FactoryDemo
    {
        public static void RunDemo()
        {
            Console.WriteLine("Welcome to the Audi Car Configuration Factory!");

            Console.Write("Please enter the Audi model you want (A3, A4, A6):");
            string model = Console.ReadLine()?.ToLower() ?? "A6";

            Console.Write("Please enter your desired configuration (Sport, Luxury, Base):");
            string configuration = Console.ReadLine()?.ToLower() ?? "Sport";

            // Create the Audi car instance
            ICar audiCar = AudiFactory.CreateCar(model, configuration);

            Console.WriteLine($"You have successfully selected the model: {audiCar.GetModel()}, enjoy your drive!");

            audiCar.Drive();
        }
    }
}