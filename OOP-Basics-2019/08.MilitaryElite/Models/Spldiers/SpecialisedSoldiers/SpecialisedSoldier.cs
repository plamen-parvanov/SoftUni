namespace _08.MilitaryElite.Models
{
    using Validators;
    using System.Text;

    public abstract class SpecialisedSoldier : Private
    {
        private string corp;

        public SpecialisedSoldier(string id, string firstName, string lastName,
            decimal salary, string corp) : base(id, firstName, lastName, salary)
        {
            this.Corp = corp; 
        }

        public string Corp
        {
            get
            {
                return this.corp;
            }

            private set
            {
                Validator.ValidateCorps(value);

                this.corp = value;
            }
        }

        public override string ToString()
        {
            var sb = new StringBuilder();

            sb.AppendLine(base.ToString());
            sb.AppendLine($"Corps: {this.Corp}");

            return sb.ToString().TrimEnd();
        }
    }
}
