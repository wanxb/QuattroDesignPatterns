using QuattroDesignPatterns.Behavioral.ChainOfResponsibility;
using QuattroDesignPatterns.Behavioral.Command;
using QuattroDesignPatterns.Behavioral.Interpreter;
using QuattroDesignPatterns.Behavioral.Iterator;
using QuattroDesignPatterns.Behavioral.Mediator;
using QuattroDesignPatterns.Behavioral.Memento;
using QuattroDesignPatterns.Behavioral.Observer;
using QuattroDesignPatterns.Behavioral.State;
using QuattroDesignPatterns.Behavioral.Strategy;
using QuattroDesignPatterns.Behavioral.TemplateMethod;
using QuattroDesignPatterns.Behavioral.Visitor;
using QuattroDesignPatterns.Creational.AbstractFactory;
using QuattroDesignPatterns.Creational.Builder;
using QuattroDesignPatterns.Creational.Factory;
using QuattroDesignPatterns.Creational.Prototype;
using QuattroDesignPatterns.Creational.Singleton;
using QuattroDesignPatterns.Structural.Adapter;
using QuattroDesignPatterns.Structural.Bridge;
using QuattroDesignPatterns.Structural.Composite;
using QuattroDesignPatterns.Structural.Decorator;
using QuattroDesignPatterns.Structural.Facade;
using QuattroDesignPatterns.Structural.Flyweight;
using QuattroDesignPatterns.Structural.Proxy;

Console.WriteLine("1. Singleton");
Console.WriteLine("2. Factory");
Console.WriteLine("3. Abstract Factory");
Console.WriteLine("4. Builder");
Console.WriteLine("5. Prototype");

Console.WriteLine("6. Adapter");
Console.WriteLine("7. Bridge");
Console.WriteLine("8. Composite");
Console.WriteLine("9. Flyweight");
Console.WriteLine("10. Proxy");
Console.WriteLine("11. Facade");
Console.WriteLine("12. Decorator");

Console.WriteLine("13. Strategy");
Console.WriteLine("14. State");
Console.WriteLine("15. Chain of Responsibility");
Console.WriteLine("16. Command");
Console.WriteLine("17. Interpreter");
Console.WriteLine("18. Iterator");
Console.WriteLine("19. Mediator");
Console.WriteLine("20. Memento");
Console.WriteLine("21. Observer");
Console.WriteLine("22. TemplateMethod");
Console.WriteLine("23. Visitor");

Console.Write("\nPlease select the design mode you want to use:");

string choice = Console.ReadLine();

switch (choice)
{
    case "1":
        Console.WriteLine("\nRunning Singleton Pattern Demo...\n");
        SignletonDemo.RunDemo();
        break;

    case "2":
        Console.WriteLine("\nRunning Factory Pattern Demo...\n");
        FactoryDemo.RunDemo();
        break;

    case "3":
        Console.WriteLine("\nRunning Abstract Factory Pattern Demo...\n");
        AbstractFactoryDemo.RunDemo();
        break;

    case "4":
        Console.WriteLine("\nRunning Builder Pattern Demo...\n");
        BuilderDemo.RunDemo();
        break;

    case "5":
        Console.WriteLine("\nRunning Prototype Pattern Demo...\n");
        PrototypeDemo.RunDemo();
        break;

    case "6":
        Console.WriteLine("\nRunning Adapter Pattern Demo...\n");
        AdapterDemo.RunDemo();
        break;

    case "7":
        Console.WriteLine("\nRunning Bridge Pattern Demo...\n");
        BridgeDemo.RunDemo();
        break;

    case "8":
        Console.WriteLine("\nRunning Composite Pattern Demo...\n");
        CompositeDemo.RunDemo();
        break;

    case "9":
        Console.WriteLine("\nRunning Flyweight Pattern Demo...\n");
        FlyweightDemo.RunDemo();
        break;

    case "10":
        Console.WriteLine("\nRunning Proxy Pattern Demo...\n");
        ProxyDemo.RunDemo();
        break;

    case "11":
        Console.WriteLine("\nRunning Facade Pattern Demo...\n");
        FacadeDemo.RunDemo();
        break;

    case "12":
        Console.WriteLine("\nRunning Decorator Pattern Demo...\n");
        DecoratorDemo.RunDemo();
        break;

    case "13":
        Console.WriteLine("\nRunning Strategy Pattern Demo...\n");
        StrategyDemo.RunDemo();
        break;

    case "14":
        Console.WriteLine("\nRunning State Pattern Demo...\n");
        StateDemo.RunDemo();
        break;

    case "15":
        Console.WriteLine("\nRunning Chain of Responsibility Pattern Demo...\n");
        ChainOfResponsibilityDemo.RunDemo();
        break;

    case "16":
        Console.WriteLine("\nRunning Command Pattern Demo...\n");
        CommandDemo.RunDemo();
        break;

    case "17":
        Console.WriteLine("\nRunning Interpreter Pattern Demo...\n");
        InterpreterDemo.RunDemo();
        break;

    case "18":
        Console.WriteLine("\nRunning Iterator Pattern Demo...\n");
        IteratorDemo.RunDemo();
        break;

    case "19":
        Console.WriteLine("\nRunning Mediator Pattern Demo...\n");
        MediatorDemo.RunDemo();
        break;

    case "20":
        Console.WriteLine("\nRunning Memento Pattern Demo...\n");
        MementoDemo.RunDemo();
        break;

    case "21":
        Console.WriteLine("\nRunning Observer Pattern Demo...\n");
        ObserverDemo.RunDemo();
        break;

    case "22":
        Console.WriteLine("\nRunning TemplateMethod Pattern Demo...\n");
        TemplateMethodDemo.RunDemo();
        break;

    case "23":
        Console.WriteLine("\nRunning Visitor Pattern Demo...\n");
        VisitorDemo.RunDemo();
        break;

    default:
        Console.WriteLine("Invalid choice, please select a valid option.\r\n");
        break;
}