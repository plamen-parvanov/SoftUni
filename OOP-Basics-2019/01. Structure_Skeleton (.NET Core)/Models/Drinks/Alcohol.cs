namespace SoftUniRestaurant.Models.Drinks
{
    public class Alcohol : Drink
    {
        private const decimal AlcoholPrice = 3.50m;

        public Alcohol(string name, int servingSize, string brand)
            : base(name, servingSize, AlcoholPrice, brand)
        {
        }

        public override string ToString()
        {
            return string.Format(base.ToString(), this.Name, this.Brand,
                                                  this.ServingSize, this.Price);
        }
    }
}
