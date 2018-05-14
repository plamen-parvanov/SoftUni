using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static List<Employee> employees;
    public static void Main()
    {
        ReadInput();

        var filteredEmployees = GetEmployeesInDepartmentWithHighestAverageSalary();

        Print(filteredEmployees);
    }

    private static void Print(List<Employee> filteredEmployees)
    {
        Console.WriteLine($"Highest Average Salary: {filteredEmployees[0].Department}");
        filteredEmployees
            .OrderByDescending(x => x.Salary)
            .ToList()
            .ForEach(e => Console.WriteLine(e));
    }

    private static List<Employee> GetEmployeesInDepartmentWithHighestAverageSalary()
    {
        return employees.GroupBy(x => x.Department).OrderByDescending(x => x.Average(y => y.Salary)).First().ToList();
    }

    private static void ReadInput()
    {
        employees = new List<Employee>();
        var employeeCount = int.Parse(Console.ReadLine());

        for (int i = 0; i < employeeCount; i++)
        {
            var inputLine = Console.ReadLine();

            var currEmployee = GetEmployee(inputLine);

            employees.Add(currEmployee);
        }
    }

    private static Employee GetEmployee(string input)
    {
        var splited = input.Split();
        var name = splited[0];
        var salary = decimal.Parse(splited[1]);
        var position = splited[2];
        var department = splited[3];

        if (splited.Length == 4)
        {
            return new Employee(name, salary, position, department);
        }
        else if (splited.Length == 6)
        {
            var email = splited[4];
            var age = int.Parse(splited[5]);
            return new Employee(name, salary, position, department, email, age);
        }
        else if (splited[4].Contains("@"))
        {
            var email = splited[4];
            return new Employee(name, salary, position, department, email);
        }

        return new Employee(name, salary, position, department, int.Parse(splited[4]));
    }
}
