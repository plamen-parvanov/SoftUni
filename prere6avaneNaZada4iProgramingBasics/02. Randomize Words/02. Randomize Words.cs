namespace _02.Randomize_Words
{

    using System;
    using System.Collections.Generic;
    using System.Linq;


    public class ObjectsAndclasses
    {

        public static void Main()
        {
            var wordArr = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            var random = new Random();
            var randomWord = random.Next(0, wordArr.Length);

            for (int i = 0; i < wordArr.Length; i++)
            {
                var temp = wordArr[i];
                wordArr[i] = wordArr[randomWord];
                wordArr[randomWord] = temp;
            }

            Console.WriteLine(string.Join("\n", wordArr));

        }
    }
}
