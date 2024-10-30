namespace QuattroDesignPatterns.Behavioral.TemplateMethod
{
    #region TemplateMethod

    /*
        模板方法模式
        模板方法模式是一种行为型设计模式，它定义了一个算法的框架，并允许子类在不改变算法结构的情况下重新定义某些特定步骤。通过这种方式，模板方法模式提供了一种在基类中定义算法的骨架，并让子类实现特定的细节，从而实现代码的复用和扩展。

        使用场景
        当有多个类之间有共同的算法时，可以将算法的公共部分放在基类中，而让子类实现不同的步骤。
        在一些需要步骤按顺序执行的算法中，确保算法的结构不被改变，但具体实现可以灵活变更。
        当一个算法的某些步骤不需要被重写时，可以使用模板方法模式。

        优点
        通过模板方法，可以在父类中实现通用的算法结构，子类只需关心具体实现，减少代码重复。
        提高了代码的可读性和可维护性。
        可以在子类中自由扩展功能，而不影响基类的实现。

        缺点
        增加了类的数量，可能使系统变得复杂。
        由于父类定义了算法结构，可能限制了子类的灵活性。

        扩展说明
        模板方法模式广泛应用于框架设计、数据处理、游戏开发等场景，特别是当不同的实现具有共同的执行逻辑时。它提供了一种清晰的方式来管理代码的复用，并保证了一致的执行顺序。

        奥迪汽车例子
        想象一下，奥迪汽车的生产过程。不同型号的奥迪车可能在生产流程上有差异，但总体的生产步骤（如组装、测试、检验）是相似的。通过模板方法模式，可以在基类中定义生产流程的框架，而让每个具体型号的生产过程在子类中实现具体的步骤。
     */
    /*
        Template Method Pattern
        The Template Method Pattern is a behavioral design pattern that defines the skeleton of an algorithm in a base class, allowing subclasses to redefine specific steps of the algorithm without changing its structure. This pattern provides a way to define the structure of an algorithm in a base class while letting subclasses implement specific details, thus achieving code reuse and extensibility.

        Usage scenarios
        When there are common algorithms among multiple classes, the common parts of the algorithm can be placed in the base class while allowing subclasses to implement different steps.
        In algorithms where the steps need to be executed in a specific order, ensuring that the structure of the algorithm is not altered while allowing flexible implementation changes.
        When some steps of an algorithm do not need to be overridden, the template method pattern can be employed.

        Advantages
        By using a template method, a common algorithm structure can be implemented in the parent class, while subclasses only need to focus on the specific implementation, reducing code duplication.
        It improves code readability and maintainability.
        It allows free extension of functionalities in subclasses without affecting the implementation of the base class.

        Disadvantages
        It increases the number of classes, which can complicate the system.
        Since the parent class defines the algorithm structure, it may restrict the flexibility of subclasses.

        Additional Notes
        The Template Method Pattern is widely used in framework design, data processing, game development, and other scenarios, especially when different implementations share a common execution logic. It provides a clear way to manage code reuse while ensuring a consistent execution order.

        Audi Example
        Consider the production process of Audi cars. Different models of Audi may have variations in the production process, but the overall steps (like assembly, testing, inspection) are similar. Using the template method pattern, the framework for the production process can be defined in a base class, while each specific model's production process can implement the specific steps in subclasses.
     */

    #endregion TemplateMethod

    public class TemplateMethodDemo
    {
        public static void RunDemo()
        {
            Console.WriteLine("Producing Audi A3:");
            AudiCarProduction a3Production = new A3Production();
            a3Production.ProduceCar();

            Console.WriteLine("\nProducing Audi A4:");
            AudiCarProduction a4Production = new A4Production();
            a4Production.ProduceCar();
        }
    }
}