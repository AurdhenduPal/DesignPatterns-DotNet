using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatterns.ConsoleApp.Creational.FactoryPattern_GOF
{
    public abstract class NotificationCreator
    {
        public abstract INotification CreateNotification();
    }
}