namespace StorageMaster.Validators
{
    using ErrorMessages;
    using Models.Storages;
    using Models.Vehicles;
    using System;
    using System.Linq;

    public static class Validator
    {
        public static void ValidateProductPrice(string name, double value)
        {
            if (value < 0)
            {
                throw new InvalidOperationException(
                    string.Format(ErrorMessage.InvalidProductPrice, name));
            }
        }

        public static void IsTrunkFull(string name, bool isFull)
        {
            if (isFull)
            {
                throw new InvalidOperationException(
                    string.Format(ErrorMessage.VehicleIsFull, name));
            }
        }

        public static void IsTrunkEmpty(string name, bool isEmpty)
        {
            if (isEmpty)
            {
                throw new InvalidOperationException(
                    string.Format(ErrorMessage.VehicleIsEmpty, name));
            }
        }

        public static void ValidateGarageSlot(int garageSlots, int garageSlot)
        {
            if (garageSlot >= garageSlots)
            {
                throw new InvalidOperationException(ErrorMessage.InvalidGarageSlot);
            }
        }

        public static void ValidateGarageSlotVehicle(Vehicle vehicle)
        {
            if (vehicle == null)
            {
                throw new InvalidOperationException(ErrorMessage.EmptyGarageSlot);
            }
        }

        public static void FreeSlotInStorage(Storage storage)
        {
            if (storage.Garage.All(v => v!= null))
            {
                throw new InvalidOperationException(ErrorMessage.FullGarage);
            }
        }

        public static void IsStorageFull(double current, int max)
        {
            if (current == max)
            {
                throw new InvalidOperationException(ErrorMessage.FullStorage);
            }
        }
    }
}
