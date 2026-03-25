using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatterns.ConsoleApp.Creational.FactoryPattern_GOF
{
    public class SmsSender : INotification
    {
        public void Notify()
        {
            Console.WriteLine("SMS Sent");
        }
    }
}