namespace SoftUniRestaurant.Models.Foods
{
    public class MainCourse : Food
    {
        private const int InitialServingSize = 500;

        public MainCourse(string name, decimal price) 
            : base(name, InitialServingSize, price)
        {
        }

        public override string ToString()
        {
            return string.Format(base.ToString(), this.Name, this.ServingSize, this.Price);
        }
    }
}
