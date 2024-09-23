using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    public class Employee
    {
        private string firstName;
        private string lastName;
        private double salary;
        private int age;
        public string Firstname
        {
            get 
            {
                return firstName;
            }
            set
            {
                firstName = value;
            }
        }
       
        
        public string Lastname
        {
            get
            {
                return lastName;
            }
            set
            {
                lastName = value;
            }

        }

        public int Age 
        {
            get
            {
                return age;
                    
            }
            set
            {
                if (age > 0)
                {
                    age = value;
                }
                else
                {
                    age = 1;
                }
            }
        }
        public double Salary 
        {
            get
            {
                return salary;
            }
            set
            {
                if (salary >= 0)
                {
                    salary = value;
                }
                else 
                {
                    salary = 0;
                }
            }
        }
        public Employee(string firstName, string lastName, int age) 
        { 
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age; 
        }
    
        public double GetAnnualSalary() 
        {
            return Salary * 12;
        }
    
        public void GiveRaise(double percentage)
        {
            Salary = Salary * ((percentage / 100) + 1);
            //double realPercentage = (percentage / 100) + 1;
            //double newSalary = Salary * realPercentage;
            
            Console.WriteLine($"Nya månadslönen är: {Salary}");
            Console.WriteLine($"Nya årslönen är {Salary * 12}");
        }
        public void DisplayEmployeeInfo() 
        {
            Console.WriteLine($"Namn: {Firstname} {Lastname}\nÅlder: {Age}\nLön: {Salary} " );
                
        }
    }
}
