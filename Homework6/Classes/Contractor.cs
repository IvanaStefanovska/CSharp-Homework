using System;
using System.Collections.Generic;
using System.Text;
using Classes;

namespace Classes
{
    public class Contractor : Employee
    {
    }

    public override double GetSalary()
    {
        return WorkHours * PayPerHour;

    }
}
