namespace _08.MilitaryElite.Models.SpecialisedSoldiers
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using Models.Repairs;

    public class Engineer : SpecialisedSoldier
    {
        private IReadOnlyCollection<Repair> repairs;

        public Engineer(string id, string firstName, string lastName,
            decimal salary, string corp, IReadOnlyCollection<Repair> repairs)
            : base(id, firstName, lastName, salary, corp)
        {
            this.repairs = repairs;
        }

        public override string ToString()
        {
            var sb = new StringBuilder();

            sb.AppendLine(base.ToString());
            sb.AppendLine("Repairs:");

            foreach (var repair in this.repairs)
            {
                sb.AppendLine($"  {repair.ToString()}");
            }

            return sb.ToString().TrimEnd();
        }
    }
}
