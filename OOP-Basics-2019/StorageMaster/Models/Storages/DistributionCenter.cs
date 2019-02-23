namespace StorageMaster.Models.Storages
{
    using Models.Vehicles;
    using System.Collections.Generic;

    public class DistributionCenter : Storage
    {
        private const int CAPACITY = 2;
        private const int GARAGE_SLOTS = 5;

        public DistributionCenter(string name)
            : base(name, CAPACITY, GARAGE_SLOTS,
                  new List<Vehicle>() { new Van(), new Van(), new Van()})
        {
        }
    }
}
