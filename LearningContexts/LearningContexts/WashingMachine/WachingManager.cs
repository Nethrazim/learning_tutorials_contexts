using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningContexts.WashingMachine
{
    public class WachingManager
    {
        
        private WachingMotorProxy motorProxy { get; set; }
        public WachingManager(WachingMotorProxy motorProxy)
        {
            this.motorProxy = motorProxy;
        }

        public void Start(WachingProgram program)
        {
            if (program == null)
            {
                Console.WriteLine("Program not selected");
                return;
            }

            motorProxy.Run(program);
        }
    }
}
