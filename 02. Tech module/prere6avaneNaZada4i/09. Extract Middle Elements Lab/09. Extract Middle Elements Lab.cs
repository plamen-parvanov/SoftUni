namespace _09.Extract_Middle_Elements_Lab
{
    using System;

    
    public class Arrays
    {

        public static void Main()
        {
            string input = Console.ReadLine();

            var numberArr = InitializeIntArrFromInput(input);
            int length = numberArr.Length;

            if (length == 1)
            {
                Console.WriteLine("{{ {0} }}", numberArr[0]);
            }
            else
            {
                int[] middleNumbs = CopyMiddleNubsFromIntArr(numberArr, length);

                Console.WriteLine("{ " + string.Join(", ", middleNumbs) + " }");                 
            }


        }

        public static int[] InitializeIntArrFromInput(string input)
        {
            string[] inputSplit = input.Split(' ');
            int[] numberArr = new int[inputSplit.Length];

            for (int i = 0; i < numberArr.Length; i++)
            {
                numberArr[i] = int.Parse(inputSplit[i]);
            }

            return numberArr;
        }

        public static int[] CopyMiddleNubsFromIntArr(int[] intArr, int length)
        {
            int[] middleNumbs = new int[2 + length % 2];

            for (int i = length / 2 - 1, j = 0; i <= length / 2 + length % 2; i++, j++)
            {
                middleNumbs[j] = intArr[i];
            }

            return middleNumbs;
        }
    }
}
