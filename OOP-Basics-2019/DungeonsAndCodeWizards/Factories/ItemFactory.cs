namespace DungeonsAndCodeWizards.Factories
{
    using Models.Items;
    using Models;
    using System;

    public static class ItemFactory
    {
        public static Item CreateItem(string type)
        {
            switch (type)
            {
                case "HealthPotion":
                    return new HealthPotion();
                case "PoisonPotion":
                    return new PoisonPotion();
                case "ArmorRepairKit":
                    return new ArmorRepairKit();
                default:
                    throw new ArgumentException($"Invalid item \"{type}\"!");
            }
        }
    }
}
