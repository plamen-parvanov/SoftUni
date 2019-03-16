namespace _05.ComparingObjects.Comparators
{
    using System.Collections.Generic;

    using Models;

    class AgeComparator : IComparer<Person>
    {
        public int Compare(Person firstPerson, Person secondPerson)
        {
            var result = firstPerson.Age.CompareTo(secondPerson.Age);

            return result;
        }
    }
}
