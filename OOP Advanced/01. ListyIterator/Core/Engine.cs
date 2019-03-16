namespace _01._ListyIterator.Core
{
    using System;
    using System.Linq;
    using System.Text;

    public class Engine
    {
        private ListyIterator<string> listyIterator;

        public void Run()
        {
            CreateListyIterator();

            ReadAllCommands();
        }

        private void ReadAllCommands()
        {
            string command;

            while ((command = Console.ReadLine()) != "END")
            {
                try
                {
                    Execute(command);
                }
                catch (InvalidOperationException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        private void Execute(string command)
        {
            switch (command)
            {
                case "Move":
                    Console.WriteLine(this.listyIterator.Move());
                    break;
                case "HasNext":
                    Console.WriteLine(this.listyIterator.HasNext());
                    break;
                case "Print":
                    this.listyIterator.Print();
                    break;
                case "PrintAll":
                    PrintAll();
                    break;
                }
        }

        private void PrintAll()
        {
            var sb = new StringBuilder();

            foreach (var element in this.listyIterator)
            {
                sb.Append($"{element} ");
            }

            Console.WriteLine(sb.ToString().TrimEnd());
        }

        private void CreateListyIterator()
        {
            var args = Console.ReadLine()
               .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
               .Skip(1)
               .ToArray();

            this.listyIterator = new ListyIterator<string>(args);
        }
    }
}
