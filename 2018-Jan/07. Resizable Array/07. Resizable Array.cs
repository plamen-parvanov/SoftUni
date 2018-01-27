namespace _07.Resizable_Array
{

    using System;

    public class Problem07
    {

        public static void Main()
        {
            var intArr = new int[0];

            while (true)
            {
                var inputLine = Console.ReadLine()
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                if (inputLine[0].Equals("end"))
                {
                    break;
                }

                intArr = ExecuteCommandLine(intArr, inputLine);
            }

            if (intArr.Length == 0)
            {
                Console.WriteLine("empty array");
            }
            else
            {
                Console.WriteLine(string.Join(" ", intArr));
            }
            
        }

        public static int[] ExecuteCommandLine(int[] intArr, string[] input)
        {
            if (input[0].Equals("push"))
            {
                var numToAdd = int.Parse(input[1]);
                 intArr = PushElement(intArr, numToAdd);
            }
            else if (input[0].Equals("pop"))
            {
                intArr = PopElement(intArr);
            }
            else if (input[0].Equals("removeAt"))
            {
                var indexToRemoveAt = int.Parse(input[1]);
                intArr = RemoveEllement(intArr, indexToRemoveAt);
            }
            else if (input[0].Equals("clear"))
            {
                intArr = new int[0];
            }

            return intArr;
        }

        public static int[] PushElement(int[] intArr, int numToAdd)
        {
            var newArr = new int[intArr.Length + 1];

            for (int i = 0; i < intArr.Length; i++)
            {
                newArr[i] = intArr[i];
            }

            newArr[newArr.Length - 1] = numToAdd;

            return newArr;
        }

        public static int[] PopElement(int[] intArr)
        {
            var newArr = new int[intArr.Length - 1];

            for (int i = 0; i < newArr.Length; i++)
            {
                newArr[i] = intArr[i];
            }

            return newArr;
        }

        public static int[] RemoveEllement(int[] intArr, int indexToRemoveAt)
        {
            var newArr = new int[intArr.Length - 1];

            for (int i = 0, j = 0; i < newArr.Length; i++, j++)
            {
                if (j == indexToRemoveAt)
                {
                    j++;
                }

                newArr[i] = intArr[j];
            }

            return newArr;
        }
    }
}
