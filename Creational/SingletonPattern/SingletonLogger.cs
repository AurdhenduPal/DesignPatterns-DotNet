using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatterns.ConsoleApp.Creational.SingletonPattern
{
    public class SingletonLogger
    {
        private static SingletonLogger _instance;
        private static readonly object _lock = new object();

        private SingletonLogger() { }

        public static SingletonLogger GetInstance()
        {
            lock (_lock)
            {
                if (_instance == null)
                {
                    _instance = new SingletonLogger();
                }
            }

            return _instance;
        }

        internal void Log(string message)
        {
            Console.WriteLine(message);
        }


    }
}