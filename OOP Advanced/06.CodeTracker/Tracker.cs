using System;
using System.Linq;
using System.Reflection;

public class Tracker
{
    public static void PrintMethodsByAuthor()
    {
        var type = Type.GetType("StartUp");

        var methods = type.GetMethods(BindingFlags.Public | BindingFlags.NonPublic |
            BindingFlags.Instance | BindingFlags.Static);


        foreach (var method in methods)
        {
            var attributes = method.GetCustomAttributes(false)
                .Where(a => a.GetType() == typeof(SoftUniAttribute));

            foreach (SoftUniAttribute attribute in attributes)
            {
                Console.WriteLine($"{method.Name} is written by {attribute.Name}");
            }
        }
    }
}
