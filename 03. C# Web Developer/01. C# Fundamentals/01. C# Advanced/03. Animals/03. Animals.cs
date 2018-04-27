using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.Animals
{
    public class Problem03
    {
        static List<Dog> dogs;
        static List<Cat> cats;
        static List<Snake> snakes;

        public static void Main()
        {
            ReadAllInput();

            PrintResult();
        }

        public static void ReadAllInput()
        {
            while (true)
            {
                var input = Console.ReadLine();
               
                if (input == "I'm your Huckleberry")
                {
                    break;
                }

                var inputLineArr = input
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                if (inputLineArr[0] == "talk")
                {
                    Talk(inputLineArr[1]);
                }
                else
                {
                    AddAnimal(inputLineArr);
                }

                
            }
        }

        public static void AddAnimal(string[] arr)
        {
            //{class} {name} {age} {parameter}
            var animalClass = arr[0];
            var name = arr[1];
            var age = int.Parse(arr[2]);
            var parameter = int.Parse(arr[3]);

            switch (animalClass)
            {
                case "Dog":
                    if (dogs == null)
                    {
                        dogs = new List<Dog>();
                    }
     
                    dogs.Add(new Dog(name, age, parameter));
                    break;

                case "Cat":
                    if (cats == null)
                    {
                        cats = new List<Cat>();
                    }

                    cats.Add(new Cat(name, age, parameter));
                    break;

                case "Snake":
                    if (snakes == null)
                    {
                        snakes = new List<Snake>();
                    }

                    snakes.Add(new Snake(name, age, parameter));
                    break;
            }
        }

        public static void Talk(string animalName)
        {
            if (dogs != null)
            {
                var isDog = dogs.Select(x => x.Name.ToString()).Contains(animalName);
                if (isDog)
                {
                    dogs[0].ProduceSound();
                }
            }
            if (cats != null)
            {
                var isCat = cats.Select(x => x.Name.ToString()).Contains(animalName);
                if (isCat)
                {
                    cats[0].ProduceSound();
                }
            }
            if (snakes != null)
            {
                var isSnake = snakes.Select(x => x.Name.ToString()).Contains(animalName);
                if (isSnake)
                {
                    snakes[0].ProduceSound();
                }
            }

        }

        public static void PrintResult()
        {
            if (dogs != null)
            {
                Print(dogs);
            }
            if (cats != null)
            {
                Print(cats);
            }
            if (snakes != null)
            {
                Print(snakes);
            }
        }

        public static void Print(List<Dog> list)
        {
            foreach (var dog in list)
            {
                Console.WriteLine($"Dog: {dog.Name}, Age: {dog.Age}, Number Of Legs: {dog.NumberOfLegs}");
            }
        }

        public static void Print(List<Cat> list)
        {
            list.ForEach(x => Console.WriteLine($"Cat: {x.Name}, Age: {x.Age}, IQ: {x.IntelligenceQuotient}"));

        }

        public static void Print(List<Snake> list)
        {
            list.ForEach(x => Console.WriteLine($"Snake: {x.Name}, Age: {x.Age}, Cruelty: {x.CrueltyCoefficient}"));
        }
    }
}
