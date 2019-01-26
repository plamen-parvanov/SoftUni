namespace _04.HotelReservation
{
    using Enums;

    public class PriceCalculator
    {
        private decimal pricePerDay;
        private int numberOfDays;
        private Season season;
        private DiscountType discountType;

        public PriceCalculator(decimal pricePerDay, int numberOfDays, 
                               Season season, DiscountType discountType)
        {
            this.pricePerDay = pricePerDay;
            this.numberOfDays = numberOfDays;
            this.season = season;
            this.discountType = discountType;
        }

        public decimal Calculate()
        {
            return pricePerDay * numberOfDays * (int)season * (100 - (int)discountType) / 100;
        }
       
    }
}
