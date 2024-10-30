namespace QuattroDesignPatterns.Structural.Proxy
{
    #region Proxy

    /*
        代理模式
        代理模式是一种结构型设计模式，主要用于在不改变对象接口的前提下，通过代理对象来控制对目标对象的访问。代理对象可以在访问目标对象时添加额外的功能或控制，例如延迟加载、权限控制、日志记录等。

        使用场景
        需要控制对对象的访问（如权限控制、资源控制）。
        需要在对象访问前后进行一些操作（如延迟初始化、远程代理、虚拟代理等）。

        优点
        代理模式能够在不修改目标对象的情况下，提供额外的功能。
        可以控制访问目标对象的权限或行为。
        在需要的时候才会创建目标对象，提升性能（如虚拟代理）。

        缺点
        由于引入了代理类，可能会增加系统的复杂性。
        如果过度使用代理模式，可能导致系统难以维护和调试。

        扩展说明
        代理模式有多种形式，例如
        远程代理：为远程对象提供本地代表，便于客户端处理远程方法调用。
        虚拟代理：用于控制访问开销较大的资源，在资源真正需要使用时再创建（如图片加载）。
        保护代理：控制访问权限，确保客户端只有在满足条件时才可访问对象。

        奥迪汽车例子
        在奥迪的售后服务系统中，我们可以使用代理模式为汽车诊断提供代理类。在实际连接到汽车并执行耗时的诊断操作之前，代理对象可以检查车辆的状态、权限，或在执行诊断前进行一些必要的准备工作。
 */
    /*
        Proxy Pattern
        The Proxy Pattern is a structural design pattern that provides a substitute or placeholder for another object. A proxy controls access to the real object, allowing additional functionality to be added without changing the object's interface. It can be used for tasks like lazy initialization, access control, logging, and more.

        Usage scenarios
        When access to an object needs to be controlled (e.g., permission control, resource access).
        When you need to perform operations before or after accessing an object (e.g., lazy initialization, remote proxies, virtual proxies).

        Advantages
        The Proxy Pattern allows additional functionality to be added to an object without modifying the object itself.
        It can control access to the real object, such as through permission or access control.
        Enhances performance by delaying the creation of heavy objects (virtual proxy).

        Disadvantages
        Introducing proxy classes may increase the complexity of the system.
        Overusing the Proxy Pattern may make the system difficult to maintain and debug.

        Additional Notes
        There are various types of proxies, such as:
        Remote Proxy: A local representative of an object located in a different address space, used for remote method invocation.
        Virtual Proxy: Controls access to a resource that is expensive to create until it is needed (e.g., lazy-loading images).
        Protection Proxy: Controls access rights to an object, ensuring clients only access objects when they meet certain conditions.

        Audi Example
        In Audi's after-sales service system, we can use the Proxy Pattern to provide a proxy class for vehicle diagnostics. Before actually connecting to the car and performing time-consuming diagnostics, the proxy object can check the vehicle's state, permissions, or perform necessary preparations.
     */

    #endregion Proxy

    public class ProxyDemo
    {
        public static void RunDemo()
        {
            Console.WriteLine("Welcome to the Audi Car Diagnostics Proxy Demo!");

            Console.Write("Please enter the Audi model for diagnostics (A3, A4, A6): ");
            string model = Console.ReadLine()?.ToLower() ?? "A6";

            ICarDiagnostics diagnosticsProxy = new CarDiagnosticsProxy(model);

            diagnosticsProxy.RunDiagnostics();
        }
    }
}