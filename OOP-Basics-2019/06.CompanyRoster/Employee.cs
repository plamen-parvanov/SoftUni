namespace DefiningClasses
{
    public class Employee
    {
        public Employee(string name, decimal salary, string position, string department)
        {
            this.Name = name;
            this.Salary = salary;
            this.Position = position;
            this.Department = department;
        }

        public Employee(string name, decimal salary, string position, string department,
            string email) : this(name, salary, position, department)
        {
            this.Email = email;
        }

        public Employee(string name, decimal salary, string position, string department,
            int age) : this(name, salary, position, department)
        {
            this.Age = age;
        }

        public Employee(string name, decimal salary, string position, string department,
            string email, int age) : this(name, salary, position, department, age)
        {
            this.Email = email;
        }

        public string Name { get; private set; }
        
        public decimal Salary { get; private set; }

        public string Position { get; private set; }

        public string Department { get; private set; }

        public string Email { get; private set; } = "n/a";

        public int Age { get; private set; } = -1;

        public override string ToString()
        {
            var result = $"{this.Name} {this.Salary:F2} {this.Email} {this.Age}";

            return result;
        }
    }
}
