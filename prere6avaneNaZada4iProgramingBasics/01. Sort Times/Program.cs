namespace _01.Sort_Times
{

    using System;
    using System.Collections.Generic;
    using System.Linq;


    public class Dictionaries
    {

        public static void Main()
        {
            var inputTime = Console.ReadLine().Split().ToArray();
            var timeDict = InitialiseDictionary(inputTime);

            timeDict = timeDict.OrderBy(v => v.Value).ToDictionary(pair => pair.Key, pair => pair.Value);

            Console.WriteLine(string.Join(", ", timeDict.Keys));

        }

        public static Dictionary<string, int> InitialiseDictionary(string[] inputTime)
        {
            var timeDict = new Dictionary<string, int>();

            for (int i = 0; i < inputTime.Length; i++)
            {
                var time = inputTime[i];
                timeDict[time] = GetTimeInMinutes(time);
            }

            return timeDict;
        }

        public static int GetTimeInMinutes(string time)
        {
            var timeArr = time.Split(':').Select(int.Parse).ToArray();
            var timeInSeconds = timeArr[0] * 60 + timeArr[1];

            return timeInSeconds;
        }
    }
}
