namespace _08.Condense_Array_to_Number_Lab
{
    using System;


    public class Program
    {

        public static void Main()
        {
            string input = Console.ReadLine();
            string[] inputArr = input.Split(' ');
            int[] numbArr = InitNumbersArr(inputArr);

            CondenseBySumNumbArr(numbArr);

            Console.WriteLine(numbArr[0]);


        }

        public static void CondenseBySumNumbArr(int[] numbArr)
        {
            int length = numbArr.Length - 1;

            while (length > 0)
            {
                for (int i = 0; i < length; i++)
                {
                    numbArr[i] = numbArr[i] + numbArr[i + 1];
                }

                length--;
            }
        }

        public static int[] InitNumbersArr(string[] inputArr)
        {
            int[] numbersArr = new int[inputArr.Length];

            for (int i = 0; i < numbersArr.Length; i++)
            {
                numbersArr[i] = int.Parse(inputArr[i]);
            }

            return numbersArr;
        }
    }
}
