using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningContexts.DesignPatterns.Creational.Singleton
{
    public class SingletonLazy
    {
        private static SingletonLazy instance;
        private SingletonLazy() { }

        public static SingletonLazy GetInstance() {
            if (instance == null) {
                instance = new SingletonLazy();
            }
            return instance;
        }
    }
}
