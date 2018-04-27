namespace _04.Character_Multiplier
{

    using System;


    public class Strings
    {

        public static void Main()
        {
            var inputLine = Console.ReadLine().Split();
            var firstString = inputLine[0];
            var secondString = inputLine[1];
            var length1 = firstString.Length;
            var length2 = secondString.Length;

            var result = ManipulateTwoStrings(firstString, secondString);            

            if (length1 > length2)
            {
                result += GetSumFromLongerString(firstString, length2);
            }
            else if (length2 > length1)
            {
                result += GetSumFromLongerString(secondString, length1);
            }

            Console.WriteLine(result);

        }

        public static int ManipulateTwoStrings(string firstString, string secondString)
        {
            var result = 0;
            var minLengh = Math.Min(firstString.Length, secondString.Length);

            for (int i = 0; i < minLengh; i++)
            {
                result += (int)firstString[i] * (int)secondString[i];
            }

            return result;
        }


        public static int GetSumFromLongerString(string longer, int lenght)
        {
            var sum = 0;

            for (int i = lenght; i < longer.Length; i++)
            {
                sum += (int)longer[i];
            }

            return sum;
        }
    }
}
