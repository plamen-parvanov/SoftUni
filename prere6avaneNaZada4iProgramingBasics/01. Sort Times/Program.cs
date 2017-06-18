namespace _01.Sort_Times
{

    using System;
    using System.Collections.Generic;
    using System.Linq;


    public class Dictionaries
    {

        public static void Main()
        {
            var input = Console.ReadLine().Split(' ', ':').ToArray();

            var timesDict = new Dictionary<int, int>();

            for (int i = 0; i < input.Length; i += 2)
            {
                timesDict[int.Parse(input[i])] = int.Parse(input[i + 1]); 
            }

            var a = 0;

            

            

        }
    }
}
