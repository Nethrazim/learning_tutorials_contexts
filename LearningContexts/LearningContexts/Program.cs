using LearningContexts.DesignPatterns.Creational.Builder;
using LearningContexts.DesignPatterns.Creational.Factory;
using LearningContexts.DesignPatterns.Creational.Prototype;
using LearningContexts.DesignPatterns.Structural.Composite;
using LearningContexts.WashingMachine;

namespace LearningContexts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //WachingMachine wMachine = WachingMachine.createInstance();
            //wMachine.Start();
            //FactoryMethod.Run();
            //Prototype.Run();
            //Builder.Run();
            CompositeRun.Run();
            Console.ReadKey();
        }
    }
}