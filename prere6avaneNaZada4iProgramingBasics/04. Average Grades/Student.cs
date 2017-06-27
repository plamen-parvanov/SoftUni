namespace _04.Average_Grades
{
    using System.Collections.Generic;
    using System.Linq;

    public class Student
    {
        public Student()
        {
            this.grades = new List<double>();
        }

        public string name;
        public List<double> grades;
    
        public double AverageGrade()
        {
           // get { return Grade.Average(); }    bez skobite() na metoda

            return this.grades.Average();
        }

    }
}
