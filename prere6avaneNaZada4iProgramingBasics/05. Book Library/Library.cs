namespace _05.Book_Library
{
    using System.Collections.Generic;


    public class Library
    {
        public Library()
        {
            this.listOfBooks = new List<Book>();
        }
     
        public string name;
        public List<Book> listOfBooks;                

        public double CalculateAllBookPriceByAuthor(string authorInput)
        {
            var sales = 0d;

            foreach (var book in this.listOfBooks)
            {
                if (book.author.Equals(authorInput))
                {
                    sales += book.price;
                }
            }
   
            return sales;
        }

    }
}
