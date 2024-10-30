namespace QuattroDesignPatterns.Behavioral.Mediator
{
    #region Mediator

    /*
        中介者模式
        中介者模式是一种行为型设计模式，它通过引入一个中介对象来减少不同对象之间的直接依赖，使得对象之间的通信通过中介进行，而不是直接交互。这样可以降低系统的耦合度，提高系统的可维护性。

        使用场景
        当多个对象之间存在复杂的交互关系时。
        当希望将对象的交互行为封装在一个中介者对象中，以避免直接的相互引用。
        当需要集中管理对象之间的交互时。

        优点
        减少了对象之间的依赖，使得系统更加灵活和可扩展。
        提高了代码的可维护性，因为对象之间的交互被封装在中介者中。
        可以更容易地控制对象之间的交互。

        缺点
        中介者对象可能会变得复杂，因为它需要管理多个对象之间的交互。
        如果中介者设计不当，可能会导致其成为系统中的单一故障点。

        扩展说明
        中介者模式可以用于 GUI 系统中的组件交互，例如按钮、文本框和下拉菜单之间的交互。通过中介者，可以方便地管理这些组件之间的事件和数据流动。

        奥迪汽车例子
        想象一下，奥迪汽车的多媒体系统与导航系统之间的交互。中介者可以负责协调两者之间的数据交换，例如，当导航系统发出语音提示时，多媒体系统可以自动调整音量。
     */
    /*
        Mediator Pattern
        The Mediator Pattern is a behavioral design pattern that reduces direct dependencies between objects by introducing a mediator object that facilitates communication between them. This pattern allows objects to communicate indirectly through the mediator rather than directly, reducing coupling and enhancing maintainability.

        Usage scenarios
        When multiple objects have complex interdependencies.
        When you want to encapsulate the interactions between objects in a mediator to avoid direct references.
        When you need to centrally manage the interactions between objects.

        Advantages
        Reduces dependencies between objects, making the system more flexible and extensible.
        Enhances code maintainability as interactions between objects are encapsulated within the mediator.
        Allows for easier control of interactions between objects.

        Disadvantages
        The mediator object can become complex as it manages interactions among multiple objects.
        If the mediator is poorly designed, it can become a single point of failure in the system.

        Additional Notes
        The Mediator Pattern can be used in GUI systems for managing interactions between components, such as buttons, text boxes, and dropdown menus. It simplifies the management of events and data flow among these components.

        Audi Example
        Consider the interaction between the multimedia system and the navigation system in an Audi car. The mediator can be responsible for coordinating the data exchange between the two, such as automatically adjusting the volume of the multimedia system when the navigation system issues voice prompts.
     */

    #endregion Mediator

    public class MediatorDemo
    {
        public static void RunDemo()
        {
            var radio = new Radio();
            var navigationSystem = new NavigationSystem();
            var mediator = new CarMediator(radio, navigationSystem);

            radio.PlayMusic();
            navigationSystem.IssueVoicePrompt();
        }
    }
}