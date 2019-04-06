namespace _07.InfernoInfinity.Models.Gems.Contracts
{
    using Enums;

    public interface IGem
    {
        int StrenghtModifier { get; }

        int AgilityModifier { get; }

        int VitalityModifier { get; }

        Clarity Clarity { get; }
    }
}
