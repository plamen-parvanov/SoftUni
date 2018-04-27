namespace _05.Compare_Char_Arrayss
{
    using System;


    public class Program
    {
        public static void Main()
        {
            string firstInput = Console.ReadLine();
            char[] firstInputArr = InitiInputToCharArr(firstInput);

            string secondInput = Console.ReadLine();
            char[] secondInputArr = InitiInputToCharArr(secondInput);

            bool IsFirstArr = CompareCharsInArr(firstInputArr, secondInputArr);

            PrintResult(firstInputArr, secondInputArr, IsFirstArr);

        }

        

        public static bool CompareCharsInArr(char[] firstArr, char[] secondArr)
        {
            int minLength = Math.Min(firstArr.Length, secondArr.Length);

            for (int i = 0; i < minLength; i++)
            {
                if (firstArr[i] < secondArr[i])
                {
                    return true;
                }
                else if (firstArr[i] > secondArr[i])
                {
                    return false;
                }
            }

            if (firstArr.Length < secondArr.Length)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static void PrintResult(char[] firstInputArr, char[] secondInput, bool IsFirstArr)
        {
            if (IsFirstArr)
            {
                Console.WriteLine(string.Join("", firstInputArr));
                Console.WriteLine(string.Join("", secondInput));
            }
            else
            {
                Console.WriteLine(string.Join("", secondInput));
                Console.WriteLine(string.Join("", firstInputArr));
            }
        }

        public static char[] InitiInputToCharArr(string input)
        {
            string[] inputArr = input.Split(' ');
            char[] charArr = new char[inputArr.Length];

            for (int i = 0; i < charArr.Length; i++)
            {
                charArr[i] = char.Parse(inputArr[i]);
            }
            return charArr;
        }

       

    }
}
