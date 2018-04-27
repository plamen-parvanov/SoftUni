namespace _03.Record_Unique_Names
{

    using System;
    using System.Collections.Generic;

    public class Problem03
    {

        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var uniqueNames = new HashSet<string>();

            for (int i = 0; i < n; i++)
            {
                uniqueNames.Add(Console.ReadLine());
            }

            Console.WriteLine(string.Join(Environment.NewLine, uniqueNames));
    
        }
    }
}
