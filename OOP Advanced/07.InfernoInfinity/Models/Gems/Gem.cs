namespace _07.InfernoInfinity.Models.Gems
{
    using Contracts;
    using Enums;

    public abstract class Gem : IGem
    {
        public Gem(Clarity clarity, int strenghtModifier, int agilityModifier, 
            int vitalityModifier)
        {
            this.Clarity = clarity;
            this.StrenghtModifier = strenghtModifier;
            this.AgilityModifier = agilityModifier;
            this.VitalityModifier = vitalityModifier;

            IncreaseAllStatsBaseOnClarity();
        }

        public int StrenghtModifier { get; private set; }

        public int AgilityModifier { get; private set; }

        public int VitalityModifier { get; private set; }

        public Clarity Clarity { get; private set; }

        private void IncreaseAllStatsBaseOnClarity()
        {
            this.StrenghtModifier += (int)this.Clarity;
            this.AgilityModifier += (int)this.Clarity;
            this.VitalityModifier += (int)this.Clarity;
        }

    }
}
