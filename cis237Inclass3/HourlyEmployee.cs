using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237Inclass3
{
    class HourlyEmployee : Employee
    {
        private decimal hourlyRrate;
        private double hoursWorked;

        public double HoursWorked
        {
            get { return hoursWorked; }
            set { hoursWorked = value; }
        }

        public decimal Hourlyrate
        {
            get { return hourlyRrate; }
            set { hourlyRrate = value; }
        }

        public HourlyEmployee(string FirstName, string LastName, string Department, decimal HourlyRate)
            : base(FirstName, LastName, Department)
        {
            this.hourlyRrate = HourlyRate;
        }

        public override string ToString()
        {
            return base.ToString() + " " + hourlyRrate.ToString("c");
        }

        //Note: Did not override the PrintFullName protected virtual method. Even though it is protected and virtual, we aren't going to override it. Calling it will just call the parent version.

        public override decimal CalculateWeeklyGross()
        {
            return hourlyRrate * (decimal)hoursWorked;
        }

        public override string GetDepartmentTwice()
        {
            return base.GetDepartmentTwice() + base.GetDepartmentTwice();
        }
        
    }
}
