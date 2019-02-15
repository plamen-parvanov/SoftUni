namespace _08.MilitaryElite.Models
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class LieutenantGeneral : Private
    {
        private IReadOnlyCollection<Private> privates;

        public LieutenantGeneral(string id, string firstName, string lastName, 
            decimal salary, IReadOnlyCollection<Private> privates)
            : base(id, firstName, lastName, salary)
        {
            this.privates = privates;
        }

        public override string ToString()
        {
            var sb = new StringBuilder();

            sb.AppendLine(base.ToString());
            sb.AppendLine("Privates:");

            foreach (var @private in this.privates)
            {
                sb.AppendLine($"  {@private.ToString()}");
            }

            return sb.ToString().TrimEnd();
        }
    }
}
