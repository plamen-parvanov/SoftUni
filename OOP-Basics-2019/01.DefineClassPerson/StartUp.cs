﻿using System;

namespace DefiningClasses
{
    public class StartUp
    {
        public static void Main()
        {
            ReadInput();

            PrintResult();
        }

        private static void PrintResult()
        {
            var oldestMember = Family.GetOldestMember();

            Console.WriteLine(oldestMember.ToString());
        }

        private static void ReadInput()
        {
            var numberOfLines = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfLines; i++)
            {
                var inputArr = Console.ReadLine()
                    .Split(new[] { ' '}, StringSplitOptions.RemoveEmptyEntries);

                var name = inputArr[0];
                var age = int.Parse(inputArr[1]);

                var person = new Person(name, age);

                Family.AddMember(person);

            }
        }
    }
}
