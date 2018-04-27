namespace _04.Average_Grades
{
    using System.Collections.Generic;
    using System.Linq;

    public class Student
    {
        public string Name { get; set; }

        public List<double> Grade { get; set; }

        public double AverageGrade
        {
            get { return Grade.Average(); }
        }

    }
}
