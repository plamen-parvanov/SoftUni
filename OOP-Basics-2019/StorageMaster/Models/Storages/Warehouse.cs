namespace StorageMaster.Models.Storages
{
    using Models.Vehicles;
    using System.Collections.Generic;

    public class Warehouse : Storage
    {
        private const int CAPACITY = 10;
        private const int GARAGE_SLOTS = 10;

        public Warehouse(string name)
            : base(name, CAPACITY, GARAGE_SLOTS,
                  new List<Vehicle>() { new Semi(), new Semi(), new Semi() })
        {
        }
    }
}
