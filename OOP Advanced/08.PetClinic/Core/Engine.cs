namespace _08.PetClinic.Core
{
    using System;
    using System.Linq;

    public class Engine
    {
        private readonly CommandInterpreter commandInterpreter;

        public Engine(CommandInterpreter commandInterpreter)
        {
            this.commandInterpreter = commandInterpreter;
        }

        public void Run()
        {
            var n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var inputLine = Console.ReadLine();

                Execute(inputLine);
            }
        }

        private void Execute(string input)
        {
            var inputArr = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var command = inputArr[0];
            var args = inputArr.Skip(1).ToArray();

            try
            {
                switch (command)
                {
                    case "Create":
                        Create(args);
                        break;
                    case "Add":
                        Add(args);
                        break;
                    case "Release":
                        Release(args);
                        break;
                    case "HasEmptyRooms":
                        HasEmptyRooms(args);
                        break;
                    case "Print":
                        Print(args);
                        break;
                }
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void Print(string[] args)
        {
            var clinicName = args[0];

            if (args.Length > 1)
            {
                var room = int.Parse(args[1]);
                this.commandInterpreter.Print(clinicName, room);
            }
            else
            {
                this.commandInterpreter.Print(clinicName);
            }
        }

        private void HasEmptyRooms(string[] args)
        {
            var clinicName = args[0];

            Console.WriteLine(this.commandInterpreter.HasEmptyRooms(clinicName));
        }

        private void Release(string[] args)
        {
            var clinicName = args[0];

            Console.WriteLine(this.commandInterpreter.Release(clinicName));
        }

        private void Add(string[] args)
        {
            var petName = args[0];
            var clinicName = args[1];

            try
            {
                Console.WriteLine(this.commandInterpreter.Add(petName, clinicName));

            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        private void Create(string[] args)
        {
            var name = args[1];

            if (args.Count() == 4)
            {
                var age = int.Parse(args[2]);
                var kind = args[3];
                this.commandInterpreter.CreatePet(name, age, kind);
            }
            else
            {
                var rooms = int.Parse(args[2]);
                try
                {
                    this.commandInterpreter.CreateClinic(name, rooms);
                }
                catch (InvalidOperationException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}
