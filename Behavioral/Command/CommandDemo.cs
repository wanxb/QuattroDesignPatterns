namespace QuattroDesignPatterns.Behavioral.Command
{
    #region Command

    /*
        命令模式
        命令模式是一种行为型设计模式，它将请求封装为对象，从而使您能够使用不同的请求、排队请求或记录请求。它还支持可撤销的操作。

        使用场景
        当您需要将请求封装为对象时，以便将请求参数化并将请求对象传递给其他方法。
        当您需要支持撤销和重做操作时。
        当您需要将请求排队或记录请求日志时。

        优点
        将请求的发起者与请求的处理者解耦，允许您使用不同的请求参数化方法。
        支持可撤销的操作。
        可以容易地扩展新命令而不影响现有代码。

        缺点
        可能会导致命令对象数量增加，从而使系统变得复杂。

        扩展说明
        命令模式与责任链模式的主要区别在于，命令模式将请求封装为对象并明确指定处理者，而责任链模式则允许多个处理者对请求进行处理，直到有一个处理者接受该请求。

        奥迪汽车例子
        想象一个奥迪汽车远程控制系统，您可以通过遥控器发送不同的命令来启动汽车、停止汽车或锁定门。这些命令被封装成命令对象，并通过相应的接收者（如汽车的控制系统）来执行。
     */
    /*
        Command Pattern
        The Command Pattern is a behavioral design pattern that encapsulates a request as an object, allowing for parameterization of clients with queues, logging of requests, and support for undoable operations.

        Usage scenarios
        When you need to encapsulate a request as an object to parameterize methods with different requests.
        When you need to support undo and redo operations.
        When you need to queue requests or log request history.

        Advantages
        Decouples the sender and receiver of the request, allowing methods to be parameterized with different requests.
        Supports undoable operations.
        Easy to extend new commands without impacting existing code.

        Disadvantages
        May result in an increased number of command objects, leading to system complexity.

        Additional Notes
        The Command Pattern differs from the Chain of Responsibility Pattern in that it encapsulates the request as an object and specifies the invoker for that request, while the Chain of Responsibility Pattern allows multiple handlers to process the request until one accepts it.

        Audi Example
        Consider an Audi remote control system where you can send different commands to start the car, stop the car, or lock the doors. These commands are encapsulated as command objects and executed by the appropriate receiver (the car's control system).
     */

    #endregion Command

    public class CommandDemo
    {
        public static void RunDemo()
        {
            Console.WriteLine("Welcome to the Audi Remote Control System!");

            // Create the Audi car instance
            var audiCar = new AudiCar();

            // Create command instances
            var startCommand = new StartCarCommand(audiCar);
            var stopCommand = new StopCarCommand(audiCar);

            // Create the remote control instance
            var remoteControl = new RemoteControl();

            // Simulate user input
            Console.Write("Please enter a command (Start/Stop):");
            string input = Console.ReadLine();

            if (input.Equals("Start", StringComparison.OrdinalIgnoreCase))
            {
                remoteControl.SetCommand(startCommand);
                remoteControl.PressButton();
            }
            else if (input.Equals("Stop", StringComparison.OrdinalIgnoreCase))
            {
                remoteControl.SetCommand(stopCommand);
                remoteControl.PressButton();
            }
            else
            {
                Console.WriteLine("Invalid command.");
            }

            // Optional: simulate undo
            Console.WriteLine("Pressing undo...");
            remoteControl.PressUndo();
        }
    }
}