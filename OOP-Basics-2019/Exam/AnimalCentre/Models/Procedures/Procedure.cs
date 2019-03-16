namespace AnimalCentre.Models.Procedures
{
    using System.Collections.Generic;
    using System.Text;
    using Contracts;

    public abstract class Procedure : IProcedure
    {
        public Procedure()
        {
            this.ProcedureHistory = new List<IAnimal>();
        }

        protected  List<IAnimal> ProcedureHistory { get; private set; }

        public abstract void DoService(IAnimal animal, int procedureTime);

        public string History()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"{this.GetType().Name}");

            this.ProcedureHistory.ForEach(a => sb.AppendLine(a.ToString()));

            return sb.ToString().TrimEnd();
        }
    }
}
