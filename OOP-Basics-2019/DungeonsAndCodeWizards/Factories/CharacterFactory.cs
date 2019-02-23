namespace DungeonsAndCodeWizards.Factories
{
    using Models.Characters.Enums;
    using Models.Characters;
    using System;

    public static class CharacterFactory
    {
        public static Character CraetCharacter(string type, string name, Faction faction)
        {
            switch (type)
            {
                case "Warrior":
                    return new Warrior(name, faction);
                case "Cleric":
                    return new Cleric(name, faction);
                default:
                    throw new ArgumentException("Invalid character type \"{type}\"!");
            }
        }
    }
}
