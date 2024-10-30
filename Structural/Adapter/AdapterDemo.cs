using QuattroDesignPatterns.Structural.Adapter.AndroidAuto;
using QuattroDesignPatterns.Structural.Adapter.CarPlay;

namespace QuattroDesignPatterns.Structural.Adapter
{
    public class AdapterDemo
    {
        #region Adapter

        /*
            适配器模式
            适配器模式是一种结构型设计模式，它使不兼容的接口能够一起工作。通过创建一个适配器类，转换一个类的接口为客户期望的另一个接口，从而使原本由于接口不兼容而无法一起工作的类可以协同作业。它通常用于系统的老旧组件与新组件的集成。

            使用场景
            已有类的接口不符合新系统的需求：当我们有一个现有类，但它的接口与目标系统不兼容时，可以使用适配器将其转换成符合新系统需求的接口。
            复用现有类：当我们想要复用一些现有类的功能，但它们的接口不一致时，可以通过适配器进行转换。
            第三方库集成：适配器模式经常用于集成第三方库或服务，将其接口转换为我们熟悉和期望的接口形式。

            优点
            增强代码的复用性：通过使用适配器模式，现有类可以不做修改就能与新代码兼容。
            提高系统的灵活性和可扩展性：可以在不修改现有代码的基础上扩展系统功能。
            解耦代码：使用适配器可以避免系统各组件之间的强耦合。

            缺点
            增加复杂度：引入适配器会增加额外的类，使系统的复杂性有所增加。
            性能开销：适配器模式会引入额外的转发操作，可能带来一定的性能开销。

            扩展说明
            适配器模式有两种常见的实现方式
            对象适配器：通过组合的方式适配接口，适配器类持有被适配的对象实例并对其请求进行转发。
            类适配器：通过继承实现适配，适配器类同时继承自目标接口和需要适配的类。这种方式在C#中较少使用，因为C#不支持多重继承。

            实际应用
            适配器模式广泛应用于各种框架和中间件中，尤其是在需要兼容不同版本的API、集成第三方库、以及进行遗留系统的改造时。例如，在.NET开发中，可以使用适配器模式将旧版本的接口与新版本的接口兼容，或通过适配器类来整合多个来源的数据格式。

            奥迪汽车例子
            奥迪的车载系统（如MMI多媒体交互系统）与外部设备（如智能手机或平板）通过适配器模式进行兼容。MMI系统和外部设备可能支持不同的通信协议或数据格式，但通过适配器（如CarPlay或Android Auto），MMI可以将外部设备的信息转换为系统可理解的格式，并进行显示和操作。
        */
        /*
            Adapter Pattern
            The Adapter Pattern is a structural design pattern that allows incompatible interfaces to work together. By creating an adapter class, you can convert the interface of one class into another interface that the client expects, allowing classes with incompatible interfaces to collaborate. This pattern is particularly useful when integrating old components into new systems.

            Usage scenarios
            Existing class interface does not meet new system requirements: When you have an existing class whose interface is incompatible with the target system, you can use an adapter to convert it to meet the new system's requirements.
            Reuse of existing classes: When you want to reuse the functionality of existing classes but their interfaces are inconsistent, an adapter can be used for conversion.
            Third-party library integration: Adapter pattern is often used to integrate third-party libraries or services by converting their interfaces into a familiar and expected format.

            Advantages
            Enhances code reusability: Existing classes can be reused without modification by using the adapter pattern.
            Increases system flexibility and scalability: The system can be extended without modifying existing code.
            Decouples code: Adapters reduce the tight coupling between system components.

            Disadvantages
            Increased complexity: The introduction of an adapter adds extra classes, which may increase system complexity.
            Performance overhead: Adapter pattern introduces additional forwarding operations, which may cause a slight performance hit.

            Additional Notes
            The Adapter pattern has two common implementations
            Object Adapter: Uses composition to adapt interfaces, where the adapter class holds an instance of the class being adapted and forwards requests.
            Class Adapter: Uses inheritance to adapt interfaces, where the adapter class inherits from both the target interface and the class to be adapted. This approach is less common in C# due to its lack of multiple inheritance support.

            Real-world Application
            The Adapter pattern is widely used in frameworks and middleware, especially when needing to support different versions of APIs, integrate third-party libraries, or refactor legacy systems. In .NET, for example, you might use adapters to make older interfaces compatible with newer versions or to unify data formats from multiple sources.

            Audi Example
            In Audi vehicles, the MMI (Multi Media Interface) system interacts with external devices like smartphones or tablets using the Adapter Pattern. The MMI system and external devices might support different communication protocols or data formats, but through an adapter (e.g., CarPlay or Android Auto), MMI can translate the device’s information into a format that the system can understand and display.
         */

        #endregion Adapter

        public static void RunDemo()
        {
            Console.WriteLine("Welcome to the Audi Multimedia System!");

            Console.Write("Please select the connection type: (CarPlay / Android Auto):");
            string choice = Console.ReadLine()?.ToLower() ?? "CarPlay";

            IAudioSource adapter;

            if (choice.Equals("carplay", StringComparison.CurrentCultureIgnoreCase))
            {
                var carPlayDevice = new CarPlayDevice();
                adapter = new CarPlayAudioAdapter(carPlayDevice);
                AudiMultimediaSystem audiMultimediaSystem = new AudiMultimediaSystem(adapter);
                audiMultimediaSystem.PlayMusic();
            }
            else if (choice.Equals("android auto", StringComparison.CurrentCultureIgnoreCase))
            {
                var androidAutoDevice = new AndroidAutoDevice();
                adapter = new AndroidAutoAudioAdapter(androidAutoDevice);
                AudiMultimediaSystem audiMultimediaSystem = new AudiMultimediaSystem(adapter);
                audiMultimediaSystem.PlayMusic();
            }
            else
            {
                Console.WriteLine("Invalid choice. Please select either 'CarPlay' or 'Android Auto'.");
            }
        }
    }
}