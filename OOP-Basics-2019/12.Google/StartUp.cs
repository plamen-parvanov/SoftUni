namespace _12.Google
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Units;

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
            var personName = Console.ReadLine();
            var person = persons.FirstOrDefault(p => p.Name == personName);

            Console.WriteLine(person.ToString());
        }

        private static void ReadInput()
        {
            persons = new List<Person>();

            string command;
            while ((command = Console.ReadLine()) != "End")
            {
                var arr = command.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                ExecuteCommand(arr);
            }
        }

        private static void ExecuteCommand(string[] arr)
        {
            var name = arr[0];
            Person person = persons.FirstOrDefault(p => p.Name == name);

            if (person == null)
            {
                person = new Person(name);
                persons.Add(person);
            }

            AddInformation(person, arr);

        }

        private static void AddInformation(Person person, string[] arr)
        {
            var information = arr[1];

            switch (information)
            {
                case "company":
                    person.company = CreateCompany(arr);
                    break;
                case "pokemon":
                    person.pokemons.Add(CreatePokemon(arr));
                    break;
                case "parents":
                    person.parents.Add(CreateParent(arr));
                    break;
                case "children":
                    person.children.Add(CreateChild(arr));
                    break;
                case "car":
                    person.car = CreateCar(arr);
                    break;
                default:
                    break;
            }
        }

        private static Car CreateCar(string[] arr)
        {
            var model = arr[2];
            var speed = int.Parse(arr[3]);

            return new Car(model, speed);
        }

        private static Child CreateChild(string[] arr)
        {
            var name = arr[2];
            var birthDay = arr[3];

            return new Child(name, birthDay);
        }

        private static Parent CreateParent(string[] arr)
        {
            var name = arr[2];
            var birthday = arr[3];

            return new Parent(name, birthday);
        }

        private static Pokemon CreatePokemon(string[] arr)
        {
            var name = arr[2];
            var type = arr[3];

            return new Pokemon(name, type);
        }

        private static Company CreateCompany(string[] arr)
        {
            var name = arr[2];
            var department = arr[3];
            var salary = decimal.Parse(arr[4]);

            return new Company(name, department, salary);
        }
    }
}
