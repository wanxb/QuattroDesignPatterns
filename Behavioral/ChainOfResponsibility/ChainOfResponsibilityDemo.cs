namespace QuattroDesignPatterns.Behavioral.ChainOfResponsibility
{
    #region ChainOfResponsibility

    /*
        责任链模式
        责任链模式是一种行为型设计模式，它允许多个对象有机会处理请求，从而避免请求的发送者和接收者之间的耦合。这些对象按照责任链的顺序逐个处理请求，直到有对象处理该请求为止。

        使用场景
        需要将多个处理器连接成一个处理链，每个处理器根据条件决定是否处理该请求或将其传递给下一个处理器。
        当请求的处理者不明确，或者需要动态指定处理者时。
        例如，审批流程、日志系统、请求过滤等场景。

        优点
        请求的发送者和接收者之间解耦，客户端不需要知道哪一个处理器最终会处理请求。
        增加或修改处理链中的处理步骤非常灵活。

        缺点
        可能造成处理链过长，影响系统性能。
        如果没有合理的默认处理机制，可能导致请求丢失。

        扩展说明
        责任链模式与命令模式的区别在于，责任链模式中每个处理器都有机会处理请求，而命令模式则是将请求封装成一个对象，并明确谁来处理该请求。责任链模式强调多个处理者之间的责任划分，命令模式则更侧重于请求的封装和参数化。

        奥迪汽车例子
        想象一个奥迪汽车售后服务系统，它可能会接收到用户提出的不同问题，比如引擎问题、轮胎问题或其他问题。系统会把这些问题传递给合适的维修团队来处理，形成一个责任链。如果第一个团队无法处理，问题会被传递给下一个团队，直到找到能处理问题的团队。
     */
    /*
        Chain of Responsibility Pattern
        The Chain of Responsibility Pattern is a behavioral design pattern that allows multiple objects the chance to handle a request, avoiding tight coupling between the sender and receiver. The objects are arranged in a chain, and the request is passed along the chain until an object handles it.

        Usage scenarios
        When you want to connect multiple handlers to process a request, and each handler decides whether to handle the request or pass it along the chain.
        When the handler for a request is not known in advance or needs to be assigned dynamically.
        Common use cases include approval processes, logging systems, and request filtering.

        Advantages
        Decouples the sender and receiver of the request, so the client does not need to know which handler will process the request.
        It's easy to add or modify the chain of responsibility dynamically.

        Disadvantages
        Can result in long chains, which may impact performance.
        Without a proper default handler, the request could be lost if none of the handlers process it.

        Additional Notes
        The Chain of Responsibility Pattern differs from the Command Pattern in that each handler in the chain has the opportunity to process the request, whereas the Command Pattern encapsulates the request and specifies a particular handler for it. The Chain of Responsibility Pattern emphasizes delegating responsibility among multiple handlers, while the Command Pattern focuses on request encapsulation and execution.

        Audi Example
        Consider an Audi customer service system where customers report different issues like engine problems, tire issues, or other maintenance concerns. The system would pass these issues along a chain of repair teams. If the first team cannot resolve the issue, it passes the request to the next team until the right team handles the problem.
     */

    #endregion ChainOfResponsibility

    public class ChainOfResponsibilityDemo
    {
        public static void RunDemo()
        {
            Console.WriteLine("Welcome to the Audi Service Center!");

            // Create the problem handlers
            var engineHandler = new EngineProblemHandler();
            var tireHandler = new TireProblemHandler();
            var generalHandler = new GeneralProblemHandler();

            // Set the chain of responsibility
            engineHandler.SetNext(tireHandler);
            tireHandler.SetNext(generalHandler);

            // Simulate problem input from user
            Console.Write("Please enter the problem (Engine, Tire, General):");
            string problem = Console.ReadLine()?.ToLower() ?? "engine";

            // Start the handling process
            engineHandler.Handle(problem);
        }
    }
}