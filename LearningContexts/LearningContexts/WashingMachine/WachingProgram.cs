using LearningContexts.WashingMachine.enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace LearningContexts.WashingMachine
{
    public class WachingProgram
    {
        public WachingMachineProgram Code { get; set; }
        public string Name { get; set; } 
        public int MaxWeight { get; set; }
        public int Time { get; set; }
        public List<(SpinDirection action,uint spinningTimes)> Actions { get; set; } = new List<(SpinDirection, uint spinningTimes)>();
        public int SleepTime => 
            this.Time / (int)(this.Actions.Count + Actions.Select(x => x.spinningTimes).Sum(x => x));
        
    }
}
