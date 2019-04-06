namespace _07.InfernoInfinity.Models.Wepons
{
    using Enums;
    using Gems.Contracts;

    public class Knife : Weapon
    {
        private const int MIN_DAMAGE = 3;
        private const int MAX_DAMAGE = 4;

        public Knife(Rarity rarety, string name)
             : base(rarety, name, new IGem[4], MIN_DAMAGE, MAX_DAMAGE)
        {
        }
    }
}
