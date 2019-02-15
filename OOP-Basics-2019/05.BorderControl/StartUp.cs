namespace _05.BorderControl
{
    using Contracts;
    using Models;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        private static List<IBuyer> list;

        public static void Main()
        {
            ReadInput();

            var totalBoughtFood = CalculateFood();

            Console.WriteLine(totalBoughtFood);
        }

        private static int CalculateFood()
        {
            BuyFood();

            var result = list.Sum(b => b.Food);

            return result;
        }

        private static void BuyFood()
        {
            string command;
            while ((command = Console.ReadLine()) != "End")
            {
                var buyer = list.FirstOrDefault(b => b.Name == command);

                if (buyer != null)
                {
                    buyer.BuyFood();
                }
            }
        }

        private static void ReadInput()
        {
            list = new List<IBuyer>();

            var numberOfLines = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfLines; i++)
            {
                var currLine = Console.ReadLine();

                list.Add(Parse(currLine));
            }
        }

        private static IBuyer Parse(string command)
        {
            var arr = command.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var name = arr[0];
            var age = int.Parse(arr[1]);

            if (arr.Length == 3)
            {
                var group = arr[2];

                return new Rebel(name, age, group);
            }

            var id = arr[2];
            var birthdate = arr[3];

            return new Citizen(name, age, id, birthdate);
        }
    }
}
