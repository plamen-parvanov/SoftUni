namespace _08.Logs_Aggregator
{

    using System;
    using System.Collections.Generic;
    using System.Linq;
 

    public class Dictionaries
    {

        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var userIPandDuration =
                   new SortedDictionary<string, SortedDictionary<string, int>>();

            for (int i = 0; i < n; i++)
            {
                var inputLine = Console.ReadLine().Split().ToArray();
                var userName = inputLine[1];
                var userIP = inputLine[0];
                var duration = int.Parse(inputLine[2]);  

                if (!userIPandDuration.Keys.Contains(userName))
                {
                    userIPandDuration[userName] = new SortedDictionary<string, int>();
                }

                if (!userIPandDuration[userName].Keys.Contains(userIP))
                {
                    userIPandDuration[userName][userIP] = 0;
                }
                    userIPandDuration[userName][userIP] += duration;
                 
        
            }

            foreach (var kvp in userIPandDuration)
            {  
                Console.WriteLine("{0}: {1} [{2}]",
                    kvp.Key, kvp.Value.Values.Sum(), string.Join(", ", kvp.Value.Keys));
            }

        }
    }
}
