namespace AnimalCentre.Models.Animals
{
    using Validators;
    using Contracts;

    public abstract class Animal : IAnimal
    {
        private const int HAPPYNESS_MIN_VALUE = 0;
        private const int HAPPYNESS_MAX_VALUE = 100;
        private const int ENERGY_MIN_VALUE = 0;
        private const int ENERGY_MAX_VALUE = 100;
        private const string DEFAULT_OWNER = "Centre";

        private int happyness;
        private int energy;

        protected Animal(string name, int energy, int happiness, int procedureTime)
        {
            this.Name = name;
            this.Energy = energy;
            this.Happiness = happiness;
            this.ProcedureTime = procedureTime;
            this.IsAdopt = false;
            this.IsChipped = false;
            this.IsVaccinated = false;
            this.Owner = DEFAULT_OWNER;
        }
        public string Name { get; private set; }

        public int Happiness
        {
            get
            {
                return this.happyness;
            }
            set
            {
                Validator.ValidateHappiness(value, HAPPYNESS_MIN_VALUE,
                    HAPPYNESS_MAX_VALUE, nameof(this.happyness));

                this.happyness = value;
            }
        }

        public int Energy
        {
            get
            {
                return this.energy;
            }
            set
            {
                Validator.ValidateEnergy(value, ENERGY_MIN_VALUE,
                    ENERGY_MAX_VALUE, nameof(this.energy));

                this.energy = value;
            }
        }

        public int ProcedureTime { get; set; }

        public string Owner { get; set; }

        public bool IsAdopt { get; set; }

        public bool IsChipped { get; set; }

        public bool IsVaccinated { get; set; }

        public override string ToString()
        {
            return "    Animal type: {0} - {1} - Happiness: {2} - Energy: {3}";
        }
    }
}
