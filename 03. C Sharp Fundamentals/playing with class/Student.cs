public class Student
{
    private string name;
    private int age;

    public Student(string name, int age)
    {
        this.Name = name;
        this.Age = age;  
    }

    public string Name
    {
        get { return this.name; }
        private set { name = value; }
    }

    public int Age
    {
        get { return this.age; }
        private set { this.age = value; }
    }
}

