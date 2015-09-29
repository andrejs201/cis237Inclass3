using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237Inclass3
{
    class SalaryEmployee : Employee
    {

        private decimal yearlySalary;

        public decimal YearlySalary
        {
            get { return yearlySalary; }
            set { yearlySalary = value; }
        }

        public SalaryEmployee(string FirstName, string LastName, string Department, decimal YearlySalary) : base(FirstName, LastName, Department)
        {
            this.yearlySalary = YearlySalary;
        }

        public override string ToString()
        {
            return base.ToString() + " " + this.yearlySalary.ToString();
        }

        protected override void PrintFullName()
        {
            Console.WriteLine(base.ToString() + " " + this.yearlySalary.ToString());
        }

        public decimal CalculateWeeklyGross()
        {
            return this.yearlySalary / 52;
        }
    }
}
