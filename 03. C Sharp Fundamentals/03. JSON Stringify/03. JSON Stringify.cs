namespace _03.JSON_Stringify
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Problem03
    {
        public static List<Student> students;
        public static void Main()
        {
            students = new List<Student>();

            ReadAllInput();

            PrintStudents();
        }

        public static void ReadAllInput()
        {
            while (true)
            {
                var inputLine = Console.ReadLine();
                if (inputLine == "stringify")
                {
                    break;
                }

                ReadLine(inputLine);
            }
        }

        public static void ReadLine(string input)
        {
            var delimiter = " :->,".ToCharArray();
            var arr = input.Split(delimiter, StringSplitOptions.RemoveEmptyEntries);
            var name = arr[0];
            var age = int.Parse(arr[1]);
            var grades = arr.Skip(2).Select(int.Parse).ToList();           

            students.Add(new Student(name, age, grades));
        }

        public static void PrintStudents()
        {
            Console.WriteLine("[" 
                + string.Join(",", students
                            .Select(st => string.Format("{{name:\"{0}\",age:{1},grades:[{2}]}}",
                             st.Name, st.Age, string.Join(", ", st.Grades))))
                + "]");       
        }
    }
}
