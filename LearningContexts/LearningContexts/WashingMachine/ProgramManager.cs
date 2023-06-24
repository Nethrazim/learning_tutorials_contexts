using LearningContexts.WashingMachine.enums;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace LearningContexts.WashingMachine
{
    public class ProgramManager
    {
        public Dictionary<WachingMachineProgram, WachingProgram> AvailablePrograms { get; private set; }
        = new Dictionary<WachingMachineProgram, WachingProgram> {
            {
                WachingMachineProgram.DARK, 
                new WachingProgram() { 
                    Actions = new List<(SpinDirection, uint)>() 
                        {
                            (SpinDirection.LEFT, 3),
                            (SpinDirection.RIGHT, 3),
                            (SpinDirection.LEFT, 3),
                    },
                    Code = WachingMachineProgram.DARK,
                    MaxWeight = 10000,
                    Name = "Dark Clothes",
                    Time = 10000
                }
            }
        };

        public WachingProgram? SelectedProgram { get; private set; }

        public void SelectProgram(WachingMachineProgram selectedProgramCode)
        {
            WachingProgram? selectedProgram = null;
            if (AvailablePrograms.TryGetValue(selectedProgramCode, out selectedProgram))
            {
                this.SelectedProgram = selectedProgram;
            }
            else
            {
                Console.WriteLine("Selected Program Not Found");    
            }
        }

        public void AddProgram(WachingProgram newProgram) 
        {
            if (AvailablePrograms.TryAdd(newProgram.Code, newProgram))
            {
                Console.WriteLine($"Program: {newProgram.Code + " " + newProgram.Name} has been added.");
            }
            else
            {
                Console.WriteLine("Program already exists");
            }
        }
    }
}
