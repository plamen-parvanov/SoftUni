public class Person
{
    private string firstName;
    private string lastName;
    private int age;
    private double salary;

    public string FirstName
    {
        get { return this.firstName; }
        private set { this.firstName = value; }
    }
    public string LastName
    {
        get { return this.lastName; }
        private set { this.lastName = value; }
    }
    public int Age
    {
        get { return this.age; }
        private set { this.age = value; }
    }
    public double Salary
    {
        get { return this.salary; }
        private set { this.salary = value; }
    }

    public Person(string firstName, string lastName, int age, double salary)
    {
        this.FirstName = firstName;
        this.LastName = lastName;
        this.Age = age;
        this.Salary = salary;
    }

    public void IncreaseSalary(double percent)
    {
        if (this.age > 30)
        {
            this.salary += this.salary * percent / 100; 
        }
        else
        {
            this.salary += this.salary * percent / 200;
        }
    }

    public override string ToString()
    {
        return $"{this.firstName} {this.lastName} get {this.salary:F2} leva";
    }
}
