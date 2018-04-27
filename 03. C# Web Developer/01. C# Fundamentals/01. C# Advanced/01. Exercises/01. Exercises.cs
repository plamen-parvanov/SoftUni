using System;
using System.Collections.Generic;

namespace _01.Exercises
{
    public class Problem01
    {
        static List<Exercise> list;
        public static void Main()
        {
            list = new List<Exercise>();

            ReadInput();

            PrintResult();
        }

        public static void ReadInput()
        {
            while (true)
            {
                var inputLine = Console.ReadLine();
                if (inputLine == "go go go")
                {
                    break;
                }

                ReadLine(inputLine);
            }
        }

        public static void ReadLine(string inputLine)
        {
            //{topic} -> {courseName} -> {judgeContestLink} -> {problem1}, {problem2}. 
            var arr = inputLine.Split(new[] { " -> " }, StringSplitOptions.RemoveEmptyEntries);
            var topic = arr[0];
            var courseName = arr[1];
            var judgeContestLink = arr[2];
            var problems = arr[3].Split(new[] { ", "}, StringSplitOptions.RemoveEmptyEntries);

            list.Add(new Exercise(topic, courseName, judgeContestLink, problems));
        }

        public static void PrintResult()
        {
            foreach (var ex in list)
            {
                Console.WriteLine($"Exercises: {ex.Topic}");
                Console.WriteLine($"Problems for exercises and homework for the \"{ex.CourseName}\" course @ SoftUni.");
                Console.WriteLine($"Check your solutions here: {ex.JudgeContestLink}");

                for (int i = 0; i < ex.Problems.Length; i++)
                {
                    var problem = ex.Problems[i];
                    Console.WriteLine($"{i + 1}. {problem}");
                }
            }
        }
    }
}
