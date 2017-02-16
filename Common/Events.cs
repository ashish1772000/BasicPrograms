using System;

namespace Common
{
    // Declare delegate and also pass the data that will be carried by it from Event to Event Handler
    public delegate void UpgradeSkillsDelegate(UpgradeSkillsArgs args);    

    //public class Program
    //{
    //    private static Employee _Emp = null; 
        
    //    public static void Main()
    //    {
    //        _Emp = new Employee("Ashish Garg", 1);

    //        // Register event here so we can handle it. 
    //        _Emp.SkillUpgradedEvnt += Emp_SkillUpgradedEvntHandler;

    //        // Call an API that internally raised the event
    //        _Emp.Training("Java", 5);
    //    }

    //    // Registered event handler 
    //    private static void Emp_SkillUpgradedEvntHandler(UpgradeSkillsArgs args)
    //    {
    //        Console.WriteLine(_Emp.Name +" skillset upgraded to " +args.Name +". Training was scheduled for " +args.NoOfDays.ToString() +" days.");            
    //    }
    //}

    // Create data that needs to be carry via UpgradeSkillsDelegate to event handler 
    public class UpgradeSkillsArgs
    {
        public string Name { get; set; }
        public int NoOfDays { get; set; }

        public UpgradeSkillsArgs(string name, int days)
        {
            this.Name = name;
            this.NoOfDays = days;
        }
    }

    // Class that raise the UpgradeSkills event
    public class Employee
    {
        public string Name { get; set; }
        public int Id { get; set; }

        public event UpgradeSkillsDelegate SkillUpgradedEvnt;

        public Employee(string name, int id)
        {
            this.Name = name;
            this.Id = id;
        }

        public void Training(string trngName, int trngNoOfDays)
        {
            if (SkillUpgradedEvnt != null)
            {
                UpgradeSkillsArgs args = new UpgradeSkillsArgs(trngName, trngNoOfDays);

                // Raise the SkillUpgrade Event 
                SkillUpgradedEvnt(args); 
            }
        }
    }
}