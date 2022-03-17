using System;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee1 = new Employee
            {
                Name = "Ali",
                Surname = "Memmedov",
                Salary = 240
            };

            Employee employee2 = new Employee
            {
                Name = "Vaqif",
                Surname = "Mirzayev",
                Salary = 520
            };

            Employee employee3 = new Employee
            {
                Name = "Eli",
                Surname = "Nagiyev",
                Salary = 650

            };

            Department antikCargo = new Department(3);
            antikCargo.Name = "Antik Iness Cargo";
            antikCargo.EmployeeLimit = 2;

            try
            {
                antikCargo.AddEmployee(employee1);
                antikCargo.AddEmployee(employee2);
                antikCargo.AddEmployee(employee3);
            }
            catch (Exception)
            {

                Console.WriteLine("Employee limit doldu");
            }

            Console.WriteLine("==========Bizim Isciler==========");
            foreach (var item in antikCargo.Employee)
            {
                Console.WriteLine($"Ad: {item.Name} - Soyad: {item.Surname} - Maas: {item.Salary} ");
            }


        }
    }
}
