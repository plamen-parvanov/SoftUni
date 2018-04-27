namespace _04.Rotate_Array_of_Strings
{

    using System;


    public class Problem
    {

        public static void Main()
        {
            var input = Console.ReadLine();
            var inputArr = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            var temp = inputArr[inputArr.Length - 1];

            for (int i = inputArr.Length - 1; i > 0; i--)
            {
                inputArr[i] = inputArr[i - 1];
            }

            inputArr[0] = temp;

            Console.WriteLine(string.Join(" ", inputArr));
        }
    }
}
