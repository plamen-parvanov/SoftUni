﻿namespace _08.PetClinic
{
    using Core;

    public class StartUp
    {
        public static void Main()
        {
            var commandInterpreter = new CommandInterpreter();

            var engine = new Engine(commandInterpreter);

            engine.Run();
        }
    }
}
