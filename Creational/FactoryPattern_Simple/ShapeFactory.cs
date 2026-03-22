using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatterns.ConsoleApp.Creational.FactoryPattern_Simple
{
    public class ShapeFactory
    {
        public static IShape Create(string type)
        {
            if (type == "Circle")
            {
                return new Circle();
            }
            else if (type == "Square")
            {
                return new Square();
            }
            else
            {
                throw new Exception("Invalid Type");
            }
        }
    }
}