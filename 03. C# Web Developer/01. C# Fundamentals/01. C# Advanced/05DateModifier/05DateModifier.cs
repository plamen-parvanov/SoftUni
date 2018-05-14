using System;

public class Program
{
    static void Main()
    {
        var first = Console.ReadLine();
        var second = Console.ReadLine();

        var result = DateModifier.CalcDiffInDays(first, second);

        Console.WriteLine(result);
    }
}
