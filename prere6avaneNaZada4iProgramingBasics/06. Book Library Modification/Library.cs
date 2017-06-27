namespace _06.Book_Library_Modification
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
    }
}
