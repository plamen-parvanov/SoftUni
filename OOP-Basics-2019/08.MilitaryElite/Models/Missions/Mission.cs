namespace _08.MilitaryElite.Models.Missions
{
    using Validators;

    public class Mission
    {
        private string name;
        private string state;

        public Mission(string name, string state)
        {
            this.Name = name;
            this.State = state;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            private set
            {
                this.name = value;
            }
        }

        public string State
        {
            get
            {
                return this.state;
            }
            private set
            {
                Validator.ValidateMission(value);

                this.state = value;
            }
        }

        public void CompleteMission()
        {
            this.State = "Finished";
        }

        public override string ToString()
        {
            return $"  Code Name: {this.Name} State: {this.State}";
        }
    }
}
