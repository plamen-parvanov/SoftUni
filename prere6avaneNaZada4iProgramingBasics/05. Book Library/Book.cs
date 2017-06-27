namespace _05.Book_Library
{
    using System;

    public class Book
    {
        public Book(string title, string author, string publisher,
            DateTime releaseDate, string ISBNnumber, double price)
        {
            this.title = title;
            this.author = author;
            this.publisher = publisher;
            this.releaseDate = releaseDate;
            this.ISBNnumber = ISBNnumber;
            this.price = price;
        }

        public string title;
        public string author;
        public string publisher;
        public DateTime releaseDate;
        public string ISBNnumber;
        public double price;
    }
}
