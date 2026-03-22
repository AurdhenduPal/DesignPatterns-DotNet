using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatterns.ConsoleApp.Creational.FactoryPattern_Simple
{
    public class Square : IShape
    {
        public void Draw()
        {
            Console.WriteLine("Square");
        }
    }
}