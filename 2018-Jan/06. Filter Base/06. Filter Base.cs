namespace _06.Filter_Base
{

    using System;
    using System.Collections.Generic;

    public class Problem06
    {

        public static void Main()
        {
            var ageDict = new Dictionary<string, int>();
            var positionDict = new Dictionary<string, string>();
            var salaryDict = new Dictionary<string, double>();

            while (true)
            {
                var inputLine = Console.ReadLine();
                if (inputLine == "filter base")
                {
                    break;
                }

                var arr = inputLine.Split(new[] { ' ', '-', '>' }, StringSplitOptions.RemoveEmptyEntries);
                var name = arr[0];

                int age;
                double salary;

                if (int.TryParse(arr[1], out age))
                {
                    ageDict[name] = age;
                }
                else if (double.TryParse(arr[1], out salary))
                {
                    salaryDict[name] = salary;
                }
                else
                {
                    positionDict[name] = arr[1];
                }

            }

            var info = Console.ReadLine();

            switch (info)
            {
                case "Age":
                    PrintResult(ageDict);
                    break;
                case "Salary":
                    PrintResult(salaryDict);
                    break;
                case "Position":
                    PrintResult(positionDict);
                    break;
            }

        }

        public static void PrintResult(Dictionary<string, int> dict)
        {
            foreach (var kvp in dict)
            {
                Console.WriteLine($"Name: {kvp.Key}");
                Console.WriteLine($"Age: {kvp.Value}");
                Console.WriteLine(new string('=', 20));
            }
        }

        public static void PrintResult(Dictionary<string, double> dict)
        {
            foreach (var kvp in dict)
            {
                Console.WriteLine($"Name: {kvp.Key}");
                Console.WriteLine($"Salary: {kvp.Value:f2}");
                Console.WriteLine(new string('=', 20));
            }
        }

        public static void PrintResult(Dictionary<string, string> dict)
        {
            foreach (var kvp in dict)
            {
                Console.WriteLine($"Name: {kvp.Key}");
                Console.WriteLine($"Position: {kvp.Value}");
                Console.WriteLine(new string('=', 20));
            }
        }
    }
}
