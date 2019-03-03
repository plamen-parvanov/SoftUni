namespace ConsoleApp1
{
    using Core;

    public class StartUp
    {
        public static void Main(string[] args)
        {
            var commandInterpreter = new CommandInterpreter(); 

            var engine = new Engine(commandInterpreter);

            engine.Run();
        }
    }
}
