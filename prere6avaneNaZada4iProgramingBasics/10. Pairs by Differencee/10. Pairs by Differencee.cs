namespace _10.Pairs_by_Differencee
{
    using System;
    using System.Linq;

    public class Arrays
    {

        public static void Main()
        {
            var numberArr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int diff = int.Parse(Console.ReadLine());
            int countDiff = 0;

            for (int i = 0; i < numberArr.Length; i++)
            {
                for (int j = 0; j < numberArr.Length; j++)
                {
                    if (numberArr[i] - numberArr[j] == diff)
                    {
                        countDiff++;
                    }
                }
            }

            Console.WriteLine(countDiff);
        }
    }
}
