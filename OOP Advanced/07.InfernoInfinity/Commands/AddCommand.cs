namespace _07.InfernoInfinity.Commands
{
    using Data.Contracts;

    public class AddCommand : Command
    {
        public AddCommand(IRepository repository, string weaponName, int socketIndex,
            string gemType) : base(repository)
        {

        }

        public override string Execute()
        {
            this.Repository.
            return null;
        }
    }
}
