namespace QuattroDesignPatterns.Creational.Builder
{
    #region Builder

    /*
        建造者模式
        建造者模式是一种创建型设计模式，它使用多个简单的对象一步一步构建一个复杂的对象。通过将构建过程与表示分离，建造者模式允许同样的构建过程创建不同的表示。

        使用场景
        需要创建一个复杂对象的多个不同表示。
        构建过程涉及多个步骤，可能需要配置某些属性。

        优点
        可以通过相同的构建过程生成不同的表示。
        代码清晰，易于维护。
        易于扩展，可以添加新的表示而不影响已有的代码。

        缺点
        需要创建多个类来表示不同的建造者。
        可能会导致系统变得复杂。

        扩展说明
        可以使用建造者模式来简化对象的创建，特别是在对象构建的复杂性增加时。

        奥迪汽车例子
        在奥迪汽车中，可以使用建造者模式来配置不同的车型和选项，例如车身颜色、内饰材料、轮毂设计等。
     */
    /*
        Builder Pattern
        The Builder Pattern is a creational design pattern that allows for the step-by-step construction of complex objects. Instead of using a single constructor with numerous parameters, the Builder Pattern provides a more readable and flexible approach by separating the construction process from the representation.

        Usage scenarios
        When an object requires several configurations or parameters that can vary.
        When you need to create different representations of the same type of object.
        When the creation process of an object is complex and requires multiple steps.

        Advantages
        Improved Readability: The construction process is clearer and more understandable.
        Flexibility: You can easily change the internal representation of the object without modifying the code that uses it.
        Encapsulation: The Builder Pattern encapsulates the construction logic, allowing you to keep the object creation separate from its representation.

        Disadvantages
        Increased Complexity: It may introduce additional classes and complexity in simple scenarios where a simple constructor suffices.
        More Boilerplate Code: You may end up writing more code, as builders typically require multiple methods for different configurations.

        Additional Notes
        You can use the Builder pattern to simplify the creation of objects, especially as the complexity of object construction increases.

        Audi Example
        In our Audi car configuration, we can use the Builder Pattern to construct different types of Audi cars. For example, the AudiCarBuilder allows us to specify various features such as model, color, and interior type. Instead of using a constructor that takes all these parameters, we can set them step by step, making the process cleaner and easier to manage.
     */

    #endregion Builder

    public static class BuilderDemo
    {
        public static void RunDemo()
        {
            Console.WriteLine("Welcome to the Audi Car Builder!");

            Console.Write("Please enter the Audi model (A3, A4, A6): ");
            string model = Console.ReadLine()?.ToLower() ?? "A6";

            Console.Write("Please enter the desired color (White, Black, Green, Red): ");
            string color = Console.ReadLine()?.ToLower() ?? "White";

            Console.Write("Please enter the interior type (Leather, Wood Trim, Alcantara, Fabric): ");
            string interior = Console.ReadLine()?.ToLower() ?? "Leather";

            var audiCar = new AudiCarBuilder()
                            .SetModel(model)
                            .SetColor(color)
                            .SetInterior(interior)
                            .Build();

            Console.WriteLine("Successfully created the following Audi Car:");
            audiCar.ShowDetails();
        }
    }
}