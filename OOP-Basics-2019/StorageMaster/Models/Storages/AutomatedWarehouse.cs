namespace StorageMaster.Models.Storages
{
    using System.Collections.Generic;
    using Models.Vehicles;

    public class AutomatedWarehouse : Storage
    {
        private const int CAPACITY = 1;
        private const int GARAGE_SLOTS = 2;

        public AutomatedWarehouse(string name)
            : base(name, CAPACITY, GARAGE_SLOTS, new List<Vehicle>() { new Truck()})
        {
        }
    }
}
