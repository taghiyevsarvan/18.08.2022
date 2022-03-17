using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp5
{
    internal class Department
    {
        public Department(int limit)
        {
            this.employee = new Employee[0];
            this.EmployeeLimit = limit;
        }
        public string Name { get; set; }
        public int EmployeeLimit { get; set; }
        public double SalaryLimit { get; set; }
        public string Employee { get; set; }

        

        public Employee[] employee;


        public void AddEmployee(Employee employees)
        {
            if(this.employee.Length==this.EmployeeLimit)
                throw new Exception("Employee Limit Doldu");
                Array.Resize(ref employee, EmployeeLimit);
                employee[employee.Length - 1] = employees;
            
        }

    }
}
