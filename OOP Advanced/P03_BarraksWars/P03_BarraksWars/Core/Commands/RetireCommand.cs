using _03BarracksFactory.Contracts;

namespace _03BarracksFactory.Core.Commands
{
    public class RetireCommand : Command
    {
        [Inject]
        private IRepository repository;

        public RetireCommand(string[] data, IRepository repository) 
            : base(data)
        {
            this.Repository = repository;
        }

        public IRepository Repository
        {
            get
            {
                return this.repository;
            }
            private set
            {
                this.repository = value;
            }
        }

        public override string Execute()
        {
            var unitType = this.Data[1];          

            this.Repository.RemoveUnit(unitType);

            return unitType + " retired!";
        }
    }
}
