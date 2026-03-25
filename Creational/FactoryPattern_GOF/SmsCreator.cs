using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatterns.ConsoleApp.Creational.FactoryPattern_GOF
{
    public class SmsCreator : NotificationCreator
    {
        public override INotification CreateNotification()
        {
            return new SmsSender();
        }
    }
}