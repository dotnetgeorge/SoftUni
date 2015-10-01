using System;
using System.Collections.Generic;
using CompanyHierarchy.Persons;

namespace CompanyHierarchy
{
    class CompanyHierarchyApp
    {
        static void Main()
        {
            var employees = new List<Employee>();

            InitializeEmployees(ref employees);

            PrintEmployees(employees);
        }

        public static void InitializeEmployees(ref List<Employee> employees)
        {
            var dev = new Developer(1, "John", "Newman", 3344.00, Department.Production, new List<Project>
            {
                new Project("Test", DateTime.Now, "Testing", State.Open),
                new Project("Test 2", DateTime.Now, "Testing 2", State.Closed)
            });

            var manager = new Manager(2, "Sara", "Dilan", 1500.00, Department.Marketing, new List<Employee>
            {
                new Employee(3, "Test", "Test", 640.93, Department.Marketing),
                new Employee(4, "Mara", "Test", 789.00, Department.Production)
            });

            var salesEmployee = new SalesEmployee(5, "Harold", "Finch", 8888.88, Department.Sales, new List<Sale>
            {
                new Sale("Hack", DateTime.Now, 66666.77),
                new Sale("Software", DateTime.Now, 3333.67)
            });

            employees.Add(dev);
            employees.Add(manager);
            employees.Add(salesEmployee);
        }

        public static void PrintEmployees(List<Employee> employees)
        {
            foreach (var employee in employees)
            {
                Console.WriteLine(employee.ToString());
            }
        }
    }
}