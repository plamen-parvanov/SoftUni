namespace SoftUniRestaurant.Models.Foods
{
    public class Soup : Food
    {
        private const int InitialServingSize = 245;

        public Soup(string name, decimal price)
            : base(name, InitialServingSize, price)
        {
        }

        public override string ToString()
        {
            return string.Format(base.ToString(), this.Name, this.ServingSize, this.Price);
        }
    }
}
