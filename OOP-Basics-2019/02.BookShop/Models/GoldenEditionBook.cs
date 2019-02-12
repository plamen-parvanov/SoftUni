namespace _02.BookShop.Models
{
    public class GoldenEditionBook :Book
    {
        private const decimal INCREASE_PERCENTAGE = 0.30m;

        public GoldenEditionBook(string author, string title, decimal price) 
            : base(author, title, price)
        {

        }

        public override decimal Price
        {
            protected set
            {
                base.Price = value  + value * INCREASE_PERCENTAGE; 
            }
        }
    }
}
