using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.VisualBasic;

namespace DesignPatterns.ConsoleApp.Creational.FactoryPattern_GOF
{
    public class FactoryPattern_GOF_DemoRun
    {
        public static void Run()
        {
            NotificationCreator email = new EmailCreator();
            var emailNotify = email.CreateNotification();
            emailNotify.Notify();
        }
    }
}