namespace _13.FamilyTree
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        private static List<string> inputInfo;
        private static List<Person> people;
        private static string mainPersonInfo;
        private static Family members;
        public static void Main()
        {
            ReadInput();

            MakeFamilyConnections();

            PrintFamilyMembers();
        }

        private static void PrintFamilyMembers()
        {
            Console.WriteLine(members.ToString());
        }

        private static void MakeFamilyConnections()
        {
            foreach (var inputLine in inputInfo)
            {
                if (!ThereISConnection(inputLine))
                {
                    continue;
                }

                MakeConnection(inputLine);
            }
        }

        private static void MakeConnection(string input)
        {
            var firstName = members.MainPerson.FirstName;
            var LastName = members.MainPerson.LastName;
            var birthDay = members.MainPerson.BirthDay;
            var arr = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            if (arr.Length == 3)
            {
                if (arr[0] == birthDay)
                {
                    members.AddChild(FindPersonFromBirthDay(arr[2]));
                }
                else
                {
                    members.AddParent(FindPersonFromBirthDay(arr[0]));

                }
            }
            else if (arr.Length == 5)
            {
                if (arr[0] == firstName && arr[1] == LastName)
                {
                    members.AddChild(FindPersonFromName(arr[3], arr[4]));
                }
                else
                {
                    members.AddParent(FindPersonFromName(arr[0], arr[1]));
                }
            }
            else if (char.IsDigit(arr[0][0]))
            {
                if (arr[0] == birthDay)
                {
                    members.AddChild(FindPersonFromName(arr[2], arr[3]));
                }
                else
                {
                    members.AddParent(FindPersonFromBirthDay(arr[0]));

                }
            }
            else
            {
                if (arr[0] == firstName && arr[1] == LastName)
                {
                    members.AddChild(FindPersonFromBirthDay(arr[3]));
                }
                else
                {
                    members.AddParent(FindPersonFromName(arr[0], arr[1]));
                }
            }
        }

        private static Person FindPersonFromBirthDay(string birthDay)
        {
            return people.FirstOrDefault(p => p.BirthDay == birthDay);
        }

        private static Person FindPersonFromName(string firstName, string lastName)
        {
            return people.FirstOrDefault(p => p.FirstName == firstName &&
                                              p.LastName == lastName);
        }

        private static bool ThereISConnection(string inputLine)
        {
            var fullname = members.MainPerson.FirstName + " " +
                           members.MainPerson.LastName;
            var fullNameCheck = inputLine.Contains(fullname);

            var birthDay = members.MainPerson.BirthDay;
            var birhtDayCheck = inputLine.Contains(birthDay);

            return fullNameCheck || birhtDayCheck;
        }

        private static void ReadInput()
        {
            inputInfo = new List<string>();
            people = new List<Person>();
            mainPersonInfo = Console.ReadLine();

            string inputLine;
            while ((inputLine = Console.ReadLine()) != "End")
            {
                Execute(inputLine);
            }

        }

        private static void Execute(string input)
        {
            if (input.Contains('-'))
            {
                inputInfo.Add(input);
            }
            else
            {
                var person = ParsePreson(input);

                if (input.Contains(mainPersonInfo))
                {
                    members = new Family(person);
                }
                else
                {
                    people.Add(person);
                }
            }
        }

        private static Person ParsePreson(string input)
        {
            var arrInfo = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var firstName = arrInfo[0];
            var lastName = arrInfo[1];
            var birthDay = arrInfo[2];

            return new Person(firstName, lastName, birthDay);
        }
    }
}
