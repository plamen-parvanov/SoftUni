namespace StorageMaster.Models.Storages
{
    using Models.Products;
    using Models.Vehicles;
    using Validators;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System;

    public abstract class Storage
    {
        private Vehicle[] garage;
        private List<Product> products;
        private double currentCapacity;

        public Storage(string name, int capacity, int garageSlots,
            IEnumerable<Vehicle> vehicles)
        {
            this.Name = name;
            this.Capacity = capacity;
            this.GarageSlots = garageSlots;
            this.garage = new Vehicle[GarageSlots];
            FillGarageWith(vehicles);
            
            this.products = new List<Product>();
        }

        public string Name { get; private set; }

        public int Capacity { get; private set; }

        public int GarageSlots { get; private set; }

        public bool IsFull => this.Products.Sum(p => p.Weight) >= this.Capacity;

        public IReadOnlyCollection<Vehicle> Garage => Array.AsReadOnly(this.garage);

        public IReadOnlyCollection<Product> Products => this.products.AsReadOnly();

        public Vehicle GetVehicle(int garageSlot)
        {
            Validator.ValidateGarageSlot(this.GarageSlots, garageSlot);
            
            Validator.ValidateGarageSlotVehicle(this.garage[garageSlot]);

            return this.garage[garageSlot];
        }

        public int SendVehicleTo(int garageSlot, Storage deliveryLocation)
        {
            var currVehicle = this.GetVehicle(garageSlot);

            Validator.FreeSlotInStorage(deliveryLocation);

            this.garage[garageSlot] = null;

           var index =  Array.IndexOf(deliveryLocation.garage, null);
            deliveryLocation.garage[index] = currVehicle;

            return index;
        }

        public int UnloadVehicle(int garageSlot)
        {
            Validator.IsStorageFull(this.currentCapacity, this.Capacity);

            var currentVehicle = this.GetVehicle(garageSlot);

            var unloadedProducts = 0;

            while (!currentVehicle.IsEmpty && this.currentCapacity + currentVehicle.Trunk.Last().Weight <= this.Capacity)
            {
                var unloadedProduct = currentVehicle.Unload();

                this.products.Add(unloadedProduct);
                this.currentCapacity += unloadedProduct.Weight;

                unloadedProducts++;
            }

            return unloadedProducts;
        }

        private void FillGarageWith(IEnumerable<Vehicle> vehicles)
        {
            var index = 0;

            foreach (var vehicle in vehicles)
            {
                this.garage[index] = vehicle;

                index++;
            }
        }

        public override string ToString()
        {
            var result = new StringBuilder();
            var totalWeight = this.Products.Sum(p => p.Weight);
            var storageCapacity = this.Capacity;
            result.Append($"Stock ({totalWeight}/{storageCapacity}): [");


            var a = this.Products.GroupBy(s => s.GetType().Name)
                                 .OrderByDescending(t => t.Count());

            var index = 0;
            var lastIndex = a.Count() - 1;
            foreach (var b in a)
            {
                result.Append($"{b.Key} ({b.Count()})");

                if (index != lastIndex)
                {
                    result.Append(", ");
                }

                index++;
            }

            result.AppendLine("]");
            result.Append($"Garage: [");

            for (int i = 0; i < this.garage.Length; i++)
            {
                if (this.garage[i] == null)
                {
                    result.Append("empty");
                }
                else
                {
                    result.Append(this.garage[i]);
                }

                if (i != this.garage.Length - 1)
                {
                    result.Append("|");
                }
            }

            result.AppendLine("]");

            return result.ToString().TrimEnd();           
        }
    }
}
