public class Company
{
    public string companyName;
    public string department;
    public decimal salary;

    public Company(string companyName, string department, decimal salary)
    {
        this.companyName = companyName;
        this.department = department;
        this.salary = salary;
    }

    public override string ToString()
    {
        return $"{this.companyName} {this.department} {this.salary:F2}";
    }
}