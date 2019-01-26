using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    public class StartUp
    {
        private static List<Person> persons;
        public static void Main()
        {
            ReadInput();

            PrintResult();
        }

        private static void PrintResult()
        {
            persons.Where(m => m.Age > 30)
                   .OrderBy(m => m.Name)
                   .ToList()
                   .ForEach(m => Console.WriteLine(m.ToString()));
        }

        private static void ReadInput()
        {
            persons = new List<Person>();

            var numberOfLines = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfLines; i++)
            {
                var inputArr = Console.ReadLine()
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                var name = inputArr[0];
                var age = int.Parse(inputArr[1]);
                var person = new Person(name, age);

                persons.Add(person);
            }
        }
    }
}
