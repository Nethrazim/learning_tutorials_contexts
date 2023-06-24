using LearningContexts.WashingMachine;

namespace LearningContexts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WachingMachine wMachine = WachingMachine.createInstance();
            wMachine.Start();
            Console.ReadKey();
        }
    }
}