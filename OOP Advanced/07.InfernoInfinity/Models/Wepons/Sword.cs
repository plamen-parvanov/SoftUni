namespace _07.InfernoInfinity.Models.Wepons
{
    using Enums;
    using Gems.Contracts;

    public class Sword : Weapon
    {
        private const int MIN_DAMAGE = 4;
        private const int MAX_DAMAGE = 6;

        public Sword(Rarity rarety, string name)
            : base(rarety, name, new IGem[4], MIN_DAMAGE, MAX_DAMAGE)
        {
        }
    }
}
