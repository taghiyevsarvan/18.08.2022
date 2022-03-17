using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp5
{
    internal class Department
    {
        public string Name { get; set; }
        public int EmployeeLimit { get; set; }
        public double SalaryLimit { get; set; }
        public string Employes { get; set; }

        public Department(int limit)
        {
            this.employee = new Employee[0];
            this.EmployeeLimit = limit;
        }

        public Employee [] employee=new Employee[0];


        public void AddEmployee(Employee employees)
        {
            if(employee.Length<EmployeeLimit)
            {
                Array.Resize(ref employee, EmployeeLimit);
                employee[employee.Length - 1] = employees;
            }
        }

    }
}
