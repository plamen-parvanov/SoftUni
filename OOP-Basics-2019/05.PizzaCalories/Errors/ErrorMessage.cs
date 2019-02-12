namespace _05.PizzaCalories.Errors
{
    public static class ErrorMessage
    {
        public static string InvalidDoughtType => "Invalid type of dough.";

        public static string InvalidDoughtWeight => "Dough {0} should be in the range [{1}..{2}].";

        public static string InvalidToppingWeight => "{0} {1} should be in the range [{2}..{3}].";

        public static string InvalidToppingType => "Cannot place {0} on top of your pizza.";

        public static string InvalidPizzaName => "Pizza {0} should be between 1 and {1} symbols.";

        public static string IvalidNumberOfToppings = "Number of {0} should be in range [0..{1}].";
    }
}
