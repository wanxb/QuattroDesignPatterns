namespace QuattroDesignPatterns.Creational.Singleton
{
    #region Signleton

    /*
        单例模式
        单例模式确保一个类只有一个实例，并提供一个全局访问点。

        使用场景
        配置管理：管理应用程序配置信息。
        日志记录：统一的日志记录器实例。
        线程池：控制线程的管理。

        优点
        控制资源访问，避免资源浪费。
        统一管理，方便全局状态维护。
        缺点
        可能导致内存泄漏。
        难以进行单元测试。

        扩展说明
        可以通过延迟加载（Lazy Loading）优化单例创建。

        奥迪汽车例子
        在奥迪汽车中，MMI系统（多媒体界面系统）可能只有一个实例，管理音频和导航功能。
    */
    /*
        Singleton Pattern
        Singleton Pattern ensures that a class has only one instance and provides a global access point.

        Usage scenarios
        Configuration Management: Managing application configuration information.
        Logging: A single logging instance.
        Thread Pool: Managing threads efficiently.

        Advantages
        Control access to resources and avoid waste.
        Unified management for global state maintenance.

        Disadvantages
        Potential memory leaks.
        Difficult to perform unit testing.

        Additional Notes
        You can optimize singleton creation using Lazy Loading.

        Audi Example
        In an Audi car, the MMI system (Multimedia Interface) may have only one instance managing audio and navigation functions.
    */

    #endregion Signleton

    public class SignletonDemo
    {
        public static void RunDemo()
        {
            // Get the singleton instance and play music
            var audioSystem = AudiAudioSystem.Instance;
            audioSystem.PlayMusic("Imagine - John Lennon");

            // Stop the music
            audioSystem.StopMusic();
        }
    }
}