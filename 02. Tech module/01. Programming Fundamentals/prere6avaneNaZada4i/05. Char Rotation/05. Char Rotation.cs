namespace _05.Char_Rotation
{
    using System;


    class Array
    {

        public static void Main()
        {
            string firstLine = Console.ReadLine();
            char[] charArr = AssigningCharArr(firstLine);

            string secondLine = Console.ReadLine();
            int[] numbersArr = AssigningNumbersArr(secondLine);

            ModifyCharArr(charArr, numbersArr);

            Console.WriteLine(string.Join("",charArr));

        }

        public static char[] AssigningCharArr(string firstLine)
        {
            
            char[] charArr = new char[firstLine.Length];

            for (int i = 0; i < charArr.Length; i++)
            {
                charArr[i] = firstLine[i];
            }

            return charArr;
        }

        public static int[] AssigningNumbersArr(string secondLine)
        {
            string[] secondLineArr = secondLine.Split(' ');
            int[] numbersArr = new int[secondLineArr.Length];

            for (int i = 0; i < numbersArr.Length; i++)
            {
                numbersArr[i] = int.Parse(secondLineArr[i]);
            }

            return numbersArr;
        }

        public static void ModifyCharArr(char[] charArr, int[] numbersArr)
        {
            for (int i = 0; i < numbersArr.Length; i++)
            {
                if (numbersArr[i] % 2 == 0)
                {
                    charArr[i] = (char)(charArr[i] - numbersArr[i]);
                }
                else
                {
                    charArr[i] = (char)(charArr[i] + numbersArr[i]);
                }
            }
        }
    }
}
