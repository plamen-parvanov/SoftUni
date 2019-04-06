namespace SoftUniRestaurant.Models.Drinks
{
    public class Juice : Drink
    {
        private const decimal JuicePrice = 1.80m;

        public Juice(string name, int servingSize, string brand)
            : base(name, servingSize, JuicePrice, brand)
        {
        }

        public override string ToString()
        {
            return string.Format(base.ToString(), this.Name, this.Brand,
                                                  this.ServingSize, this.Price);
        }
    }
}
