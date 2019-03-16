namespace ConsoleApp1.Core
{
    using System;

    using Contracts;

    public class Engine : IEngine

    {
        private CommandInterpreter commandInterpreter;

        public Engine(CommandInterpreter commandInterpreter)
        {
            this.commandInterpreter = commandInterpreter;
        }

        public void Run()
        {
            ReadAppenders();

            ReadMessages();

            PrintResult();
        }

        private void PrintResult()
        {
            Console.WriteLine("Logger info");
            Console.WriteLine(this.commandInterpreter.AppendersInfo());
        }

        private void ReadMessages()
        {
            string command;
            while ((command = Console.ReadLine()) != "END")
            {
                var args = command.Split(new[] { '|' }, StringSplitOptions.RemoveEmptyEntries);

                this.commandInterpreter.AddMessage(args);
            }
        }

        private void ReadAppenders()
        {
            var n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var inputLine = Console.ReadLine();
                var args = inputLine.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                this.commandInterpreter.AddAppender(args);
            }
        }
    }
}
