namespace _04._Movie_Time
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Problem04
    {
        private static Dictionary<string, int> dict;
        private static int totalDuration;

        public static void Main()
        {
            ReadInput();

            PrintFavouriteMovies();


        }

        private static void PrintFavouriteMovies()
        {
            foreach (var movie in dict)
            {
                var currName = movie.Key;
                Console.WriteLine(currName);

                var answer = Console.ReadLine();
                if (answer == "Yes")
                {
                    PrintCurrMoveiAndTotalDuration(currName, movie.Value);
                    break;
                }
            }
        }

        private static void PrintCurrMoveiAndTotalDuration(string chosenMovie, int durationInSec)
        {
            string chosenMovieDuration = GetTimeInFormat(durationInSec);
            var totalPlaylistDuration = GetTimeInFormat(totalDuration);

            Console.WriteLine($"We're watching {chosenMovie} - {chosenMovieDuration}");
            Console.WriteLine($"Total Playlist Duration: {totalPlaylistDuration}");
        }

        private static string GetTimeInFormat(int durationInSec)
        {
            var seconds = durationInSec % 60;
            var mins = (durationInSec / 60) % 60;
            var hours = durationInSec / (60 * 60);

            return string.Format("{0:d2}:{1:d2}:{2:d2}", hours, mins, seconds);
        }

        private static void ReadInput()
        {
            var favouriteGenre = Console.ReadLine();
            var durationCriteria = Console.ReadLine();

            dict = new Dictionary<string, int>();
            totalDuration = 0;

            AddFavouriteMovies(favouriteGenre);

            OrderFilmsBy(durationCriteria);
        }

        private static void OrderFilmsBy(string durationCriteria)
        {
            if (durationCriteria == "Short")
            {
                dict = dict.OrderBy(x => x.Value).ToDictionary(k => k.Key, v => v.Value );
            }
            else if(durationCriteria == "Long")
            {
                dict = dict.OrderByDescending(x => x.Value).ToDictionary(k => k.Key, v => v.Value);

            }
        }

        private static void AddFavouriteMovies(string favouriteGenre)
        {
            while (true)
            {
                var inputLine = Console.ReadLine();
                if (inputLine == "POPCORN!")
                {
                    break;
                }

                var inputArr = inputLine
                    .Split(new[] { '|' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                var genre = inputArr[1];
                var duration = CalculateTimeInSeconds(inputArr[2]);

                if (favouriteGenre == genre)
                {
                    var movie = inputArr[0];

                    if (!dict.ContainsKey(movie))
                    {
                        dict[movie] = 0;
                    }

                    dict[movie] = duration;
                }

                totalDuration += duration;
            }
        }

        private static int CalculateTimeInSeconds(string timeAsString)
        {
            var arr = timeAsString
                .Split(new[] { ':' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            return arr[0] * 60 * 60 + arr[1] * 60 + arr[2];

        }
    }
}
