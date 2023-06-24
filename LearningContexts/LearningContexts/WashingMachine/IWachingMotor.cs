using LearningContexts.WashingMachine.enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningContexts.WashingMachine
{
    public interface IWachingMotor
    {
        public void Spin(int sleepTime, uint numberOfTimes, SpinDirection direction, uint time = 1);
    }
}
