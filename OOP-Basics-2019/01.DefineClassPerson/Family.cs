using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    public static class Family
    {
        private static List<Person> members = new List<Person>();

        public static void AddMember(Person member)
        {
            members.Add(member);
        }

        public static Person GetOldestMember()
        {
            var result = members.OrderByDescending(m => m.Age).FirstOrDefault();
                return result;
        }

    }
}
