namespace _07.Bomb_Numbers
{

    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Lists
    {

        public static void Main()
        {
            var inputList = Console.ReadLine().Split().Select(int.Parse).ToList();
            var numberArr = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int bombPower = numberArr[1];
            int numToBlow = numberArr[0];

            bool haveBomb = true;
            int indexToBlow = GetIndexOfTheBomb(inputList, numToBlow,ref haveBomb);

            while (haveBomb)
            {
                BlowRightNumsAndMiddle(indexToBlow, inputList, bombPower);

                BlowLeftNums(indexToBlow, inputList, bombPower);

                indexToBlow = GetIndexOfTheBomb(inputList, numToBlow, ref haveBomb);
            }

            int sum = SumLeftNumbers(inputList);

            Console.WriteLine(sum);
            
        }

        public static int GetIndexOfTheBomb(List<int> inputList, int numToBlow, ref bool haveBomb)
        {
            int indexToBlow = -1;

            for (int i = 0; i < inputList.Count; i++)
            {
                if (inputList[i] == numToBlow)
                {
                    indexToBlow = i;
                    haveBomb = true;
                    return indexToBlow;
                }
            }

            haveBomb = false;
            return indexToBlow;
        }

        public static void BlowRightNumsAndMiddle(int indexToBlow, List<int> inputList, int bombPower)
        {
            for (int i = bombPower; i >= 0 && indexToBlow < inputList.Count; i--)
            {
                inputList.RemoveAt(indexToBlow);
            }

        }

        public static void BlowLeftNums(int indexToBlow, List<int> inputList, int bombPower)
        {
            for (int i = bombPower, j = 1; i > 0 && indexToBlow - j >= 0; i--, j++)
            {
                inputList.RemoveAt(indexToBlow - j);

            }

        }

        public static int SumLeftNumbers(List<int> inputList)
        {
            int sum = 0;

            foreach (var number in inputList)
            {
                sum += number;
            }

            return sum;

        }

    }
}
