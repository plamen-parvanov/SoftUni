namespace StorageMaster.Models.Vehicles
{
    using Models.Products;
    using StorageMaster.Validators;
    using System.Collections.Generic;
    using System.Linq;

    public abstract class Vehicle
    {
        private readonly List<Product> trunk;

        public Vehicle(int capacity)
        {
            this.trunk = new List<Product>();
            this.Capacity = capacity;
        }

        public int Capacity { get; private set; }

        public bool IsFull => this.Trunk.Sum(p => p.Weight) >= this.Capacity;

        public bool IsEmpty => this.Trunk.Count == 0;

        public IReadOnlyCollection<Product> Trunk => this.trunk.AsReadOnly();

        public void LoadProduct(Product product)
        {
            Validator.IsTrunkFull(this.GetType().Name, this.IsFull);

            this.trunk.Add(product);
        }

        public Product Unload()
        {
            Validator.IsTrunkEmpty(this.GetType().Name, this.IsEmpty);

            var removedProduct = trunk.Last();
            this.trunk.RemoveAt(this.trunk.Count - 1);

            return removedProduct;
        }

        public override string ToString()
        { 
            return this.GetType().Name;
        }
    }
}
