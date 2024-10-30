namespace QuattroDesignPatterns.Behavioral.State
{
    #region State

    /*
        状态模式
        状态模式是一种行为型设计模式，它允许对象在内部状态改变时改变其行为。换句话说，一个对象的行为会基于它的状态发生改变，而调用者无需知道状态变化的具体实现细节。

        使用场景
        当一个对象的行为依赖于它的状态，并且它需要根据状态改变行为时。
        当一个操作中存在大量与状态相关的条件判断语句时。
        需要避免繁琐的条件判断逻辑，或者对象有多个状态且会频繁转换时。

        优点
        将状态的相关行为局部化，并将不同状态的行为分割到不同的类中，遵循单一职责原则。
        通过将状态封装为类，可以更容易地增加新状态，而不影响现有代码。

        缺点
        可能导致类的数量增加，因为每种状态都需要创建一个类。
        如果状态的转换过于复杂，可能会增加系统的复杂度。

        扩展说明
        状态模式与策略模式的区别在于，状态模式是通过对象状态来决定行为，而策略模式是通过策略的选择来决定行为。状态模式强调的是状态之间的转换和对象行为的动态变化，而策略模式更侧重于不同算法的选择。

        奥迪汽车例子
        奥迪汽车的引擎状态可以是状态模式的一个很好的例子。例如，汽车可能有启动状态、怠速状态和行驶状态。每个状态下，汽车的行为（如油门响应、燃油消耗）都不同。当汽车从启动变为怠速、或从怠速变为行驶时，汽车的行为会根据状态自动改变。
     */
    /*
        State Pattern
        The State Pattern is a behavioral design pattern that allows an object to change its behavior when its internal state changes. In other words, an object behaves differently depending on its state, without requiring the client to know the details of the state changes.

        Usage scenarios
        When an object’s behavior depends on its state, and it must change behavior according to state changes.
        When there are many conditional or switch statements that depend on an object’s state.
        When you want to avoid complex conditional logic and have frequent state transitions within an object.

        Advantages:
        It localizes state-specific behavior and partitions different behaviors into separate classes, following the single responsibility principle.
        It allows the addition of new states easily without affecting existing code.

        Disadvantages
        It may result in an increased number of classes, as each state requires a separate class.
        If state transitions are too complex, it can increase system complexity.

        Additional Notes
        The State Pattern differs from the Strategy Pattern in that it focuses on behavior determined by state, whereas the Strategy Pattern focuses on behavior determined by algorithm selection. The State Pattern emphasizes transitions between states and dynamic changes in object behavior, while the Strategy Pattern emphasizes algorithm flexibility.

        Audi Example
        The engine states of an Audi car can serve as a great example of the State Pattern. For instance, the car might have states like "Starting," "Idle," and "Driving." In each state, the car behaves differently in terms of throttle response, fuel consumption, and other factors. As the car transitions from one state to another (e.g., from Idle to Driving), its behavior changes accordingly.
     */

    #endregion State

    public class StateDemo
    {
        public static void RunDemo()
        {
            Console.WriteLine("Welcome to the Audi Engine State Manager!");

            AudiCar audiCar = new AudiCar(new StartingState());

            string command = "";
            while (command != "exit")
            {
                Console.Write("\nEnter 'next' to move to the next engine state, or 'exit' to quit:");
                command = Console.ReadLine()?.ToLower();

                if (command == "next")
                {
                    audiCar.HandleState();
                }
            }

            Console.WriteLine("Thank you for using the Audi Engine State Manager!");
        }
    }
}