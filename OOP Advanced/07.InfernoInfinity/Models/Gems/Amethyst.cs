namespace _07.InfernoInfinity.Models.Gems
{
    using Enums;

    public class Amethyst : Gem
    {
        private const int STRENGHT_MODIFIER = 2;
        private const int AGILITY_MODIFIER = 8;
        private const int VITALITY_MODIFIER = 4;

        public Amethyst(Clarity clarity)
            : base(clarity, STRENGHT_MODIFIER, AGILITY_MODIFIER, VITALITY_MODIFIER)
        {
        }
    }
}
