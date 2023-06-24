using LearningContexts.WashingMachine.enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningContexts.WashingMachine
{
    public class WachingMachine
    {
        private ProgramManager ProgramManager { get; set; }
        private WachingManager WachingManager { get; set; }

        private static WachingMachine _instance;        
        private WachingMachine() {
            buildStandard();
        }

        private void buildStandard()
        {
            ProgramManager = new ProgramManager();
            WachingManager = new WachingManager(new WachingMotorProxy(new WachingMotor()));
        }

        public static WachingMachine createInstance()
        {
            if (_instance == null)
            {
                _instance = new WachingMachine();
            }

            return _instance;
        }

        public void Start()
        {
            ProgramManager.SelectProgram(WachingMachineProgram.DARK);
            WachingManager.Start(ProgramManager.SelectedProgram);
        }
    }
}
