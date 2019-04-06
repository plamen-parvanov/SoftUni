namespace SoftUniRestaurant.Models.Drinks
{
    public class FuzzyDrink : Drink
    {
        private const decimal FuzzyDrinkPrice = 2.50m;

        public FuzzyDrink(string name, int servingSize, string brand)
            : base(name, servingSize, FuzzyDrinkPrice, brand)
        {
        }

        public override string ToString()
        {
            return string.Format(base.ToString(), this.Name, this.Brand,
                                                  this.ServingSize, this.Price);
        }
    }
}
