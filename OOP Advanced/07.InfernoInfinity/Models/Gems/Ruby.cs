namespace _07.InfernoInfinity.Models.Gems
{
    using Enums;

    public class Ruby : Gem
    {
        private const int STRENGHT_MODIFIER = 7;
        private const int AGILITY_MODIFIER = 2;
        private const int VITALITY_MODIFIER = 5;

        public Ruby(Clarity clarity) 
            : base(clarity, STRENGHT_MODIFIER, AGILITY_MODIFIER, VITALITY_MODIFIER)
        {
        }
    }
}
