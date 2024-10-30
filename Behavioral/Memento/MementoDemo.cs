namespace QuattroDesignPatterns.Behavioral.Memento
{
    #region Memento

    /*
        备忘录模式
        备忘录模式是一种行为型设计模式，用于在不违反封装性的前提下捕获一个对象的内部状态，以便在未来的某个时刻可以将该对象恢复到先前的状态。这个模式通常用于需要保存和恢复对象状态的场景，如撤销操作、游戏进度保存等。

        使用场景
        当需要保存和恢复对象的状态时，例如在文本编辑器中实现撤销和重做功能。
        当需要在复杂的对象操作中保留历史状态时，例如游戏中的关卡进度。
        当希望实现多个对象状态的快速保存和恢复时。

        优点
        提供了一种简便的方法来恢复对象的状态，而不需要暴露对象的内部实现。
        支持状态的多次保存和恢复，提供了灵活性。
        减少了对象之间的耦合，因为状态管理在备忘录中进行，而不是在对象本身。

        缺点
        如果需要保存的状态数量较多，可能会消耗大量内存。
        备忘录对象的实现可能会变得复杂，特别是当对象的状态较为复杂时。

        扩展说明
        备忘录模式常用于编辑器软件、游戏应用和任何需要状态保存和恢复的应用场景。它可以与其他设计模式结合使用，如命令模式和状态模式，以实现更复杂的行为。

        奥迪汽车例子
        想象一下，奥迪汽车的驾驶模式切换。在切换模式（如运动模式、舒适模式和经济模式）时，可以保存当前的驾驶状态，以便在需要时恢复。
     */
    /*
        Memento Pattern
        The Memento Pattern is a behavioral design pattern that allows capturing an object's internal state without violating encapsulation, so that the object can be restored to this state later. This pattern is typically used in scenarios where saving and restoring the state of an object is necessary, such as undo operations, saving game progress, etc.

        Usage scenarios
        When there is a need to save and restore the state of an object, such as implementing undo and redo functionality in a text editor.
        When preserving historical states in complex object operations, such as saving game progress.
        When rapid saving and restoring of multiple object states is desired.

        Advantages
        Provides a convenient way to restore an object's state without exposing its internal implementation.
        Supports multiple state saves and restores, offering flexibility.
        Reduces coupling between objects, as state management occurs in the memento rather than in the objects themselves.

        Disadvantages
        If a large number of states need to be saved, it can consume considerable memory.
        The implementation of memento objects can become complex, especially when the object's state is intricate.

        Additional Notes
        The Memento Pattern is commonly used in editor software, gaming applications, and any application that requires state saving and restoration. It can be combined with other design patterns, such as the Command Pattern and the State Pattern, to achieve more complex behaviors.

        Audi Example
        Consider the mode switching in an Audi car's driving settings. When switching between modes (such as Sport, Comfort, and Economy), the current driving state can be saved for restoration when needed.
     */

    #endregion Memento

    public class MementoDemo
    {
        public static void RunDemo()
        {
            Originator originator = new Originator();
            Caretaker caretaker = new Caretaker(originator);

            originator.SetState("State #1");
            caretaker.AddMemento(originator.SaveStateToMemento());

            originator.SetState("State #2");
            caretaker.AddMemento(originator.SaveStateToMemento());

            originator.SetState("State #3");
            Console.WriteLine($"Restoring to: {caretaker.GetMemento(0).State}");
            originator.GetStateFromMemento(caretaker.GetMemento(0));
        }
    }
}