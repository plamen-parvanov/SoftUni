namespace _07.InfernoInfinity.Models.Wepons
{
    using Enums;
    using Gems.Contracts;

    public class Axe : Weapon
    {
        private const int MIN_DAMAGE = 5;
        private const int MAX_DAMAGE = 10;

        public Axe(Rarity rarety, string name) 
            : base(rarety, name, new IGem[4], MIN_DAMAGE, MAX_DAMAGE)
        {
        }
    }
}
