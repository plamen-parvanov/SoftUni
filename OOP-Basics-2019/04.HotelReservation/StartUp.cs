namespace _04.HotelReservation
{
    using Enums;
    using System;

    public class StartUp
    {
        public static void Main()
        {
            var arr = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var pricePerDay = decimal.Parse(arr[0]);
            var numberOfDays = int.Parse(arr[1]);
            var season = Enum.Parse<Season>(arr[2]);
            var discountType = DiscountType.None;

            if (arr.Length > 3)
            {
                discountType = Enum.Parse<DiscountType>(arr[3]);
            }

            var calc = new PriceCalculator(pricePerDay, numberOfDays, season, discountType);

            Console.WriteLine($"{calc.Calculate():F2}");
        }
    }
}
