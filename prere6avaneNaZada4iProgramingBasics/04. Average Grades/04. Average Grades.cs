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

            AddingNewStudentsNameAdnGrades(numSudents, students);

            PrintStudentsOrderByNameThenByGrade(students);

            

        }

        public static void AddingNewStudentsNameAdnGrades(int numSudents, List<Student> students)
        {
            for (int i = 0; i < numSudents; i++)
            {
                var student = new Student();
                var studentInfo = Console.ReadLine().Split();
                student.name = studentInfo[0];

                for (int j = 1; j < studentInfo.Length; j++)
                {
                    student.grades.Add(double.Parse(studentInfo[j]));
                }

                students.Add(student);
            }
        }

        public static void PrintStudentsOrderByNameThenByGrade(List<Student> students)
        {
            students = students.OrderBy(s => s.name).ThenByDescending(s => s.AverageGrade()).ToList();

            foreach (Student student in students.Where(s => s.AverageGrade() >= 5))
            {
                Console.WriteLine($"{student.name} -> {student.AverageGrade():F2}");
            }

        }
    }
}
