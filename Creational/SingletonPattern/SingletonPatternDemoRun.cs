using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatterns.ConsoleApp.Creational.SingletonPattern
{
    public class SingletonPatternDemoRun
    {
        public static void Run()
        {
            var obj1 = SingletonLogger.GetInstance();
            obj1.Log("Hello world");
        }
    }
}