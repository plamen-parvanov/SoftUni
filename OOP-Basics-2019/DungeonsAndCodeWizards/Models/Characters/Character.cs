namespace DungeonsAndCodeWizards.Models.Characters
{
    using Bags;
    using Enums;
    using Validaros;

    public abstract class Character
    {
        private const double DEFAULT_REST_NAMIPULATOR = 0.2;

        private double health;
        private double armor;
        private string name;

        protected Character(string name, double health, double armor, double abilityPoints,
            Bag bag, Faction faction)
        {
            this.Name = name;
            this.BaseHealth = health;
            this.Health = health;
            this.BaseArmor = armor;
            this.Armor = armor;
            this.AbilityPoints = abilityPoints;
            this.Bag = bag;
            this.Faction = faction;
            this.IsAlive = true;
        }

        public bool IsAlive { get; private set; }

        public double BaseHealth { get; private set; }

        public double Health
        {
            get
            {
                return this.health;
            }
            set
            {
                if (value <= 0)
                {
                    this.IsAlive = false;
                    value = 0;
                }
                else if (value > this.BaseHealth)
                {
                    value = this.BaseHealth;
                }

                this.health = value;
            }
        }

        public double BaseArmor { get; private set; }

        public double Armor
        {
            get
            {
                return this.armor;
            }
            set
            {
                if (value <= 0)
                {
                    value = 0;
                }
                else if (value > this.BaseArmor)
                {
                    value = this.BaseArmor;
                }

                this.armor = value;
            }
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            private set
            {
                Validator.InvalidCharacterName(value);

                this.name = value;
            }
        }

        public double AbilityPoints { get; private set; }

        public Bag Bag { get; private set; }

        public Faction Faction { get; private set;}

        public virtual double RestHealMultiplier { get; private set; } = DEFAULT_REST_NAMIPULATOR;

        public void TakeDamage(double hitPoints)
        {
            Validator.IsAlive(this);

            var remainingHitPoints = hitPoints - this.Armor;

            this.Armor -= hitPoints;

            if (remainingHitPoints > 0)
            {
                this.Health -= remainingHitPoints;
            }
        }

        public void Rest()
        {
            Validator.IsAlive(this);

            this.Health += this.BaseHealth * this.RestHealMultiplier;
        }

        public void UseItem(Item item)
        {
            item.AffectCharacter(this);

        }

        public void UseItemOn(Item item, Character character)
        {
            Validator.IsAlive(this);

            item.AffectCharacter(character);
        }

        public void ReceiveItem(Item item)
        {
            Validator.IsAlive(this);

            this.Bag.AddItem(item);
        }

        public void GiveCharacterItem(Item item, Character character)
        {
            Validator.IsAlive(this);

            character.ReceiveItem(item);
        }

    }
}
