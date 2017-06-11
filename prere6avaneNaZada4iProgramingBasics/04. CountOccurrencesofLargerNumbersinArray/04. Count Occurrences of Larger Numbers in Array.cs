using System;


namespace _04.CountOccurrencesofLargerNumbersinArray
{
    class Program
    {
        static void Main()
        {
            string numbers = Console.ReadLine();
            double numberP = double.Parse(Console.ReadLine());

            string[] realNumbers = numbers.Split(' ');
            double[] realNumbersArr = new double[realNumbers.Length];
            InitializeAnArray(realNumbers, realNumbersArr);

            int cntBiggerThanPnums = 0;
            cntBiggerThanPnums = CountNumbersBiggerThanP(numberP, realNumbersArr, cntBiggerThanPnums);

            Console.WriteLine(cntBiggerThanPnums);
        }

        private static void InitializeAnArray(string[] realNumbers, double[] realNumbersArr)
        {
            for (int i = 0; i < realNumbers.Length; i++)
            {
                realNumbersArr[i] = double.Parse(realNumbers[i]);
            }
        }

        private static int CountNumbersBiggerThanP(double numberP, double[] realNumbersArr, int cntBiggerThanPnums)
        {
            foreach (var num in realNumbersArr)
            {
                if (num > numberP)
                {
                    cntBiggerThanPnums++;
                }
            }

            return cntBiggerThanPnums;
        }
    }
}
