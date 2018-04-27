namespace _02.Reverse_Array_of_Integers_lab
{
    using System;


    public class Arrays
    {

        public static void Main()
        {
            int arrLenght = int.Parse(Console.ReadLine());
            int[] intArr = InitializeIntArr(arrLenght);

            ReversingIntArr(arrLenght, intArr);

            Console.WriteLine(string.Join(" ", intArr));

        }

        public static int[] InitializeIntArr(int arrLenght)
        {
            var intArr = new int[arrLenght];

            for (int i = 0; i < arrLenght; i++)
            {
                intArr[i] = int.Parse(Console.ReadLine());
            }

            return intArr;
        }

        public static void ReversingIntArr(int arrLenght, int[] intArr)
        {
            for (int i = 0; i < arrLenght / 2; i++)
            {
                int secondEll = arrLenght - 1 - i;
                int temp = intArr[i];
                intArr[i] = intArr[secondEll];
                intArr[secondEll] = temp;
            }
        }


    }
}
