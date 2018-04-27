namespace _05.Decode_Radio_Frequencies
{

    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Problem05
    {

        public static void Main()
        {
            var input = Console.ReadLine();
            var listOfFreq = input
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            var list1 = new List<char>();
            var list2 = new List<char>();

            foreach (var freq in listOfFreq)
            {
                var freqArr = freq
                    .Split(new[] { '.' },StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                if (freqArr[0] != "0")
                {
                    list1.Add((char)int.Parse(freqArr[0]));
                }

                if (freqArr[1] != "0")
                {
                    list2.Add((char)int.Parse(freqArr[1]));
                }
                
            }

            list2.Reverse();

            Console.WriteLine(string.Join("", list1) + string.Join("", list2));
        }
    }
}
