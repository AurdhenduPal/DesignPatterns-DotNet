using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatterns.ConsoleApp.Creational.FactoryPattern_Simple
{
    public class FactoryPattern_SimpleDemoRun
    {
        public static void Run()
        {
            var obj1 = ShapeFactory.Create("Circle");
            obj1.Draw();
            Console.WriteLine("Factory Method (Simple)");
        }
    }
}