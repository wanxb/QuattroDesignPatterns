namespace QuattroDesignPatterns.Behavioral.Observer
{
    #region Observer

    /*
        观察者模式
        观察者模式是一种行为型设计模式，定义了一种一对多的依赖关系，使得当一个对象的状态发生变化时，所有依赖于它的对象都会收到通知并自动更新。该模式通常用于事件驱动的系统和用户界面中的数据绑定。

        使用场景
        当一个对象的状态变化需要影响其他对象，但又不希望这些对象之间有太强的耦合时。
        当一个对象（主题）被多个对象（观察者）观察时，例如在用户界面中，当模型数据更新时自动更新视图。
        当需要在多个组件之间实现分离关注时，保持各个组件的独立性。

        优点
        观察者模式支持松耦合的设计，主题与观察者之间没有直接依赖关系。
        可以轻松增加或移除观察者，而不需要修改主题的代码。
        适用于实现广播通信。

        缺点
        如果观察者数量众多，可能会导致系统的复杂性增加。
        当主题的状态发生变化时，通知所有观察者可能会导致性能问题，尤其是当观察者处理的逻辑较重时。

        扩展说明
        观察者模式广泛应用于图形用户界面（GUI）框架、事件处理系统和实时数据流系统。它是实现发布-订阅模式的一种常见方式，允许多个对象订阅某个主题并在主题状态变化时自动更新。

        奥迪汽车例子
        想象一下，奥迪汽车中的导航系统与车辆状态（如速度、油量）之间的关系。当车辆状态发生变化时，导航系统可以自动调整路线或重新计算行程。
     */
    /*
        Observer Pattern
        The Observer Pattern is a behavioral design pattern that defines a one-to-many dependency between objects so that when one object's state changes, all its dependents are notified and updated automatically. This pattern is typically used in event-driven systems and data binding in user interfaces.

        Usage scenarios
        When a change in the state of one object needs to affect other objects, but you do not want these objects to be tightly coupled.
        When one object (the subject) is being observed by multiple objects (observers), such as automatically updating a view when model data changes in a user interface.
        When you want to achieve separation of concerns among multiple components, maintaining their independence.

        Advantages
        The observer pattern supports loose coupling, as there is no direct dependency between the subject and the observers.
        Observers can be added or removed easily without modifying the subject's code.
        It is suitable for implementing broadcast communication.

        Disadvantages
        The complexity of the system may increase if there are many observers.
        Notifying all observers when the subject's state changes can lead to performance issues, especially if the logic handled by observers is heavy.

        Additional Notes
        The Observer Pattern is widely used in graphical user interface (GUI) frameworks, event handling systems, and real-time data streaming systems. It is a common way to implement the publish-subscribe pattern, allowing multiple objects to subscribe to a subject and be updated automatically when the subject's state changes.

        Audi Example
        Consider the relationship between the navigation system and the vehicle's status (such as speed and fuel level) in an Audi car. When the vehicle's status changes, the navigation system can automatically adjust the route or recalculate the trip.
     */

    #endregion Observer

    public class ObserverDemo
    {
        public static void RunDemo()
        {
            Audi audi = new Audi();
            Driver driver1 = new Driver("John");
            Driver driver2 = new Driver("Alice");

            audi.Attach(driver1);
            audi.Attach(driver2);

            audi.ChangeStatus("Engine Started");
            audi.ChangeStatus("Speed: 60 km/h");
        }
    }
}