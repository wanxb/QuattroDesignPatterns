namespace QuattroDesignPatterns.Structural.Facade
{
    #region Facade

    /*
        外观模式
        外观模式是一种结构型设计模式，它通过为复杂的子系统提供一个统一的接口，简化了客户端的使用。外观模式隐藏了子系统的复杂性，让客户端能够更容易地与子系统进行交互，而不需要直接依赖子系统的细节。

        使用场景
        当你想要为一个复杂的子系统提供一个简化的接口。
        当你需要将子系统的多个功能进行组合并统一对外提供服务。
        当你想要减少客户端与子系统之间的耦合，避免暴露子系统的实现细节。

        优点
        提供了简化的接口，降低了使用复杂子系统的难度。
        使子系统与客户端之间的耦合降低，子系统的实现可以随时改变而不会影响到客户端。
        更容易维护代码，因为客户端只需要了解外观接口。

        缺点
        可能会导致某些功能的灵活性下降，因为它统一了接口，隐藏了部分子系统的细节。
        如果设计不当，可能会过度简化子系统的接口，导致功能不够灵活。

        扩展说明
        外观模式常用于简化第三方库、框架或复杂系统的调用。例如，许多应用程序使用外观模式来简化对数据库的访问操作，或者封装多个API调用为单个接口。

        奥迪汽车例子
        在奥迪的多媒体系统中，MMI（多媒体交互系统）可以看作一个外观模式。它为用户提供一个简单的界面，用户可以通过它控制音响、导航、蓝牙电话等多个复杂的子系统，而不需要直接与每个子系统交互。
     */
    /*
        Facade Pattern
        The Facade Pattern is a structural design pattern that provides a simplified interface to a complex subsystem. By using a facade, clients can interact with the system more easily without needing to deal with the complexities of its internal workings.

        Usage scenarios
        When you want to provide a simplified interface to a complex subsystem.
        When you need to combine multiple functionalities from various subsystems into one unified service.
        When you want to reduce the dependency between clients and subsystems, hiding the details of the system's implementation from the client.

        Advantages
        It simplifies the interface, making it easier to use complex systems.
        Reduces coupling between the client and the subsystem, allowing the subsystem to change without affecting the client.
        Easier to maintain, as the client only interacts with the facade interface.

        Disadvantages
        It may reduce flexibility by hiding the subsystem's detailed functionalities.
        If not carefully designed, it can oversimplify the interface, limiting the functionality that the client can use.

        Additional Notes
        The Facade Pattern is commonly used to simplify interactions with third-party libraries, frameworks, or complex systems. For instance, it can be used to provide a single interface to multiple database operations or wrap several API calls into a single, cohesive interface.

        Audi Example
        In Audi's multimedia system, MMI (Multi Media Interface) can be viewed as a facade. It offers users a simple interface to control the car's audio, navigation, Bluetooth phone, and other complex subsystems without needing to interact with each subsystem directly.
     */

    #endregion Facade

    public class FacadeDemo
    {
        public static void RunDemo()
        {
            Console.WriteLine("Welcome to the Audi MMI (Multi Media Interface) System!");

            Console.Write("Please enter your destination: ");
            string destination = Console.ReadLine() ?? "Home";

            Console.Write("Please enter your phone name to connect via Bluetooth: ");
            string phoneName = Console.ReadLine() ?? "MyPhone";

            // Using the Facade to simplify the process
            AudiMMIFacade audiMMI = new AudiMMIFacade();
            audiMMI.StartJourney(destination, phoneName);
        }
    }
}