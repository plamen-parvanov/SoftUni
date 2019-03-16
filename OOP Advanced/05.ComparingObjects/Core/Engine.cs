namespace _05.ComparingObjects.Core
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using Models;
    using Comparators;

    public class Engine
    {
        private readonly IList<Person> data;
        private readonly SortedSet<Person> nameSorted;
        private readonly SortedSet<Person> ageSorted;
        private readonly SortedSet<Person> sortedSet;
        private readonly HashSet<Person> hashSet;

        public Engine()
        {
            this.data = new List<Person>();
            this.nameSorted = new SortedSet<Person>(new NameCopmarator());
            this.ageSorted = new SortedSet<Person>(new AgeComparator());
            this.sortedSet = new SortedSet<Person>();
            this.hashSet = new HashSet<Person>();
        }

        public void Run()
        {
            ReadInput();

            Print();

            //Print(this.nameSorted);

           // Print(this.ageSorted);

            // var result = GetComparisonResult();

            // Print(result);
        }

        private void Print()
        {
            Console.WriteLine(this.sortedSet.Count);
            Console.WriteLine(this.hashSet.Count);
        }

        private void Print(SortedSet<Person> sortedSet)
        {
            var result = string.Join(Environment.NewLine, sortedSet);

            Console.WriteLine(result);
        }

        private void Print(string result)
        {
            Console.WriteLine(result);
        }

        private string GetComparisonResult()
        {
            var personToCompare = GetPerson();

            var totalPeopleCount = this.data.Count;

            var equalPeopleNumber = this.data.Where(p => p.CompareTo(personToCompare) == 0).Count();

            var notEqualPeopleNumber = totalPeopleCount - equalPeopleNumber;

            string result;

            if (equalPeopleNumber == 1)
            {
                result = "No matches";
            }
            else
            {
                result = $"{equalPeopleNumber} {notEqualPeopleNumber} {totalPeopleCount}";
            }

            return result;
        }

        private Person GetPerson()
        {
            var index = int.Parse(Console.ReadLine());
            var person = this.data[--index];

            return person;
        }

        private void ReadInput()
        {
            var inputLines = int.Parse(Console.ReadLine());
            for (int i = 0; i < inputLines; i++)
            {
                var inputLine = Console.ReadLine();

                var args = inputLine.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                var currentPerson = CreatePerson(args);

                this.sortedSet.Add(currentPerson);
                this.hashSet.Add(currentPerson);
            }

            //string inputLine;
            //while ((inputLine = Console.ReadLine()) != "END")
            //{


            //    this.data.Add(currentPerson);
            //}
        }

        private Person CreatePerson(string[] args)
        {
            var name = args[0];
            var age = int.Parse(args[1]);
            // var town = args[2];

            var person = new Person(name, age);

            return person;
        }
    }
}
