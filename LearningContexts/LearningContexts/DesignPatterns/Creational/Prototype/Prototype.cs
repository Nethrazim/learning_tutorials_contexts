using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningContexts.DesignPatterns.Creational.Prototype
{
    public interface IEmployee
    {
        IEmployee Clone();
        string GetDetails();
    }

    public class Developer : IEmployee
    {
        public int WordsPerMinute { get; set; }
        public string Name { get; set; }
        public string Role { get; set; }
        public string PreferredLanguage { get; set; }

        public IEmployee Clone()
        {
            return (IEmployee)MemberwiseClone();
        }
        public string GetDetails()
        {
            return string.Format("{0} - {1} - {2}", Name, Role, PreferredLanguage);
        }
    }

    public class Prototype
    {
        public static void Run()
        {
            Developer dev = new Developer();
            dev.Name = "Rahul";
            dev.Role = "Team Leader";
            dev.PreferredLanguage = "C#";

            Developer devCopy = (Developer)dev.Clone();
            devCopy.Name = "Arif"; //Not mention Role and PreferredLanguage, it will copy above

            Console.WriteLine(dev.GetDetails());
            Console.WriteLine(devCopy.GetDetails());
        }
    }
}
