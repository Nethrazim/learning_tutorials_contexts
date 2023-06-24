using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningContexts.WashingMachine
{
    public class WachingMotorProxy
    {
        private WachingMotor _motor;
        public WachingMotorProxy(WachingMotor motor)
        {
            _motor = motor;
        }

        public void Run(WachingProgram program)
        {
            foreach (var action in program.Actions)
            {
                this._motor.Spin(program.SleepTime, action.spinningTimes, action.action);
            }
        }
    }
}
