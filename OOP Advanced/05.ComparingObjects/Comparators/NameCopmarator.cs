namespace _05.ComparingObjects.Comparators
{
    using System.Collections.Generic;

    using Models;

    public class NameCopmarator : IComparer<Person>
    {
        public int Compare(Person firstPerson, Person secondPerson)
        {
            var result = firstPerson.Name.Length.CompareTo(secondPerson.Name.Length);

            if (result == 0)
            {
                result = firstPerson.Name.ToLower()[0].CompareTo(secondPerson.Name.ToLower()[0]);
            }

            return result;
        }
    }
}
