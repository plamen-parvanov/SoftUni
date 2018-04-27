namespace _05.Filter_By_Age
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Problem05
    {
        private static List<Person> list;
        public static void Main()
        {
            AddPersonsInList();

            ExecuteFilterByAge();

            Print();
        }

        private static void AddPersonsInList()
        {
            var personCount = int.Parse(Console.ReadLine());

            list = new List<Person>(personCount);

            for (int person = 0; person < personCount; person++)
            {
                var inputLine = Console.ReadLine()
                    .Split(new[] { ", " }, StringSplitOptions.RemoveEmptyEntries);
                var currName = inputLine[0];
                var currAge = int.Parse(inputLine[1]);
                var currPerson = new Person(currName, currAge);

                list.Add(currPerson);
            }
        }

        private static void ExecuteFilterByAge()
        {
            var filter = CreateFilter();         

            list = list.Where(filter).ToList();
        }

        private static Func<Person, bool> CreateFilter()
        {
            var filter = Console.ReadLine();
            var age = int.Parse(Console.ReadLine());

            if (filter == "younger")
            {
                return p => p.Age < age;
            }

            return p => p.Age >= age;
        }

        private static void Print()
        {
            var printer = CreatePrinter();

            list.ForEach(printer);
        }

        private static Action<Person> CreatePrinter()
        {
            var format = Console.ReadLine();

            switch (format)
            {
                case "name":
                    return p => Console.WriteLine(p.Name);

                case "age":
                    return p => Console.WriteLine(p.Age);

                default :
                    return p => Console.WriteLine($"{p.Name} - {p.Age}");
            }
        }
    }
}
