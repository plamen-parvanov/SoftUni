namespace _03BarracksFactory.Contracts
{
    using System;

    public interface ICommandInterpreter
    {
        IExecutable InterpretCommand(string[] data, string commandName);
    }
}
