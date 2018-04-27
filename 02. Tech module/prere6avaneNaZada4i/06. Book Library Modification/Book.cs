namespace _06.Book_Library_Modification
{
    using System;

    public class Book
    {
        public Book(string title, string author, string publisher, DateTime releaseDate,
            string isbnNumber, double price)
        {
           this.title = title;
           this.author = author;
           this.publisher = publisher;
           this.releaseDate = releaseDate;
           this.isbnNumber = isbnNumber;
           this.price = price;

        }

        public string title;
        public string author;
        public string publisher;
        public DateTime releaseDate;
        public string isbnNumber;
        public double price;
    }
}
