using System;


namespace _06.Equal_Sequence_of_Elements_in_Array
{
    class Program
    {
        static void Main()
        {
            string text = Console.ReadLine();

            string[] splitedTextArr = text.Split(' ');
            int[] numbersArr = new int[splitedTextArr.Length];

            CopySpltdTextArrToNmbrsArr(splitedTextArr, numbersArr);

            ChackAreNumbersInArrEqual(numbersArr);
        }

        private static void ChackAreNumbersInArrEqual(int[] numbersArr)
        {
            int lastNumber = numbersArr[0];
            foreach (var number in numbersArr)
            {
                if (lastNumber != number)
                {
                    Console.WriteLine("No");
                    return;
                }
            }
            Console.WriteLine("Yes");
        }

        private static void CopySpltdTextArrToNmbrsArr(string[] splitedTextArr, int[] numbersArr)
        {
            for (int i = 0; i < splitedTextArr.Length; i++)
            {
                numbersArr[i] = int.Parse(splitedTextArr[i]);
            }
        }
    }
}
