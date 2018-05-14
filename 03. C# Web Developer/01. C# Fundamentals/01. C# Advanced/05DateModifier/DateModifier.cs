using System;
using System.Globalization;

public class DateModifier
{
    public static double CalcDiffInDays(string firstDateAsString, string secondDateAsString)
    {
        var firstDate = GetDate(firstDateAsString);
        var secondDate = GetDate(secondDateAsString);

        return Math.Abs(firstDate.Subtract(secondDate).TotalDays);
    }

    private static DateTime GetDate(string dateAsString)
    {
        return DateTime.ParseExact(dateAsString, "yyyy MM dd", CultureInfo.InvariantCulture);
    }
}
