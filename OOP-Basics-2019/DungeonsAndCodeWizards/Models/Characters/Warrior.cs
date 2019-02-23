namespace DungeonsAndCodeWizards.Models.Characters
{
    using Contracts;
    using Bags;
    using Enums;
    using Validaros;

    class Warrior : Character, IAttackable
    {
        private const double ABILITY_POINTS = 40;
        private const double HEALT = 100;
        private const double ARMOR = 50;

        public Warrior(string name, Faction faction)
            : base(name, HEALT, ARMOR, ABILITY_POINTS, new Satchel(), faction)
        {
        }


        public void Attack(Character character)
        {
            Validator.IsAlive(this);
            Validator.IsAlive(character);
            Validator.AttackItSelf(this, character);
            Validator.AttackSameFraction(this, character);

            character.TakeDamage(this.AbilityPoints);
        }
    }
}
