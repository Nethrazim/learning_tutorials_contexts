using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningContexts.DesignPatterns.Creational.Factory
{
    interface Product{ public void behavior(); }

    class ConcreteProductA : Product { public void behavior() => Console.WriteLine("A behavior"); }
    class ConcreteProductB : Product { public void behavior() => Console.WriteLine("B behavior"); }

    abstract class Creator {
        public abstract Product FactoryMethod(string type);
    }

    class ConcreteCreator : Creator {
        public override Product FactoryMethod(string type)
        {
            switch (type) {
                case "A":
                    return new ConcreteProductA();
                case "B":
                    return new ConcreteProductB();
                default:
                    throw new ArgumentException("Invalid type", type);
            }
        }
    }

    public class FactoryMethod
    {
        public static void Run()
        {
            Creator factory = new ConcreteCreator();
            Product p = factory.FactoryMethod("A");
            p.behavior();
            Product p2 = factory.FactoryMethod("B");
            p2.behavior();
        }
    }
}
