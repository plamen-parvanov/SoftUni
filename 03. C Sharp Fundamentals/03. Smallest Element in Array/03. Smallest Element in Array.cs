namespace _03.Smallest_Element_in_Array
{

    using System;


    public class Problem03
    {

        public static void Main()
        {
            var input = Console.ReadLine();
            var inputArr = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var intArr = new int[inputArr.Length];

            InitializeIntArr(inputArr, intArr);

            var minNumInArr = GetMinNumFromIntArr(intArr);

            Console.WriteLine(minNumInArr);
        }

        public static void InitializeIntArr(string[] inputArr, int[] intArr)
        {
            for (int i = 0; i < inputArr.Length; i++)
            {
                intArr[i] = int.Parse(inputArr[i]);
            }
        }

        public static int GetMinNumFromIntArr(int[] arr)
        {
            var min = int.MaxValue;

            foreach (var num in arr)
            {
                if (num < min)
                {
                    min = num;
                }
            }

            return min;            
        }
    }
}
