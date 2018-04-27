namespace _06.Book_Library_Modification
{

    using System;
    using System.Globalization;
    using System.Linq;



    public class Program
    {

        public static void Main()
        {
            var numberOfBooks = int.Parse(Console.ReadLine());
            var library = new Library();

            for (int i = 0; i < numberOfBooks; i++)
            {
                AddBookToLibrary(library);
            }

            var date = DateTime.ParseExact(
                Console.ReadLine(), "dd.MM.yyyy", CultureInfo.InvariantCulture);

            var booksAfterDateRelease = AddBooksAfterReleaseDate(library, date);

            PrintBooks(booksAfterDateRelease);

        }

        public static void AddBookToLibrary(Library library)
        {
            var inputLine = Console.ReadLine()
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var title = inputLine[0];
            var author = inputLine[1];
            var publisher = inputLine[2];
            var releaseDate = DateTime.ParseExact(
                inputLine[3], "dd.MM.yyyy", CultureInfo.InvariantCulture);
            var isbnNumber = inputLine[4];
            var price = double.Parse(inputLine[5]);

            var currentBook = new Book(
                title, author, publisher, releaseDate, isbnNumber, price);

            library.listOfBooks.Add(currentBook);
        }

        public static int CompareDaterelease(DateTime releaseDate, DateTime date)
        {
            var result = DateTime.Compare(releaseDate, date);
            return result;
        }

        public static Library AddBooksAfterReleaseDate(Library library, DateTime date)
        {
            var booksAfterDateRelease = new Library();

            foreach (var book in library.listOfBooks)
            {
                if (CompareDaterelease(book.releaseDate, date) > 0)
                {
                    booksAfterDateRelease.listOfBooks.Add(book);
                }
            }

            return booksAfterDateRelease;

        }

        public static void PrintBooks(Library booksAfterDateRelease)
        {
            var result = booksAfterDateRelease
                .listOfBooks
                .OrderBy(r => r.releaseDate)
                .ThenBy(n => n.title);

            foreach (var book in result)
            {
                Console.WriteLine("{0} -> {1}",
                    book.title, book.releaseDate.ToString("dd.MM.yyyy"));
            }

        }



    }
}
