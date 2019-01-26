using System;

namespace DefiningClasses
{
    public static class DataModifier
    {
        public static int CalculatesDifference(string firstString, string secondString)
        {
            var firstDate = ReadDate(firstString);
            var secondDate = ReadDate(secondString);

            TimeSpan result = firstDate - secondDate;

            return Math.Abs(result.Days);
        }

        private static DateTime ReadDate(string dateAsString)
        {
            var date = DateTime.ParseExact(dateAsString, "yyyy MM dd", System.Globalization.CultureInfo.InvariantCulture);

            return date;
        }
    }

   
}
