namespace StorageMaster.Controllers
{
    using System;
    using System.Collections.Generic;
    using ErrorMessages;
    using Models.Storages;
    using Models.Products;
    using System.Linq;
    using Models.Vehicles;
    using System.Text;

    public class StorageMaster
    {
        private static List<Product> productsPool;
        private static List<Storage> storageRegistry;
        private static Vehicle currentVehicle;
        public StorageMaster()
        {
            productsPool = new List<Product>();
            storageRegistry = new List<Storage>();
        }

        public string AddProduct(string type, double price)
        {
            Product currentProduct;

            switch (type)
            {
                case "Gpu":
                    currentProduct = new Gpu(price);
                    break;
                case "HardDrive":
                    currentProduct = new HardDrive(price);
                    break;
                case "Ram":
                    currentProduct = new Ram(price);
                    break;
                case "SolidStateDrive":
                    currentProduct = new SolidStateDrive(price);
                    break;
                default:
                    throw new InvalidOperationException(ErrorMessage.InvalidProductType);
            }

            productsPool.Add(currentProduct);

            return $"Added {type} to pool";
        }

        public string RegisterStorage(string type, string name)
        {
            Storage currentStorage;

            switch (type)
            {
                case "AutomatedWarehouse":
                    currentStorage = new AutomatedWarehouse(name);
                    break;
                case "DistributionCenter":
                    currentStorage = new DistributionCenter(name);
                    break;
                case "Warehouse":
                    currentStorage = new Warehouse(name);
                    break;
                default:
                    throw new InvalidOperationException(ErrorMessage.InvalidStoradeType);
            }

            storageRegistry.Add(currentStorage);

            return $"Registered {name}";
        }

        public string SelectVehicle(string storageName, int garageSlot)
        {
            var currentSorage = storageRegistry.First(s => s.Name == storageName);

            currentVehicle = currentSorage.GetVehicle(garageSlot);

            return $"Selected {currentVehicle.GetType().Name}";
        }

        public string LoadVehicle(IEnumerable<string> productNames)
        {
            var result = new StringBuilder();

            var loadedProducts = 0;
            var productCount = productNames.Count();
            var vehicleType = currentVehicle.GetType().Name;

            foreach (var productName in productNames)
            {
                var loadedProduct = productsPool
                                   .LastOrDefault(p => p.GetType().Name == productName);

                if (loadedProduct == null)
                {
                    throw new InvalidOperationException(
                        string.Format(ErrorMessage.OutOfStock, productName));
                }

                try
                {
                    currentVehicle.LoadProduct(loadedProduct);

                    var index = productsPool.LastIndexOf(loadedProduct);
                    productsPool.RemoveAt(index);

                    loadedProducts++;
                }
                catch (InvalidOperationException ex)
                {
                    result.AppendLine(ex.Message);
                }
            }

            return $"Loaded {loadedProducts}/{productCount} products into {vehicleType}";
        }

        public string SendVehicleTo(string sourceName, int sourceGarageSlot, string destinationName)
        {
            var source = storageRegistry.FirstOrDefault(s => s.Name == sourceName);
            var destination = storageRegistry.FirstOrDefault(s => s.Name == destinationName);
            if (source == null)
            {
                throw new InvalidOperationException(ErrorMessage.InvalidSourceStorage);
            }
            else if (destination == null)
            {
                throw new InvalidOperationException(ErrorMessage.InvalidDestinationStorage);
            }

            var vehicleType = source.GetVehicle(sourceGarageSlot).GetType().Name;
            var destinationGarageSlot = source.SendVehicleTo(sourceGarageSlot, destination);

            return $"Sent {vehicleType} to {destinationName} (slot {destinationGarageSlot})";
        }

        public string UnloadVehicle(string storageName, int garageSlot)
        {
            var storage = storageRegistry.FirstOrDefault(s => s.Name == storageName);
            if (storage == null)
            {
                throw new InvalidOperationException("Ne e uto4neno kvo da se prai :P");
            }

            var productsInVehicle = storage.GetVehicle(garageSlot).Trunk.Count;

            var unloadedProductsCount = storage.UnloadVehicle(garageSlot);

            return $"Unloaded {unloadedProductsCount}/{productsInVehicle} products at {storageName}";
        }

        public string GetStorageStatus(string storageName)
        {
            var storage = storageRegistry.FirstOrDefault(s => s.Name == storageName);
            if (storage == null)
            {
                throw new InvalidOperationException("Pak problem!!!");
            }

            return storage.ToString();
        }

        public string GetSummary()
        {
            var ordered = storageRegistry
                               .OrderByDescending(s => s.Products.Sum(p => p.Price))
                               .ToList();

            var sb = new StringBuilder();

            foreach (var storage in ordered)
            {
                var totalMoney = storage.Products.Sum(p => p.Price);

                sb.AppendLine($"{storage.Name}:");
                sb.AppendLine($"Storage worth: ${totalMoney:F2}");
            }


            return sb.ToString().TrimEnd();
        }

    }
}
