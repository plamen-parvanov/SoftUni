namespace DungeonsAndCodeWizards.Models.Items
{
    using Characters;

    public class HealthPotion : Item
    {
        private const int WEIGHT = 5;
        private const double HEALTH_INCREASE = 20;

        public HealthPotion() : base(WEIGHT)
        {
        }

        public override void AffectCharacter(Character character)
        {
            base.AffectCharacter(character);

            character.Health += HEALTH_INCREASE;
        }
    }
}
