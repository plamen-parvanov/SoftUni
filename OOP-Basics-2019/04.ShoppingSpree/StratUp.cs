namespace _04.ShoppingSpree
{
    using _04.ShoppingSpree.Models;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StratUp
    {
        private static List<Product> products;
        private static List<Person> persons;
        public static void Main()
        {
            persons = new List<Person>();
            products = new List<Product>();

            try
            {
                ReadInput("persons");

                ReadInput("products");

                MakePurchase();

                PrintResult();

            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }

        private static void PrintResult()
        {
            persons.ForEach(p => Console.WriteLine(p));
        }
        private static void MakePurchase()
        {
            string command;
            while ((command = Console.ReadLine()) != "END")
            {
                var arr = command.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                var personName = arr[0];
                var person = persons.FirstOrDefault(p => p.Name == personName);
                var productName = arr[1];
                var product = products.FirstOrDefault(p => p.Name == productName);

                Console.WriteLine(person.TryToBuy(product));

            }
        }

        private static void ReadInput(string command)
        {
            var input = Console.ReadLine().Split(new[] { ';' }, StringSplitOptions.RemoveEmptyEntries);

            foreach (var info in input)
            {
                var arr = info.Split(new[] { '=' }, StringSplitOptions.RemoveEmptyEntries);

                if (command == "persons")
                {
                    var person = new Person(arr[0], double.Parse(arr[1]));

                    persons.Add(person);
                }
                else
                {
                    var product = new Product(arr[0], double.Parse(arr[1]));

                    products.Add(product);
                }

            }

        }

    }
}
