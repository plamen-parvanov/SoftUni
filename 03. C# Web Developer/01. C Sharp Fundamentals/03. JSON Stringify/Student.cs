using System.Collections.Generic;

public class Student
{
    private string name;
    private int age;
    private List<int> grades;

    public string Name
    {
        get { return this.name; }

        private set { this.name = value; }
    }
    public int Age
    {
        get { return this.age; }

        private set { this.age = value; }
    }
    public List<int> Grades
    {
        get { return this.grades; }

        private set
        {
            if (this.grades == null)
            {
                this.grades = new List<int>();
            }

            this.grades.AddRange(value);
        }
    }

    public Student(string name, int age, List<int> grades)
    {
        this.Name = name;
        this.Age = age;
        this.Grades = grades;
    }
}
