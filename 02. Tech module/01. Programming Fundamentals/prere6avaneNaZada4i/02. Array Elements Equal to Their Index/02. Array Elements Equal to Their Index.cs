using System;


namespace _02.Array_Elements_Equal_to_Their_Index
{
    class Program
    {
        static void Main()
        {
            string text = Console.ReadLine();

            string[] splitedText = text.Split(' ');
            int[] numbersArr = new int[splitedText.Length];

            CopyTextArrInNumbArr(splitedText, numbersArr);

            PrintElementEqualToTheirIndex(numbersArr);

        }

        private static void PrintElementEqualToTheirIndex(int[] numbersArr)
        {
            for (int i = 0; i < numbersArr.Length; i++)
            {
                if (numbersArr[i] == i)
                {
                    Console.Write($"{i} ");
                }
            }
            Console.WriteLine();
        }

        private static void CopyTextArrInNumbArr(string[] splitedText, int[] numbersArr)
        {
            for (int i = 0; i < numbersArr.Length; i++)
            {
                numbersArr[i] = int.Parse(splitedText[i]);
            }
        }
    }
}
