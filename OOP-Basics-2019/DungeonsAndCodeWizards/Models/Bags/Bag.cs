namespace DungeonsAndCodeWizards.Models.Bags
{
    using Validaros;
    using System.Collections.Generic;
    using System.Linq;

    public abstract class Bag
    {
        private List<Item> items;

        public Bag(int capacity)
        {
            this.Capacity = capacity;
            this.items = new List<Item>();
        }

        public int Capacity { get; private set; }

        public double Load => this.items.Sum(i => i.Weight);

        public IReadOnlyCollection<Item> Items => this.items.AsReadOnly();

        public void AddItem(Item item)
        {
            Validator.IsBagFull(this.Load, item.Weight, this.Capacity);

            this.items.Add(item);

        }

        public Item GetItem(string name)
        {
            Validator.IsBagEmpty(this.items.Count);

            var item = items.FirstOrDefault(i => i.GetType().Name == name);

            Validator.DoesItemExist(name, item);

            items.Remove(item);

            return item;

        }
    }
}
