namespace _04.Average_Grades
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class ObjectsAndClasses
    {

        public static void Main()
        {
            var numSudents = int.Parse(Console.ReadLine());

            var students = new List<Student>();

            for (int i = 0; i < numSudents; i++)
            {
                var studentInfo = Console.ReadLine().Split();                
                var grades = new List<double>();

                for (int j = 1; j < studentInfo.Length; j++)
                {
                    grades.Add(double.Parse(studentInfo[j]));
                }

                var student = new Student();
                student.Name = studentInfo[0];
                student.Grade = grades;
                students.Add(student);
            }

            students = students.OrderBy(s => s.Name).ThenByDescending(s => s.AverageGrade).ToList();

            foreach (Student student in students.Where(s => s.AverageGrade >= 5))
            {
                Console.WriteLine($"{student.Name} -> {student.AverageGrade:F2}");
            }

        }
    }
}
