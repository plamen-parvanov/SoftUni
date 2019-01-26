using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    public class StartUp
    {
        private static List<Employee> employees;

        public static void Main()
        {
            ReadInput();

            PrintResult();
        }

        private static void PrintResult()
        {
            var department = employees.GroupBy(e => e.Department)
                     .OrderByDescending(d => d.Average(e => e.Salary))
                     .FirstOrDefault();

            PrintResult(department);
        }

        private static void PrintResult(IGrouping<string, Employee> department)
        {
            var departmentName = department.Key;

            Console.WriteLine($"Highest Average Salary: {departmentName}");

            department.OrderByDescending(e => e.Salary)
                      .ToList()
                      .ForEach(e => Console.WriteLine(e.ToString()));
        }

        private static void ReadInput()
        {
            employees = new List<Employee>();

            var numberOfLines = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfLines; i++)
            {
                var currEmployee = ParseEmployee(Console.ReadLine());

                employees.Add(currEmployee);
            }
        }

        private static Employee ParseEmployee(string input)
        {
            var inputArr = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            var name = inputArr[0];
            var salary = Decimal.Parse(inputArr[1]);
            var position = inputArr[2];
            var department = inputArr[3];
            string email;
            int age;
            Employee employee;

            if (inputArr.Length == 4)
            {
                employee = new Employee(name, salary, position, department);
            }
            else if (inputArr.Length == 6)
            {
                email = inputArr[4];
                age = int.Parse(inputArr[5]);

                employee = new Employee(name, salary, position, department, email, age);
            }
            else if (inputArr[4].Contains('@'))
            {
                email = inputArr[4];

                employee = new Employee(name, salary, position, department, email);
            }
            else
            {
                age = int.Parse(inputArr[4]);

                employee = new Employee(name, salary, position, department, age);
            }

            return employee;
        }
    }
}
