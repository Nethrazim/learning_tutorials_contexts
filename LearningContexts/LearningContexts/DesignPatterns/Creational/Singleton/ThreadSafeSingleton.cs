using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningContexts.DesignPatterns.Creational.Singleton
{
    public class ThreadSafeSingleton
    {
        private static ThreadSafeSingleton instance;
        private ThreadSafeSingleton() { }
        private static object lockThis = new object();

        public static ThreadSafeSingleton Instance()
        {
            lock(lockThis)
            {
                if(instance == null)
                {
                    instance = new ThreadSafeSingleton();
                }

                return instance;
            }
        }
    }
}
