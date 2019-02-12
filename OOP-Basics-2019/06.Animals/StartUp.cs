namespace _06.Animals
{
    using _06.Animals.Animals;
    using _06.Animals.Factories;
    using System;
    using System.Collections.Generic;

    public class StartUp
    {
        private static List<Animal> animals;

        public static void Main()
        {
            ReadInput();

            PrintResult();

        }

        private static void PrintResult()
        {
            animals.ForEach(a => Console.WriteLine(a.ToString()));
        }

        private static void ReadInput()
        {
            animals = new List<Animal>();

            string inputLine;
            while ((inputLine = Console.ReadLine()) != "Beast!")
            {
                var info = Console.ReadLine();

                try
                {
                    var currentAnimal = AnimalFactory.CreateAnimal(inputLine, info);

                    animals.Add(currentAnimal);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}
