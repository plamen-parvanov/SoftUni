namespace _07.Sum_Arrays_lab
{
    using System;


    public class Arrays
    {

        public static void Main()
        {
            string firstInput = Console.ReadLine();
            string[] firstArr = firstInput.Split(' ');
            int[] firstIntArr = new int[firstArr.Length];
            InitIntArr(firstArr, firstIntArr);

            string secondInput = Console.ReadLine();
            string[] secondArr = secondInput.Split(' ');
            int[] secondIntArr = new int[secondArr.Length];
            InitIntArr(secondArr, secondIntArr);

            var sumArr = InitSumArr(firstIntArr, secondIntArr);

            Console.WriteLine(string.Join(" ", sumArr));

        }

        public static int[] InitSumArr(int[] firstIntArr, int[] secondIntArr)
        {
            int maxLength = Math.Max(secondIntArr.Length, firstIntArr.Length);
            int[] sumArr = new int[maxLength];

            for (int i = 0; i < sumArr.Length; i++)
            {
                sumArr[i] = firstIntArr[i % firstIntArr.Length] + secondIntArr[i % secondIntArr.Length];
            }
            return sumArr;
        }

        public static void InitIntArr(string[] firstArr, int[] firstIntArr)
        {
            for (int i = 0; i < firstArr.Length; i++)
            {
                firstIntArr[i] = int.Parse(firstArr[i]);
            }
        }
    }
}
