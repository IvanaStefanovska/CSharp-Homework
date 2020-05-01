using System;
using System.Collections.Generic;
using System.Text;
using Classes;

namespace Classes
{
    public class Manager : Employee
    {

        private double Bonus { get; set; }

        public Manager()
        {
        }

        public Manager(string first, string last)
        {
            FirstName = first;
            LastName = last;
            Salary = 1000;
            Role = Role.Manager;
        }

        public void AddBonus(double bonus)
        {
            Bonus = bonus;
        }

        public override double GetSalary()
        {
            return Salary += Bonus;



        }
    }
}
