namespace _10.ExplicitInterfaces.Controllers
{
    using Contracts;
    using Models;
    using System;
    using System.Collections.Generic;

    public class Engine
    {
        private readonly List<Citizen> citizens;

        public Engine()
        {
            this.citizens = new List<Citizen>();
        }

        public void Run()
        {
            ReadInput();

            PrintResult();
        }

        private void PrintResult()
        {
            foreach (var citizen in this.citizens)
            {
                Console.WriteLine(((IPerson)citizen).GetName());

                Console.WriteLine(((IResident)citizen).GetName());
            }
        }

        private void ReadInput()
        {
            string input;
            while ((input = Console.ReadLine()) != "End")
            {
                var args = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                var name = args[0];
                var country = args[1];
                var age = int.Parse(args[2]);

                var citizen = new Citizen(name, age, country);

                this.citizens.Add(citizen);
            }
        }
    }
}
