namespace _07.InfernoInfinity.Commands
{
    using Data.Contracts;
    using Models.Wepons.Contracts;

    public class CreateCommand : Command
    {
        private IWeapon weapon;

        public CreateCommand(IRepository repository, IWeapon weapon) : base(repository)
        {
            this.weapon = weapon;
        }

        public override string Execute()
        {
            this.Repository.Add(this.weapon);

            return null;
        }
    }
}
