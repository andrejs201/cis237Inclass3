using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237Inclass3
{
    class Program
    {
        static void Main(string[] args)
        {
            SalaryEmployee salaryEmployee = new SalaryEmployee("David", "Barnes", "IT", 150000);

            Console.WriteLine(salaryEmployee.ToString());
            Console.WriteLine(salaryEmployee.CalculateWeeklyGross());
            Console.WriteLine(salaryEmployee.GetDepartmentTwice());

            Console.WriteLine("**********************************************************");

            HourlyEmployee hourlyEmployee = new HourlyEmployee("Joe", "Somebody", "HR", 8.37m);
            hourlyEmployee.HoursWorked = 40;

            Console.WriteLine(hourlyEmployee.ToString());
            Console.WriteLine(hourlyEmployee.CalculateWeeklyGross());
            Console.WriteLine(hourlyEmployee.GetDepartmentTwice());

            Console.WriteLine("**********************************************************");

            //declare and instantiate one of each type of employee
            HourlyEmployee joe = new HourlyEmployee("Joe", "Somebody", "HR", 9.37m);
            joe.HoursWorked = 87;
            SalaryEmployee dave = new SalaryEmployee("Dave", "Barnes", "IT", 150000m);

            Employee spock = new SalaryEmployee("Mr.", "Spock", "ST", 0m);

            //Create an array of type IEmployee, and pass in the two instances we created. IEmployee can contain instances that are lower on the inheritance chain (more specific implementations).
            IEmployee[] employeeList = { joe, dave, new SalaryEmployee("James", "Kirk", "ST", 0m), spock };

            //Now we can loop through the list of employees and call the CalculateWeeklyGross on each of the employees. The program will be smart enough to know which method to call depending on the current instance it is working with.
            foreach(IEmployee employee in employeeList)
            {
                Console.WriteLine(employee.ToString());
                Console.WriteLine(employee.CalculateWeeklyGross());
                Console.WriteLine();
            }
        }
    }
}
