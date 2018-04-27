﻿using System;

public class Person
{
    private string firstName;
    private string lastName;
    private int age;
    private double salary;

    public string FirstName
    {
        get { return this.firstName; }
        private set
        {
            if (value.Length < 3)
            {
                throw new ArgumentException("First name cannot be less than 3 symbols");
            }

            this.firstName = value;
        }
    }
    public string LastName
    {
        get { return this.lastName; }
        private set
        {
            if (value.Length < 3 )
            {
                throw new ArgumentException("Last name cannot be less than 3 symbols");
            }

            this.lastName = value;
        }
    }
    public int Age
    {
        get { return this.age; }
        private set
        {
            if (value < 0)
            {
                throw new ArgumentException("Age cannot be zero or negative integer");
            }

            this.age = value;
        }
    }
    public double Salary
    {
        get { return this.salary; }
        private set
        {
            if (value < 460.0)
            {
                throw new ArgumentException("Age cannot be zero or negative integer");
            }

            this.salary = value;
        }
    }

    public Person(string firstName, string lastName, int age, double salary)
    {
        this.FirstName = firstName;
        this.LastName = lastName;
        this.Age = age;
        this.Salary = salary;
    }

    public override string ToString()
    {
        return $"{this.firstName} {this.lastName} get {this.salary:F2} leva";
    }

    public void IncreaseSalary(double perecent)
    {
        if (this.age > 30)
        {
            this.salary += this.salary * perecent / 100;
        }
        else
        {
            this.salary += this.salary * perecent / 200;
        }
    }
}

