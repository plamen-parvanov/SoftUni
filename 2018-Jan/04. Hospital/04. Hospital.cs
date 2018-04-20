namespace _04.Hospital
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Problem04
    {
        private static Dictionary<string, List<string>> departments;
        private static Dictionary<string, List<string>> doctors;
        public static void Main()
        {
            ReadInput();

            PrintResult();
        }

        private static void ReadInput()
        {
            departments = new Dictionary<string, List<string>>();
            doctors = new Dictionary<string, List<string>>();

            while (true)
            {
                var inputLine = Console.ReadLine();
                if (inputLine == "Output")
                {
                    break;
                }

                AddInfoFrom(inputLine);
            }
        }

        private static void AddInfoFrom(string inputLine)
        {
            var arr = inputLine.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var currDepartment = arr[0];
            var currDoctor = arr[1] + " " + arr[2];
            var currPatient = arr[3];

            if (!departments.ContainsKey(currDepartment))
            {
                departments[currDepartment] = new List<string>();
            }
            else if (departments[currDepartment].Count == 60)
            {
                return;
            }

            departments[currDepartment].Add(currPatient);

            if (!doctors.ContainsKey(currDoctor))
            {
                doctors[currDoctor] = new List<string>();
            }

            doctors[currDoctor].Add(currPatient);
        }

        private static void PrintResult()
        {
            while (true)
            {
                var command = Console.ReadLine();
                if (command == "End")
                {
                    break;
                }

                ExecuteCurrent(command);

            }
        }

        private static void ExecuteCurrent(string command)
        {
            if (departments.ContainsKey(command))
            {
                PrintAllPatientsInCurrDepartment(command);
            }
            else if (doctors.ContainsKey(command))
            {
                PrintAllPatientsOfCurrDoctor(command);
            }
            else
            {
                PrintAllPatientsInRoom(command);
            }
        }

        private static void PrintAllPatientsInRoom(string command)
        {
            var arr = command.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var department = arr[0];
            var room = int.Parse(arr[1]);

            departments[department].Skip((room - 1) * 3).Take(3).OrderBy(p => p).ToList().ForEach(p => Console.WriteLine(p));
        }

        private static void PrintAllPatientsOfCurrDoctor(string command)
        {
            doctors[command].OrderBy(p => p).ToList().ForEach(p => Console.WriteLine(p));
        }

        private static void PrintAllPatientsInCurrDepartment(string command)
        {
            departments[command].ForEach(p => Console.WriteLine(p));
        }
    }
}
