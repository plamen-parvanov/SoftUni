namespace SoftUniRestaurant.Validators
{
    using System;

    public static class Validator
    {
        public static void ValidateName(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException($"Name cannot be null or white space!");
            }
        }

        public static void ValidateBrand(string brand)
        {
            if (string.IsNullOrWhiteSpace(brand))
            {
                throw new ArgumentException("Brand cannot be null or white space!");
            }
        }

        public static void ValidateServingSize(int value)
        {
            if (value <= 0)
            {
                throw new ArgumentException("Serving size cannot be less or equal to zero");
            }
        }

        public static void ValidatePriceFood(decimal value)
        {
            if (value <= 0)
            {
                throw new ArgumentException("Price cannot be less or equal to zero!");
            }
        }

        public static void ValidatePriceDrink(decimal value)
        {
            if (value <= 0)
            {
                throw new ArgumentException("Price cannot be less or equal to zero");
            }
        }

        public static void ValidateCapacity(int value)
        {
            if (value <= 0)
            {
                throw new ArgumentException("Capacity has to be greater than 0");
            }
        }

        public static void ValidateNumberOfPeople(int value)
        {
            if (value <= 0)
            {
                throw new ArgumentException("Cannot place zero or less people!");
            }
        }
    }
}
