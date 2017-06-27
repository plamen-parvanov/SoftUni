namespace _05.Book_Library
{

    using System;
    using System.Linq;
    using System.Globalization;
    using System.Collections.Generic;


    public class ObjectsAndClasses
    {

        public static void Main()
        {
            var numberOfBooks = int.Parse(Console.ReadLine());
            var library = new Library();

            AddingBooksInLibrary(numberOfBooks, library);

            var priceAllBooksByAuthor = CalculatePriceOfAllBooksByAuthor(library);
            var result = priceAllBooksByAuthor.OrderByDescending(v => v.Value).ThenBy(k => k.Key);

            foreach (var kvp in result)
            {
                Console.WriteLine("{0} -> {1:f2}", kvp.Key, kvp.Value);
            }

        }

        public static Dictionary<string, double> CalculatePriceOfAllBooksByAuthor(Library library)
        {
            var dict = new Dictionary<string, double>();
            var ListOfAuthors = new List<string>();

            ListOfAuthors = library.listOfBooks.Select(a => a.author).Distinct().ToList();

            foreach (var author in ListOfAuthors)
            {
                dict[author] = library.CalculateAllBookPriceByAuthor(author);
            }

            return dict;
            

        }

        public static Book AddNewBookInfo(string[] inputLine, Library library)
        {
            var title = inputLine[0];
            var author = inputLine[1];
            var publisher = inputLine[2];
            var release = DateTime.ParseExact(
                inputLine[3], "dd.MM.yyyy", CultureInfo.InvariantCulture);
            var ISBNnumber = inputLine[4];
            var price = double.Parse(inputLine[5]);

            var book = new Book(title, author, publisher, release, ISBNnumber, price);

            return book;
        }

        public static void AddingBooksInLibrary(int numberOfBooks, Library library)
        {
          
            for (int i = 0; i < numberOfBooks; i++)
            {
                var inputLine = Console.ReadLine()
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                var currentBook = AddNewBookInfo(inputLine, library);
                library.listOfBooks.Add(currentBook);

            }
        }
    }
}
