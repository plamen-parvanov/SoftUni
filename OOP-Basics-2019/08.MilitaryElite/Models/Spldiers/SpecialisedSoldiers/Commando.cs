namespace _08.MilitaryElite.Models.Spldiers.SpecialisedSoldiers
{
    using Models.Missions;
    using System.Collections.Generic;
    using System.Text;

    public class Commando : SpecialisedSoldier
    {
        private IReadOnlyCollection<Mission> missions;

        public Commando(string id, string firstName, string lastName, 
            decimal salary, string corp, IReadOnlyCollection<Mission> missions)
            : base(id, firstName, lastName, salary, corp)
        {
            this.missions = missions;
        }

        public override string ToString()
        {
            var sb = new StringBuilder();

            sb.AppendLine(base.ToString());
            sb.AppendLine("Missions:");

            foreach (var mission in this.missions)
            {
                sb.AppendLine(mission.ToString());
            }

            return sb.ToString().TrimEnd();
        }
    }
}
