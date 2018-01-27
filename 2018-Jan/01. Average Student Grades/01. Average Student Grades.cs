namespace _01.Average_Student_Grades
{

    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Problem01
    {

        public static void Main()
        {
           
            var dict = new Dictionary<string, List<double>>();

            AddingGrades(dict);

            PrintGrades(dict);

        }

        public static void AddingGrades(Dictionary<string, List<double>> dict)
        {
            var n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var lineArr = Console.ReadLine()
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                var name = lineArr[0];
                var grade = double.Parse(lineArr[1]);

                if (!dict.ContainsKey(name))
                {
                    dict[name] = new List<double>();
                }

                dict[name].Add(grade);
            }
        }

        public static void PrintGrades(Dictionary<string, List<double>> dict)
        {
            foreach (var kvp in dict)
            {
                var name = kvp.Key;
                var average = kvp.Value.Average();

                Console.Write($"{name} -> ");

                foreach (var grade in kvp.Value)
                {
                    Console.Write($"{grade:f2} ");
                }

                Console.WriteLine($"(avg: {average:f2})");
            }
        }
    }
}
