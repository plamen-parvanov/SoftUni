namespace _02.Advertisement_Message
{
    using System;


    public class ObjectsAndClasses
    {

        public static void Main()
        {
            var phrases = AddingPhrases();
            var events = AddingEvents();
            var authors = AddingAuthors();
            var cities = AddingCities();

            var random = new Random();
            var n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var phrase = phrases[random.Next(0, phrases.Length)];
                var eventt = events[random.Next(0, events.Length)];
                var author = authors[random.Next(0, authors.Length)];
                var city = cities[random.Next(0, cities.Length)];

                Console.WriteLine($"{phrase} {eventt} {author} - {city}"); 

            }


        }

        public static string[] AddingPhrases()
        {
            var phrases = new[]
            {
                "Excellent product.",
                "Such a great product.",
                "I always use that product.",
                "Best product of its category.",
                "Exceptional product.",
                "I can’t live without this product."
            };

            return phrases;
        }

        public static string[] AddingEvents()
        {
            var events = new[]
            {
                "Now I feel good.",
                "I have succeeded with this product.",
                "Makes miracles. I am happy of the results!",
                "I cannot believe but now I feel awesome.",
                "Try it yourself, I am very satisfied.",
                "I feel great!"
            };

            return events;

        }

        public static string[] AddingAuthors()
        {
            var authors = new[]
            {
                "Diana",
                "Petya",
                "Stella",
                "Elena",
                "Katya",
                "Iva",
                "Annie",
                 "Eva"
            };

            return authors;

        }

        public static string[] AddingCities()
        {
            var cities = new[]
            {
                "Burgas",
                "Sofia",
                "Plovdiv",
                "Varna",
                "Ruse"
            };

            return cities;
        }
    }
}
