namespace QuattroDesignPatterns.Behavioral.Strategy
{
    #region Strategy

    /*
        策略模式
        策略模式是一种行为型设计模式，它定义了一系列算法，并将它们封装在不同的策略类中，使得算法可以相互替换。策略模式使得算法的变化不会影响使用算法的客户类，从而让这些算法可以独立于客户类进行变化。

        使用场景
        当一个类需要执行某个行为，但是该行为有多种不同的实现方案时。
        当你有许多相似的类，且每个类的行为只有少量不同的时候。
        当需要动态地改变对象的行为时。

        优点
        提供了开放/封闭原则的良好实现，增加新的策略不需要修改原有的上下文类。
        避免了使用大量条件语句来选择算法。
        策略可以复用，便于维护。

        缺点
        如果策略过多，会导致策略类的增加，管理起来比较复杂。
        上下文对象必须了解所有策略的行为，从而引入了一定的耦合性。

        扩展说明
        策略模式允许在运行时切换算法，而不必修改客户代码。它与状态模式（State Pattern）有一些相似之处，状态模式是在不同状态之间切换，而策略模式则是在不同算法之间切换。

        奥迪汽车例子
        可以将奥迪汽车的驾驶模式（如经济模式、运动模式、舒适模式）视为策略模式的一个例子。不同的驾驶模式实现了不同的算法，而这些模式之间的切换不会影响汽车的基本驾驶功能。
     */
    /*
        Strategy Pattern
        The Strategy Pattern is a behavioral design pattern that defines a family of algorithms, encapsulates each one, and makes them interchangeable. This pattern allows the algorithm to vary independently from the clients that use it, providing flexibility in choosing the appropriate algorithm at runtime.

        Usage scenarios
        When a class needs to perform a certain behavior but there are multiple possible implementations of this behavior.
        When you have many similar classes, with only slight differences in their behavior.
        When you want to dynamically change an object’s behavior at runtime.

        Advantages
        Adheres to the open-closed principle, allowing new strategies to be added without modifying the existing context class.
        Avoids large switch or if-else statements for algorithm selection.
        Strategies are reusable and easier to maintain.

        Disadvantages
        If too many strategies are defined, the number of classes can increase, leading to complexity in management.
        The context class must be aware of all strategy behaviors, introducing some coupling.

        Additional Notes
        The Strategy Pattern allows algorithms to be swapped at runtime without changing the client code. It is somewhat similar to the State Pattern, where the system switches between different states. In contrast, the Strategy Pattern switches between different algorithms.

        Audi Example
        In an Audi car, the driving modes (e.g., Eco Mode, Sport Mode, Comfort Mode) can be thought of as an example of the Strategy Pattern. Each driving mode implements different algorithms, and switching between these modes does not affect the core driving functionality of the car.
     */

    #endregion Strategy

    public class StrategyDemo
    {
        public static void RunDemo()
        {
            Console.WriteLine("Welcome to the Audi Driving Mode Selector!");

            AudiCar audiCar = new AudiCar(new ComfortMode());

            Console.Write("Select driving mode (Eco, Sport, Comfort): ");
            string mode = Console.ReadLine()?.ToLower();

            switch (mode)
            {
                case "eco":
                    audiCar.SetDrivingMode(new EcoMode());
                    break;

                case "sport":
                    audiCar.SetDrivingMode(new SportMode());
                    break;

                case "comfort":
                default:
                    audiCar.SetDrivingMode(new ComfortMode());
                    break;
            }

            Console.WriteLine("Your Audi is now in the selected driving mode:");
            audiCar.Drive();
        }
    }
}