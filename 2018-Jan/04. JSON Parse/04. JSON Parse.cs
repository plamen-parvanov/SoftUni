using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.JSON_Parse
{
    public class Problem04
    {
        public static List<Student> list;

        public static void Main()
        {
            list = new List<Student>();

            ReadInputLine();

            PrintAllStudentsInfo();
        }

        public static void ReadInputLine()
        {
            var input = Console.ReadLine();
            var studentsArr = input.Remove(input.Length - 2, 2).Remove(0, 2)
                .Split(new[] { "},{" }, StringSplitOptions.RemoveEmptyEntries);

            foreach (var student in studentsArr)
            {
                Add(student);
            }
        }

        public static void Add(string student)
        {
            var splited = student.Split(new[] { "name:\"", "\",age:", ",grades:[", "]" }, StringSplitOptions.RemoveEmptyEntries);

            var name = splited[0];
            var age = int.Parse(splited[1]);
            List<int> grades;
            if (splited.Length > 2)
            {
                grades = splited[2]
                .Split(new[] { "," }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            }
            else
            {
                grades = null;
            }
            

            list.Add(new Student(name, age, grades));
        }

        public static void PrintAllStudentsInfo()
        {
            foreach (var student in list)
            {
                var name = student.Name;
                var age = student.Age;
                var grades = student.Grades.Count == 0 
                    ? "None" 
                    : string.Join(", ", student.Grades);

                Console.WriteLine($"{name} : {age} -> {grades}");

            }
        }
    }
}
