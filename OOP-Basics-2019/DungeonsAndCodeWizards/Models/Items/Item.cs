namespace DungeonsAndCodeWizards.Models
{
    using Characters;
    using Validaros;

    public abstract class Item
    {
        protected Item(int weight)
        {
            this.Weight = weight;
        }

        public int Weight { get; private set; }

        public virtual void AffectCharacter(Character character)
        {
            Validator.IsAlive(character);
        }
    }
}
