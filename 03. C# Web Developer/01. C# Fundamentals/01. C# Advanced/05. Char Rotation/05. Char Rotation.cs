namespace _05.Char_Rotation
{

    using System;

    public class Problem05
    {

        public static void Main()
        {
            // num[] - char string[]
            var firstLine = Console.ReadLine();
                
            var charArr = InitializeCharArr(firstLine);

            var secondLine = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var intArr = InitializeIntArr(secondLine);

            ExecuteModification(charArr, intArr);

            Console.WriteLine(string.Join("", charArr));

        }

        public static char[] InitializeCharArr(string str)
        {
            var charArr = new char[str.Length];

            for (int i = 0; i < str.Length; i++)
            {
                charArr[i] = str[i];
            }

            return charArr;
        }

        public static int[] InitializeIntArr(string[] arr)
        {
            var intArr = new int[arr.Length];

            for (int i = 0; i < arr.Length; i++)
            {
                intArr[i] = int.Parse(arr[i]);
            }

            return intArr;
        }

        public static void ExecuteModification(char[] charArr, int[] intArr)
        {
            for (int i = 0; i < charArr.Length; i++)
            {
                if (intArr[i] % 2 != 0)
                {
                    charArr[i] = (char)(charArr[i] + intArr[i]);
                }
                else
                {             
                    charArr[i] = (char)(charArr[i] - intArr[i]);
                }

            }

        }

    }
}
