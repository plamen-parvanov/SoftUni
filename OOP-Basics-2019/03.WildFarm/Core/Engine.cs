namespace _03.WildFarm.Core
{
    using Models.Animals.Birds;
    using Models.Animals;
    using System;
    using System.Collections.Generic;
    using System.Text;
    using Models.Animals.Mammals;
    using Models.Animals.Mammals.Felines;
    using Models.Foods;

    public class Engine
    {
        private static List<Animal> animals;
        private static StringBuilder output;

        public Engine()
        {
            animals = new List<Animal>();
            output = new StringBuilder();
        }

        public void Run()
        {
            ReadInput();

            PrintResult();
        }

        private void PrintResult()
        {
            animals.ForEach(a => output.AppendLine(a.ToString()));

            Console.WriteLine(output.ToString().TrimEnd());
        }

        private void ReadInput()
        {
            string inputLine;
            while ((inputLine = Console.ReadLine()) != "End")
            {
                var currentAnimal = CreateAnimal(inputLine);

                animals.Add(currentAnimal);

                output.AppendLine(currentAnimal.ProduceSound());

                var currentFood = CreateFood(Console.ReadLine());

                try
                {
                    currentAnimal.FeedAnimal(currentFood);
                }
                catch (ArgumentException ex)
                {
                    output.AppendLine(ex.Message);
                }
            }
        }

        private Food CreateFood(string input)
        {
            var args = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var type = args[0];
            var quantity = int.Parse(args[1]);

            switch (type)
            {
                case "Vegetable":
                    return new Vegetable(type, quantity);
                case "Fruit":
                    return new Fruit(type, quantity);
                case "Meat":
                    return new Meat(type, quantity);
                case "Seeds":
                    return new Seeds(type, quantity);
                default:
                    throw new ArgumentException();
            }
        }

        private Animal CreateAnimal(string inputLine)
        {
            var args = inputLine.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var type = args[0];

            switch (type)
            {
                case "Owl":
                    return new Owl(args[1], double.Parse(args[2]), double.Parse(args[3]));
                case "Hen":
                    return new Hen(args[1], double.Parse(args[2]), double.Parse(args[3]));
                case "Mouse":
                    return new Mouse(args[1], double.Parse(args[2]), args[3]);
                case "Dog":
                    return new Dog(args[1], double.Parse(args[2]), args[3]);
                case "Cat":
                    return new Cat(args[1], double.Parse(args[2]), args[3], args[4]);
                case "Tiger":
                    return new Tiger(args[1], double.Parse(args[2]), args[3], args[4]);
                default:
                    throw new ArgumentException();
            }
        }
    }
}
