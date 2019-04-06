namespace _07.InfernoInfinity.Commands
{
    using Commands.Contracts;
    using Data.Contracts;

    public abstract class Command : IExecutable
    {
        protected Command(IRepository repository)
        {
            this.Repository = repository;
        }

        public IRepository Repository {get; set;}

        public abstract string Execute();
    }
}
