using DungeonsAndCodeWizards.Models.Characters;

namespace DungeonsAndCodeWizards.Models.Items
{
    public class PoisonPotion : Item
    {
        private const int WEIGHT = 5;
        private const double HEALTH_DECREASE = 20;

        public PoisonPotion() : base(WEIGHT)
        {
        }

        public override void AffectCharacter(Character character)
        {
            base.AffectCharacter(character);

            character.Health -= HEALTH_DECREASE;
        }
    }
}
