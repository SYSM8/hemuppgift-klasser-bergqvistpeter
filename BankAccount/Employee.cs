using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    public class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Salary { get; set; }
        
        public Employee(string firstName, string lastName) 
        { 
            FirstName = firstName;
            LastName = lastName;
        }
    
        public void GetAnnualSalary() 
        {
            Console.WriteLine($"Årlig lön är:{Salary*12}");
        }
    
        public void GiveRaise(double percentage)
        {
            double realPercentage = (percentage / 100) + 1;
            double newSalary = Salary * realPercentage;
            
            Console.WriteLine($"Nya månadslönen är: {(int)newSalary}");
            Console.WriteLine($"Nya årslönen är {(int)newSalary * 12}");
        }
    }
}
