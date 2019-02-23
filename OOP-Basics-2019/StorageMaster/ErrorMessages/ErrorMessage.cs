namespace StorageMaster.ErrorMessages
{
    public static class ErrorMessage
    {
        public static string InvalidProductPrice => "{0} cannot be negative!";
        public static string VehicleIsFull => "{0} is full!";
        public static string VehicleIsEmpty => "No products left in {0}!";
        public static string InvalidGarageSlot => "Invalid garage slot!";
        public static string EmptyGarageSlot => "No vehicle in this garage slot!";
        public static string FullGarage => "No room in garage!";
        public static string FullStorage => "Storage is full!";
        public static string InvalidProductType => "Invalid product type!";
        public static string InvalidStoradeType => "Invalid storage type!";
        public static string OutOfStock => "{0} is out of stock!";
        public static string InvalidSourceStorage => "Invalid source storage!";
        public static string InvalidDestinationStorage => "Invalid destination storage!";
    }
}
