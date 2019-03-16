namespace _07._Custom_List
{
    using Core;
    using CustomLists;

    public class StartUp
    {
        public static void Main()
        {
            var list = new CustomList<string>();

            var comandInterpreter = new CommandInterpreter<string>(list);

            var engine = new Engine<string>(comandInterpreter);

            engine.Run();

        }
    }
}
