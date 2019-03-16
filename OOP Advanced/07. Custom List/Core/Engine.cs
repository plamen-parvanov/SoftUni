namespace _07._Custom_List.Core
{
    using System;

    public class Engine<T>
    {
        private readonly CommandInterpreter<T> commandInterpreter;

        public Engine(CommandInterpreter<T> commandInterpreter)
        {
            this.commandInterpreter = commandInterpreter;
        }

        public void Run()
        {
            string inputLine;
            while ((inputLine = Console.ReadLine()) != "END")
            {
                Execute(inputLine);
            }
        }

        private void Execute(string input)
        {
            var arr = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var command = arr[0];

            switch (command)
            {
                case "Add":
                    this.commandInterpreter.Add(arr[1]);
                    break;

                default:
                    break;
            }
        }
    }
}
