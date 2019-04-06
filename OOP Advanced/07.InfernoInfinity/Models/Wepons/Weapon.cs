namespace _07.InfernoInfinity.Models.Wepons
{
    using Contracts;
    using Enums;
    using Gems.Contracts;


    public abstract class Weapon : IWeapon
    {
        private readonly int initialMinDamage;
        private readonly int initailMaxDamage;

        public Weapon(Rarity rarity, string name, IGem[] sockets, int minDamage, int maxDamage)
        {
            this.Rarity = rarity;
            this.Name = name;
            this.Sockets = sockets;
            this.initialMinDamage = minDamage;
            this.initailMaxDamage = maxDamage;
        }

        public string Name { get; private set; }

        public IGem[] Sockets { get; private set; }

        public Rarity Rarity { get; private set; }

        public int MaxDamage => CalculateMaxDamage();

        public int MinDamage => CalculateMinDamage();

        public int Strenght => CalculateStrenght();

        public int Agility => CalculateAgility();

        public int Vitality => CalculateVitality();

        public override string ToString()
        {
            return string.Format("{0}: {1}-{2} Damage, +{3} Strength, +{4} Agility, +{5} Vitality",
            this.Name, this.MinDamage, this.MaxDamage, this.Strenght, this.Agility, this.Vitality);
        }

        private int CalculateMinDamage()
        {
            var result = this.initialMinDamage;
            result *= (int)this.Rarity;
            result += this.Strenght * 2;
            result += this.Agility;

            return result;
        }

        private int CalculateMaxDamage()
        {
            var result = this.initailMaxDamage;
            result *= (int)this.Rarity;
            result += this.Strenght * 3;
            result += this.Agility * 4;

            return result;
        }

        private int CalculateStrenght()
        {
            var totalStranght = 0;

            foreach (var gem in this.Sockets)
            {
                totalStranght += gem.StrenghtModifier;
            }

            return totalStranght;
        }

        private int CalculateAgility()
        {
            var totalAgility = 0;

            foreach (var gem in this.Sockets)
            {
                totalAgility += gem.AgilityModifier;
            }

            return totalAgility;
        }

        private int CalculateVitality()
        {
            var totalVitality = 0;

            foreach (var gem in this.Sockets)
            {
                totalVitality += gem.VitalityModifier;
            }

            return totalVitality;
        }
    }
}
