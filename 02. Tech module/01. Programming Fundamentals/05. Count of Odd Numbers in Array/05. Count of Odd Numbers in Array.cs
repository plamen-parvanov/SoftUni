namespace _05.Count_of_Odd_Numbers_in_Array
{

    using System;
    using System.Linq;


    public class Arrays
    {

        public static void Main()
        {
            var intArr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var countOddNums = 0;

            foreach (var number in intArr)
            {
                if (number % 2 != 0)
                {
                    countOddNums++;
                }
            }

            Console.WriteLine(countOddNums);
        }
    }
}
