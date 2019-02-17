namespace _01.Vehicles.ErrorMessages
{
    public static class ErrorMessage
    {
        public static string NegativeFuelAmount => "Fuel must be a positive number";

        public static string OverTankAmount => "Cannot fit {0} fuel in the tank";
    }
}
