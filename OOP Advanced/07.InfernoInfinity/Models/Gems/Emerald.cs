namespace _07.InfernoInfinity.Models.Gems
{
    using Enums;

    public class Emerald : Gem
    {
        private const int STRENGHT_MODIFIER = 1;
        private const int AGILITY_MODIFIER = 4;
        private const int VITALITY_MODIFIER = 9;

        public Emerald(Clarity clarity)
            : base(clarity, STRENGHT_MODIFIER, AGILITY_MODIFIER, VITALITY_MODIFIER)
        {
        }
    }
}
