namespace _07.InfernoInfinity.Models.Wepons.Contracts
{
    using Enums;
    using Gems.Contracts;

    public interface IWeapon
    {
        string Name { get; }

        IGem[] Sockets { get; }

        int MinDamage { get; }

        int MaxDamage { get; }

        int Strenght { get; }

        int Agility { get; }

        int Vitality { get; }

        Rarity Rarity { get; }
    }
}
