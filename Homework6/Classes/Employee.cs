using System;
using System.Collections.Generic;
using System.Text;
using Classes;

namespace Classes
{
    public class Employee
    {

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Role Role { get; set; }
        protected double Salary { get; set; }

        public double WorkHours { get; set; }

        public int PayPerHour { get; set; }

        public void PrintInfo()
        {
            Console.WriteLine("First Name: {0}, Last Name: {1}, Salary: {2}", FirstName, LastName, Salary, WorkHours, PayPerHour);
        }
        public virtual double GetSalary()
        {
            return Salary;

        }
    }

}
