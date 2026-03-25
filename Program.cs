using DesignPatterns.ConsoleApp.Creational.FactoryPattern_GOF;
using DesignPatterns.ConsoleApp.Creational.FactoryPattern_Simple;
using DesignPatterns.ConsoleApp.Creational.SingletonPattern;

internal class Program
{
    private static void Main(string[] args)
    {
        //Calling from singleton design pattern
        SingletonPatternDemoRun.Run();

        //calling from factory design pattern
        FactoryPattern_SimpleDemoRun.Run();

        //calling from factory design pattern - GOF
        FactoryPattern_GOF_DemoRun.Run();
    }
}