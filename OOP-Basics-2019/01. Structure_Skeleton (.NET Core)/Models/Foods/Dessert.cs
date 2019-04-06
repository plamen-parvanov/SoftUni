namespace SoftUniRestaurant.Models.Foods
{
    public class Dessert : Food
    {
        private const int InitialServingSize = 200;

        public Dessert(string name, decimal price) 
            : base(name, InitialServingSize, price)
        {
        }

        public override string ToString()
        {
            return string.Format(base.ToString(), this.Name, this.ServingSize, this.Price);
        }
    }
}
