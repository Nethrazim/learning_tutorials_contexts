using LearningContexts.WashingMachine.enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningContexts.WashingMachine
{
    public class WachingMotor : IWachingMotor
    {
        public void Spin(int sleepTime, uint numberOfTimes, SpinDirection direction, uint time = 1)
        {
            if (numberOfTimes == 0)
            {
                return;
            }

            Console.WriteLine($"W-Machine is spinning {direction} #:{time} time");
            Thread.Sleep(sleepTime);

            Spin(sleepTime, --numberOfTimes, direction, ++time);
        }
    }
}
