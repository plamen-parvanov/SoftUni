namespace DungeonsAndCodeWizards.Models.Characters
{
    using Contracts;
    using Bags;
    using Enums;
    using Validaros;

    public class Cleric : Character, IHealable
    {
        private const double ABILITY_POINTS = 40;
        private const double HEALT = 50;
        private const double ARMOR = 25;
        private const double DEFAULT_REST_NAMIPULATOR = 0.5;


        private static Bag bag = new Backpack();

        public Cleric(string name, Faction faction) 
            : base(name, HEALT, ARMOR, ABILITY_POINTS, bag, faction)
        {
        }

        public override double RestHealMultiplier => DEFAULT_REST_NAMIPULATOR;

        public void Heal(Character character)
        {
            Validator.IsAlive(this);
            Validator.IsAlive(character);
            Validator.HealEnemyFraction(this, character);

            character.Health += this.AbilityPoints;
        }
    }
}
