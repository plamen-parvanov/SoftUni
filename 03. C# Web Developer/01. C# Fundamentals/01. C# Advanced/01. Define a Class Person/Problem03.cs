namespace _01._Define_a_Class_Person
{
    using System;

    public class Problem03
    {
        public static void Main()
        {
            var family = new Family();

            ReadInput(family);

            PrintOldestMember(family);
        }

        private static void ReadInput(Family family)
        {
            var personNumber = int.Parse(Console.ReadLine());


            for (int i = 0; i < personNumber; i++)
            {
                var personInfo = Console.ReadLine().Split();
                var name = personInfo[0];
                var age = int.Parse(personInfo[1]);
                var currPerson = new Person(name, age);

                family.AddMember(currPerson);
            }
        }

        private static void PrintOldestMember(Family family)
        {
            var oldestMember = family.GetOldestMember();
            var name = oldestMember.Name;
            var age = oldestMember.Age;

            Console.WriteLine($"{name} {age}");
        }
    }
}
